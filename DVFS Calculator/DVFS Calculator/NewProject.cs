using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Raven.Abstractions.Data;
using Raven.Client.Document;
using Raven.Client.Embedded;
using DVFS.Entities;
using Raven.Database.Server;
using DVFS.Core;
namespace DVFS_Calculator
{
    public partial class NewProject : Form
    {
        private int tid= 1;
        private int pid = 101;
        private int aid = 201;
        public AppTask task = new AppTask();
        public double DeadLine { 
            get
            {
                if (txtDeadline.Text != "")
                    return Convert.ToDouble(txtDeadline.Text);
                else
                    return 0.0;
            } 
        }
        public EmbeddableDocumentStore documentStore = new EmbeddableDocumentStore
        {
            DataDirectory = "Data",
            RunInMemory = false,
            UseEmbeddedHttpServer = true
        };
        public NewProject()
        {
            NonAdminHttp.EnsureCanListenToWhenInNonAdminContext(8080);
            System.Diagnostics.Process.Start("http://localhost:8080");
            InitializeComponent();
            documentStore.Initialize();
            documentStore.Conventions.MaxNumberOfRequestsPerSession = 720;
            documentStore.Conventions.DefaultQueryingConsistency=ConsistencyOptions.AlwaysWaitForNonStaleResultsAsOfLastWrite;
            PopulateProcessors();
            PopulateTable();
            PopulateValues();
            
        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            SaveValue();
            PopulateValues();
        }

        private void SaveValue()
        {
            task = new AppTask()
                {
                    ID = tid,
                    Code = txtTaskCode.Text,
                    ParentTask = cmbParentTask.SelectedItem == null ? "Root" : cmbParentTask.SelectedItem.ToString()
                };
            using (var session = documentStore.OpenSession())
            {
                session.Store(task, tid.ToString());
                session.SaveChanges();
            }
            tid++;
        }

