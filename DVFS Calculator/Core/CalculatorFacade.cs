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
    public class CalculatorFacade
    {
        #region Public Memebers
        public IDocumentQuery<AppTask> allTasks;
        public IDocumentQuery<ProcessingElement> allProcessors;
        public IDocumentQuery<ProcessorTaskAttribute> allAttributes;
        public IDocumentQuery<MappingGraph> allMapping;
        public List<Schedule> Schedules { get; set; }
        public int IterationNumber { get; set; }
        public double EndTime { get; set; }
#endregion

        public EmbeddableDocumentStore documentStore;
        public CalculatorFacade(EmbeddableDocumentStore store)
        {
            documentStore = store;
            documentStore.Initialize();
        }
        public double QuadraticEquationSolver(double a, double b, double c)
        {
            double sqrtpart = b * b - 4 * a * c;
            double x, x1, x2;
            if (sqrtpart > 0)
            {
                x1 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                x2 = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);
                return x1 > x2 ? x1 : x2;
            }
            else if(sqrtpart==0)
            {
                x = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                return x;
            }
            else 
            {
                throw new Exception("Imaginary number in voltage");
            }
            
        }

        public double CalculateTotalEnergy()
        {
            var energy = 0.0;
            var mappingGraph = new List<MappingGraph>();
            using (var session = documentStore.OpenSession())
            {
                mappingGraph = session.Query<MappingGraph>().ToList();
            }
            foreach (var graph in mappingGraph)
            {
                foreach (var task in graph.Tasks)
                {
                    //do the multiplication and addition here. and add it to energy
                    energy += (GetExecutionTimeFor(task, graph.Procesor)*GetPowerProfileFor(task, graph.Procesor));
                }
            }
            return energy;
        }

        public double CalculateAveragePower()
        {
            var energy = CalculateTotalEnergy();
            //var totalTime = 0.0;
            //using (var session = documentStore.OpenSession())
            //{
            //    List<MappingGraph> mapping;
            //    mapping = session.Query<MappingGraph>().ToList();
            //    foreach (var graph in mapping)
            //    {
            //        foreach (var task in graph.Tasks)
            //        {
            //            //do the multiplication and addition here. and add it to energy
            //            totalTime += GetExecutionTimeFor(task, graph.Procesor);
            //        }
            //    }
            //}
            return energy/this.EndTime;
        }

        public double CalculateEnergyForTask(string task, string processor)
        {
            return GetExecutionTimeFor(task, processor)*GetPowerProfileFor(task, processor);
        }

        public double CalculateSlackTime(double deadline,int iterationNo,double lastTime)
        {
          //slackTime = deadline - totalTime;
            return deadline-lastTime;
        }

        public double CalculateExtensioFactor(double extendedTime, int iterationNo, double orginalTime)
        {
            return (extendedTime/orginalTime);
        }

        public List<double> GetNewVoltageForAll(double extentionFactor)
        {
            List<double> values;
            using (var session = documentStore.OpenSession())
            {
                values = new List<double>();
                var processors = session.Query<ProcessingElement>().ToList();
                foreach (var processor in processors)
                {
                    values.Add(CalculateNewVoltage(extentionFactor,processor.OperatingVoltage,processor.TresholdVoltage));
                }
            }
            return values;
        }
        public List<double> GetNewPowerForAll(double extentionFactor)
        {
            List<double> values;
            using (var session = documentStore.OpenSession())
            {
                values = new List<double>();
                var processors = session.Query<ProcessingElement>().ToList();
                foreach (var processor in processors)
                {
                    var vnew = GetNewVoltageForProcessor(extentionFactor, processor.Code);
                    var mapped = session.Query<MappingGraph>().FirstOrDefault(m => m.Procesor == processor.Code);
                    foreach (var appTask in mapped.Tasks)
                    {
                        var attribs =
                            session.Query<ProcessorTaskAttribute>()
                                   .Where(a => a.Processor == processor.Code)
                                   .FirstOrDefault(t => t.Task == appTask);
                        values.Add(CalculateNewPower(extentionFactor,processor.OperatingVoltage,vnew,attribs.DynamicPower));
                    }
                }
            }
            return values;
        }
        public double GetNewVoltageForProcessor(double extensionFactor,string processor)
        {
            using (var session = documentStore.OpenSession())
            {
               
                var processors = session.Query<ProcessingElement>().FirstOrDefault(p=>p.Code==processor);
                var value=CalculateNewVoltage(extensionFactor, processors.OperatingVoltage,processors.TresholdVoltage);
                
                return value;
            }
        }
        public double CalculateNewVoltage(double extentionFactor,double Vdd,double Vtr)
        {
          //e=((V_old - V_tresh) squared /V_old) divided by same equation but V_new is required
            double ret = 0.0;
            var temp = 0.0;//equals a
            temp = (((Vdd*Vdd) - (2*Vtr*Vdd) + (Vtr*Vtr))/(extentionFactor*Vdd));
            double a, b, c;
            a = 1.0;
            b = ((-2*Vtr) - temp);
            c = (Vtr*Vtr);
            ret = QuadraticEquationSolver(a, b, c);
            return ret;
        }

        public double CalculateNewPower(double extentionFactor,double vdd,double vnew,double oldPower)
        {
            //new power = power original*square of new V divided by e*square of old v
            var temp = 0.0;
            temp = ((vnew*vnew*oldPower)/(vdd*vdd*extentionFactor));
            return temp;
        }


        public double CalculateEnergyGradiant(double oldEnergy,double newEnergy)
        {
            //Old Energy minus the new calculated energy and save it for next iteration
            return oldEnergy-newEnergy;
        }

        public List<ScheduleRow> GenerateSchedule(int iterationNumber)
        {
            List<ScheduleRow> scheduleRows;
            try
            {
                var parent = ScheduleParent();
                var children = ScheduleChildren(parent[0]);
                var thirdLevel = new List<ScheduleColumn>();
                foreach (var child in children)
                {
                    var stillchild = ScheduleChildren(child);
                    thirdLevel.AddRange(stillchild);
                }
                var row = new ScheduleRow();
                scheduleRows = new List<ScheduleRow>();
                using (var session = documentStore.OpenSession())
                {
                    var columns = new List<ScheduleColumn>();
                    var processors = session.Query<ProcessingElement>().ToList();
                    columns.AddRange(parent);
                    columns.AddRange(children);
                    columns.AddRange(thirdLevel);
                    row = new ScheduleRow() {Processor = "All",Tasks = columns};
                    scheduleRows.Add(row);
                }
                return scheduleRows;
            }
            catch (Exception exception)
            {
                throw new Exception("Unable to generate schedule",exception);
            }
        }

        public List<ScheduleColumn> ScheduleParent()
        {
            List<ScheduleColumn> columns;
            using (var session = documentStore.OpenSession())
            {
                columns = new List<ScheduleColumn>();
                var task = session.Query<AppTask>().FirstOrDefault(t => t.ParentTask == "Root");
                var mapping = session.Query<MappingGraph>().Where(m=>m.Tasks.Contains(task.Code));
                foreach (var processor in mapping)
                {
                    var pe = processor.Procesor;
                    if (pe!="")
                    {
                        var attributes =
                            session.Query<ProcessorTaskAttribute>()
                                   .Where(a => a.Processor == pe)
                                   .FirstOrDefault(a => a.Task == task.Code);
                        columns.Add(new ScheduleColumn()
                        {
                            Processor = pe,
                            Task = task.Code,
                            DynamicPower = attributes.DynamicPower,
                            StartTime = 0.0,
                            EndTime = attributes.ExecutionTime
                        });
                    }
                }
            }
            return columns;
        }

        public List<ScheduleColumn> ScheduleChildren(ScheduleColumn parentSchedule)
        {
            List<ScheduleColumn> columns;
            double time = parentSchedule.EndTime;
            double previousTime = 0;//to check parallel processors
            using (var session = documentStore.OpenSession())
            {
                columns = new List<ScheduleColumn>();
                var task = session.Query<AppTask>().Where(t => t.ParentTask == parentSchedule.Task);
                foreach (var appTask in task)
                {
                    var mapping = session.Query<MappingGraph>().Where(m => m.Tasks.Contains(appTask.Code));
                    foreach (var processor in mapping)
                    {
                        var pe = processor.Procesor;
                        if (pe != "")
                        {
                            var attributes =
                                session.Query<ProcessorTaskAttribute>()
                                       .Where(a => a.Processor == pe)
                                       .FirstOrDefault(a => a.Task == appTask.Code);
                            
                            columns.Add(new ScheduleColumn()
                            {
                                Processor = pe,
                                Task = appTask.Code,
                                DynamicPower = attributes.DynamicPower,
                                StartTime = time+previousTime,
                                EndTime = time + attributes.ExecutionTime
                            });
                            this.EndTime = time + attributes.ExecutionTime;
                        }
                    }
                }
                
            }
            return columns;
        }



        #region Helper Methods
        public double GetExecutionTimeFor(string task, string processor)
        {
            using (var session = documentStore.OpenSession())
            {
                return
                    session.Query<ProcessorTaskAttribute>()
                           .Where(t => t.Task == task)
                           .FirstOrDefault(t => t.Processor==processor)
                           .ExecutionTime;
            }
        }
        public double GetPowerProfileFor(string task, string processor)
        {
            using (var session = documentStore.OpenSession())
            {
                return
                    session.Query<ProcessorTaskAttribute>()
                           .Where(t => t.Task == task)
                           .FirstOrDefault(t => t.Processor == processor)
                           .DynamicPower;
            }
        }
        public IDocumentQuery<MappingGraph> GetMappingGraph()
        {
            IDocumentQuery<MappingGraph> mappings;
            using (var session = documentStore.OpenSession())
            {
                mappings=session.Advanced.LuceneQuery<MappingGraph>().WaitForNonStaleResults();
            }
            return mappings;
        }

        public IDocumentQuery<AppTask> GetAllTasks()
        {
            using (var session = documentStore.OpenSession())
            {
                return session.Advanced.LuceneQuery<AppTask>().WaitForNonStaleResults();
            }
        }

        public IDocumentQuery<ProcessingElement> GetAllProcessors()
        {
            using (var session = documentStore.OpenSession())
            {
                return session.Advanced.LuceneQuery<ProcessingElement>().WaitForNonStaleResults();
            }
        }

        public IDocumentQuery<ProcessorTaskAttribute> GetProcessorAttributes()
        {
            using (var session = documentStore.OpenSession())
            {
                return session.Advanced.LuceneQuery<ProcessorTaskAttribute>().WaitForNonStaleResults();
            }
        }
        public List<string> GetTasksInProcessor(string processor)
        {
            List<string> tasks;
            using (var session = documentStore.OpenSession())
            {
                tasks = new List<string>();
                tasks = session.Query<MappingGraph>().FirstOrDefault(m => m.Procesor == processor).Tasks;
            }
            return tasks;
        }
        public double GetOpVoltageAttribute(string processor)
        {
            using (var session = documentStore.OpenSession())
            {
                var pe = session.Query<ProcessingElement>().FirstOrDefault(p => p.Code == processor);
                return pe.OperatingVoltage;
            }
        }
        public double GetTrVoltageAttribute(string processor)
        {
            using (var session = documentStore.OpenSession())
            {
                var pe = session.Query<ProcessingElement>().FirstOrDefault(p => p.Code == processor);
                return pe.TresholdVoltage;
            }
        }
        public double GetPowerAttributeFor(string task)
        {
            using (var session = documentStore.OpenSession())
            {
                var mapping = session.Query<MappingGraph>().FirstOrDefault(m => m.Tasks.Contains(task));
                return
                    session.Query<ProcessorTaskAttribute>()
                           .Where(a => a.Processor == mapping.Procesor)
                           .FirstOrDefault(a => a.Task == task)
                           .DynamicPower;
            }
        }

        public int TotalTasks()
        {
            using (var session = documentStore.OpenSession())
            {
                return session.Query<AppTask>().Count();
            }
        }
        public int TotalProcessors()
        {
            using (var session = documentStore.OpenSession())
            {
                return session.Query<ProcessingElement>().Count();
            }
        }
        #endregion
    }
}
