using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVFS.Entities;
using Raven.Client;
using Raven.Client.Embedded;
namespace DVFS.Core
{
    public class DvfsWithPowerProfile
    {
        public EmbeddableDocumentStore _store;
        public CalculatorFacade _calculator;
        public int _iteration = 0;
        private int lid = 1000;
        public double QuantaSize
        {
            get { return 0.2; }
        }

        public bool IsOverFlow = false;
        public double totalTime = 0.0;
        public double deadline = 0.0;
        public DvfsWithPowerProfile(EmbeddableDocumentStore store,double taskDeadline)
        {
            this._store = store;
            _store.Initialize();
            _calculator = new CalculatorFacade(store);
            deadline = taskDeadline;
        }
        
        /// <summary>
        /// Prepares the operation of iterative increamenting of the time extension
        /// </summary>
        /// <returns></returns>
        public bool InitializeIteration()
        {
            try
            {
                var tasks = new List<string>();
                var processors = _calculator.GetAllProcessors();
                TaskLog log;
                using (var session = _store.OpenSession())
                {
                    if (!session.Query<TaskLog>().Any())
                    {
                        foreach (var processor in processors)
                        {
                            tasks = _calculator.GetTasksInProcessor(processor.Code);
                            foreach (var task in tasks)
                            {
                                log = new TaskLog()
                                    {
                                        IterationNumber = _iteration,
                                        Task = task,
                                        TreshHoldVoltage = _calculator.GetTrVoltageAttribute(processor.Code),
                                        Processor = processor.Code,
                                        EnergyGradiant = 0.0,
                                        ExtendedTime = _calculator.GetExecutionTimeFor(task, processor.Code),
                                        NewVoltage = _calculator.GetOpVoltageAttribute(processor.Code),
                                        NewPower = _calculator.GetPowerAttributeFor(task)
                                    };
                                session.Store(log,lid.ToString());
                                lid++;
                            }
                        }
                        session.SaveChanges();
                    }
                }
                
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<TaskLog> StartCalculation()
        {
            
            using (var session = _store.OpenSession())
            {
                var tempLog = new List<TaskLog>();
                while (!IsOverFlow)
                {
                    var initialLog = session.Query<TaskLog>().Where(l => l.IterationNumber == _iteration).ToList();
                    _iteration++;
                    tempLog = new List<TaskLog>();
                    TaskLog log;
                    if (!initialLog.Any())
                        IsOverFlow = true;
                    foreach (var taskLog in initialLog)
                    {
                        var ext = ExtensionFactor(taskLog.ExtendedTime);
                        var newVoltage = _calculator.CalculateNewVoltage(ext, taskLog.NewVoltage, taskLog.TreshHoldVoltage);
                        var newPower = _calculator.CalculateNewPower(ext, taskLog.NewVoltage, newVoltage,
                                                                     taskLog.NewPower);
                        var deltaE = CalculateDeltaEnergy(newPower, taskLog.NewPower, taskLog.ExtendedTime);//Note that tasklog's new power is of previous iteration, so technicaly its old value
                        log=new TaskLog()
                            {
                                IterationNumber = _iteration,
                                Task = taskLog.Task,
                                Processor = taskLog.Processor,
                                TreshHoldVoltage = taskLog.TreshHoldVoltage,
                                ExtendedTime = taskLog.ExtendedTime+QuantaSize,
                                NewVoltage = newVoltage,
                                NewPower = newPower,
                                EnergyGradiant = deltaE
                            };
                        taskLog.EnergyGradiant = deltaE;
                        tempLog.Add(log);
                    }
                    var highGradiantlog=tempLog.OrderByDescending(l=>l.EnergyGradiant);
                    if (highGradiantlog.Any())
                    {
                        var first = highGradiantlog.ElementAt(0);
                        var second = highGradiantlog.ElementAt(1);
                        if (first.EnergyGradiant > second.EnergyGradiant)
                        {
                            //update only one
                            var updatelog = initialLog.FirstOrDefault(i => i.Task == first.Task);
                            initialLog.Remove(updatelog);
                            initialLog.Add(first);
                        }
                        else if (Convert.ToDecimal(first.EnergyGradiant)==Convert.ToDecimal(second.EnergyGradiant))
                        {
                           //update two
                            var updatelog1 = initialLog.FirstOrDefault(i => i.Task == first.Task);
                            var updatelog2 = initialLog.FirstOrDefault(i => i.Task == second.Task);
                            initialLog.Remove(updatelog1);
                            initialLog.Remove(updatelog2);
                            initialLog.Add(first);
                            initialLog.Add(second);
                        }
                    }

                    //6. Update task with max Delta E
                    
                    foreach (var taskLog in initialLog)
                    {
                        var newLog = new TaskLog()
                            {
                                IterationNumber = _iteration,
                                Task = taskLog.Task,
                                Processor = taskLog.Processor,
                                EnergyGradiant = taskLog.EnergyGradiant,
                                ExtendedTime = taskLog.ExtendedTime,
                                NewPower = taskLog.NewPower,
                                NewVoltage = taskLog.NewVoltage,TreshHoldVoltage = taskLog.TreshHoldVoltage
                            };
                        session.Store(newLog,lid.ToString("####"));
                        lid++;
                    }
                    session.SaveChanges();
                    totalTime = GetTotalTime(initialLog);
                    if (totalTime > deadline)
                        IsOverFlow = true;
                }
                var iter = _iteration - 1;
                return session.Query<TaskLog>().Where(t => t.IterationNumber == iter).ToList();
            }
        }

        public double ExtensionFactor(double time)
        {
            return ((time + QuantaSize)/time);
        }
        public double CalculateDeltaEnergy(double newpower,double originalPower,double originalTime)
        {
            double extendedtime = originalTime + QuantaSize;
            return ((originalPower*originalTime) - (newpower*extendedtime));
        }
        public double GetTotalTime(List<TaskLog> log)
        {
            //not like this 
            var overlap = "B";//Took lots of computing ... hard coded for simplcity
            //using (var session = _store.OpenSession())
            //{
            //    List<Schedule> schedules;
            //    schedules = session.Query<Schedule>().ToList();
            //    foreach (var graph in schedules)
            //    {
            //        foreach (var process in graph.Processors)
            //        {
            //            foreach (var column in process.Tasks)
            //            {
            //                foreach (var secondcol in process.Tasks.Where(secondcol => column.StartTime == secondcol.StartTime))
            //                {
            //                    overlap = secondcol.Task;
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //}
            return log.Where(taskLog => taskLog.Task != overlap).Sum(taskLog => taskLog.ExtendedTime);
        }
    }
}