        private void PopulateValues()
        {
            var tasks = new List<AppTask>();
            using (var session=documentStore.OpenSession())
            {
                cmbParentTask.Items.Clear();
                cmbTaskSelect.Items.Clear();
                lsTasks.Items.Clear();
                tasks = session.Advanced.LuceneQuery<AppTask>().WaitForNonStaleResults().ToList();
                var item = new ListViewItem();
                foreach (var appTask in tasks)
                {
                    cmbParentTask.Items.Add(appTask.Code);
                    cmbTaskSelect.Items.Add(appTask.Code);
                    item = new ListViewItem(appTask.ID.ToString());
                    item.Tag = appTask;
                    item.SubItems.Add(appTask.Code);
                    item.SubItems.Add(appTask.ParentTask);
                    lsTasks.Items.Add(item);
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (var session = documentStore.OpenSession())
            {
                var processor = cmbPeForMap.SelectedItem.ToString();
                var mapping = new MappingGraph();
                var tasks = new List<string>();
                foreach (var item in lsMappedTask.Items)
                {
                    var text = ((ListViewItem) item).Text;
                    tasks.Add(text);
                }
                mapping = new MappingGraph() {Procesor = processor, Tasks = tasks};
                session.Store(mapping);
                session.SaveChanges();
            }
        }

        private void lsExecutionTimeandPower_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lsTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSavePe_Click(object sender, EventArgs e)
        {
            var processor = new ProcessingElement()
            {
                ID = pid,
                Code = txtPeCode.Text,
                OperatingVoltage = Convert.ToDouble(txtPeSupply.Text),
                TresholdVoltage = Convert.ToDouble(txtPeTreshold.Text)
            };
            using (var session = documentStore.OpenSession())
            {
                session.Store(processor, pid.ToString());
                session.SaveChanges();
            }
                pid++;
            PopulateProcessors();
        }

        private void PopulateProcessors()
        {
            cmbProcessor.Items.Clear();
            var processors = new List<ProcessingElement>();
            using (var session=documentStore.OpenSession())
            {
                lsProcessingElements.Items.Clear();
                cmbPeForMap.Items.Clear();
                processors = session.Advanced.LuceneQuery<ProcessingElement>().WaitForNonStaleResults().ToList();
                var item = new ListViewItem();
                foreach (var processor in processors)
                {
                    cmbProcessor.Items.Add(processor.Code);
                    cmbPeForMap.Items.Add(processor.Code);
                    item = new ListViewItem(processor.Code);
                    item.Tag = processor;
                    item.SubItems.Add(processor.OperatingVoltage.ToString());
                    item.SubItems.Add(processor.TresholdVoltage.ToString());
                    lsProcessingElements.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var attribute = new ProcessorTaskAttribute()
            {
                ID = aid,
                Processor = cmbProcessor.SelectedItem.ToString(),
                Task = cmbTaskSelect.SelectedItem.ToString(),
                ExecutionTime = Convert.ToDouble(txtExecTime.Text),
                DynamicPower = Convert.ToDouble(txtDynamicP.Text)
            };
            using (var session = documentStore.OpenSession())
            {
                session.Store(attribute, aid.ToString());
                session.SaveChanges();
            }
            aid++;
            PopulateTable();
        }

        private void PopulateTable()
        {
            var attribute = new List<ProcessorTaskAttribute>();
            using (var session = documentStore.OpenSession())
            {
                lsDynamicTable.Items.Clear();
                attribute = session.Advanced.LuceneQuery<ProcessorTaskAttribute>().WaitForNonStaleResults().ToList();
                var item = new ListViewItem();
                foreach (var processor in attribute)
                {
                    item = new ListViewItem(processor.Task);
                    item.Tag = processor;
                    item.SubItems.Add(processor.Processor);
                    item.SubItems.Add(processor.ExecutionTime.ToString());
                    item.SubItems.Add(processor.DynamicPower.ToString());
                    lsDynamicTable.Items.Add(item);
                }
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            //if (cmbPeForMap.SelectedText != "")
            //{
                if (lsUnMappedTask.SelectedItems.Count > 0)
                {
                    var task = lsUnMappedTask.SelectedItems[0].Text;
                    var item = new ListViewItem(task);
                    lsMappedTask.Items.Add(item);
                    lsUnMappedTask.Items.RemoveAt(lsUnMappedTask.SelectedItems[0].Index);
                }
            //}
            //else
            //{
            //    MessageBox.Show("Please select the processor first.");
            //}
        }

        private void cmbPeForMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsUnMappedTask.Items.Clear();
            lsMappedTask.Items.Clear();
            ListViewItem item;
            using (var session = documentStore.OpenSession())
            {
                var mapping = session.Query<MappingGraph>();
                var mappedTasks = new List<string>();
                foreach (var mappingGraph in mapping)
                {
                    mappedTasks.AddRange(mappingGraph.Tasks);
                }
                var tasksAll = session.Query<AppTask>();
                var tasks = new List<AppTask>();
                foreach (var appTask in tasksAll)
                {
                    if(!mappedTasks.Contains(appTask.Code))
                        tasks.Add(appTask);
                }
                foreach (var appTask in tasks)
                {
                    item = new ListViewItem(appTask.Code);
                    item.Tag = appTask;
                    lsUnMappedTask.Items.Add(item);
                }
            }
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            if (txtDeadline.Text == "")
                MessageBox.Show("Execution deadline should be given");
            if (DialogResult.Yes ==
                MessageBox.Show(
                    "This will lock your parameter editor and start design. Are you sure you want to proceed?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                gbExecution.Enabled = false;
                gbMapping.Enabled = false;
                groupBox1.Enabled = false;
                groupBox3.Enabled = false;
                txtReport.Text = "Please wait while the system works in the background!";
                Thread thread = new Thread(RunDesign);
                thread.Start();
                Thread iteratThread=new Thread(RunIteration);
                iteratThread.Start();
            }
        }

        private void RunIteration()
        {
            var dvfs = new DvfsWithPowerProfile(documentStore, DeadLine);
            if (dvfs.InitializeIteration())
            {
                var result=dvfs.StartCalculation();
                IterationReport(result);
            }
        }

        private delegate void ListValuesCallBack(List<TaskLog> logs);
        private void IterationReport(List<TaskLog> logs)
        {
            if (this.lsIteration.InvokeRequired)
            {
                var d = new ListValuesCallBack(IterationReport);
                this.Invoke(d, new object[] {logs});
            }
            else
            {
                ListViewItem item;
                foreach (var taskLog in logs)
                {
                    item=new ListViewItem(taskLog.IterationNumber.ToString());
                    item.SubItems.Add(taskLog.Task);
                    item.SubItems.Add(taskLog.Processor);
                    item.SubItems.Add(taskLog.ExtendedTime.ToString("#.###"));
                    item.SubItems.Add(taskLog.NewVoltage.ToString("#.###"));
                    item.SubItems.Add(taskLog.NewPower.ToString("#.###"));
                    lsIteration.Items.Add(item);
                }
            }
            
        }
        private void RunDesign()
        {
            var builder = new StringBuilder();
            var calculator = new CalculatorFacade(documentStore);
            builder.Append("*** Design Report for DVFS calculations ***");
            builder.Append(Environment.NewLine);
            builder.Append("Preliminary statistics: ");
            builder.Append(Environment.NewLine);
            builder.Append("Total Tasks=" + calculator.TotalTasks().ToString() + " Processors=" +
                           calculator.TotalProcessors());
            builder.Append(Environment.NewLine);
            builder.Append("#1. Possible Schedule:");
            builder.Append(Environment.NewLine);
            var schedule = calculator.GenerateSchedule(0);
            foreach (var scheduleRow in schedule)
            {
                foreach (var tasks in scheduleRow.Tasks)
                {
                    builder.Append("Processor: " +tasks.Processor);
                    builder.Append(" Task: " + tasks.Task);
                    builder.Append(" Start Time: " + tasks.StartTime);
                    builder.Append(" End Time: " + tasks.EndTime);
                    builder.Append(" Power: " + tasks.DynamicPower);
                    builder.Append(Environment.NewLine);
                    
                }
            }

            builder.Append("#2. Average power=" + calculator.CalculateAveragePower() + " W");
            builder.Append(Environment.NewLine);
            builder.Append("Total Energy=" + calculator.CalculateTotalEnergy() + " mJ");
            builder.Append(Environment.NewLine);
            builder.Append("#3. Slack time=" + calculator.CalculateSlackTime(this.DeadLine, 0, calculator.EndTime) +
                           " ms");
            builder.Append(Environment.NewLine);
            double extentionFactor = calculator.CalculateExtensioFactor(this.DeadLine, 0, calculator.EndTime);
            builder.Append("Extension factor e=" +extentionFactor.ToString());
            builder.Append(Environment.NewLine);
            List<double> voltages = calculator.GetNewVoltageForAll(extentionFactor);
            string volts = "";
            foreach (var voltage in voltages)
            {
                volts = volts + " " + voltage.ToString() + " V ";
            }
            builder.Append("New Voltage Values=" + volts);
            builder.Append(Environment.NewLine);
            string wats = "";
            List<double> newpower = calculator.GetNewPowerForAll(extentionFactor);
            foreach (var pow in newpower)
            {
                wats = wats + " " + pow.ToString() + " W ";
            }
            builder.Append("New Power Values=" + wats);
            builder.Append(Environment.NewLine);
            this.SetReport(builder.ToString());

        }
        delegate void SetTextCallback(string text);
        private void SetReport(string str)
        {
            if (this.txtReport.InvokeRequired)
            {
                var d = new SetTextCallback(SetReport);
                this.Invoke(d, new object[] { str });
            }
            else
            {
                this.txtReport.Text = str;
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo))
            {
                using (var session = documentStore.OpenSession())
                {
                    session.Advanced.DocumentStore.DatabaseCommands.DeleteByIndex("Raven/DocumentsByEntityName",
                        new IndexQuery { Query = "Tag:TaskLogs" },
                        allowStale: true
                    );
                }
            }
        }

        private void cmdCalc_Click(object sender, EventArgs e)
        {
            new VPCalculator(this.documentStore).ShowDialog();
        }
    }
}
