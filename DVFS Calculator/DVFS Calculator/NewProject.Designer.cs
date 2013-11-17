namespace DVFS_Calculator
{
    partial class NewProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProject));
            this.btnSaveTask = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbParentTask = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeadline = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaskCode = new System.Windows.Forms.TextBox();
            this.lsTasks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ckPowerProfile = new System.Windows.Forms.CheckBox();
            this.gbExecution = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbPeForMap = new System.Windows.Forms.ComboBox();
            this.lsUnMappedTask = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdAdd = new System.Windows.Forms.Button();
            this.lsMappedTask = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSettings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTaskSelect = new System.Windows.Forms.ComboBox();
            this.gbMapping = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbProcessor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDynamicP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lsDynamicTable = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtExecTime = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSavePe = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPeTreshold = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPeSupply = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsProcessingElements = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPeCode = new System.Windows.Forms.TextBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQuanta = new System.Windows.Forms.TextBox();
            this.lsIteration = new System.Windows.Forms.ListView();
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtReport = new System.Windows.Forms.TextBox();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdCalc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbExecution.SuspendLayout();
            this.gbMapping.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveTask
            // 
            this.btnSaveTask.Location = new System.Drawing.Point(110, 68);
            this.btnSaveTask.Name = "btnSaveTask";
            this.btnSaveTask.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTask.TabIndex = 0;
            this.btnSaveTask.Text = "Save Task";
            this.btnSaveTask.UseVisualStyleBackColor = true;
            this.btnSaveTask.Click += new System.EventHandler(this.btnSaveTask_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbParentTask);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDeadline);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTaskCode);
            this.groupBox1.Controls.Add(this.lsTasks);
            this.groupBox1.Controls.Add(this.ckPowerProfile);
            this.groupBox1.Controls.Add(this.btnSaveTask);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 325);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task Graph";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Execution Deadline (ms)";
            // 
            // cmbParentTask
            // 
            this.cmbParentTask.FormattingEnabled = true;
            this.cmbParentTask.Location = new System.Drawing.Point(89, 41);
            this.cmbParentTask.Name = "cmbParentTask";
            this.cmbParentTask.Size = new System.Drawing.Size(107, 21);
            this.cmbParentTask.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Parent Task";
            // 
            // txtDeadline
            // 
            this.txtDeadline.Location = new System.Drawing.Point(142, 274);
            this.txtDeadline.Name = "txtDeadline";
            this.txtDeadline.Size = new System.Drawing.Size(107, 20);
            this.txtDeadline.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Task Code";
            // 
            // txtTaskCode
            // 
            this.txtTaskCode.Location = new System.Drawing.Point(89, 15);
            this.txtTaskCode.Name = "txtTaskCode";
            this.txtTaskCode.Size = new System.Drawing.Size(109, 20);
            this.txtTaskCode.TabIndex = 2;
            // 
            // lsTasks
            // 
            this.lsTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsTasks.FullRowSelect = true;
            this.lsTasks.GridLines = true;
            this.lsTasks.Location = new System.Drawing.Point(6, 104);
            this.lsTasks.Name = "lsTasks";
            this.lsTasks.Size = new System.Drawing.Size(243, 166);
            this.lsTasks.TabIndex = 1;
            this.lsTasks.UseCompatibleStateImageBehavior = false;
            this.lsTasks.View = System.Windows.Forms.View.Details;
            this.lsTasks.SelectedIndexChanged += new System.EventHandler(this.lsTasks_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 36;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Code";
            this.columnHeader2.Width = 92;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Parent Task";
            this.columnHeader3.Width = 107;
            // 
            // ckPowerProfile
            // 
            this.ckPowerProfile.AutoSize = true;
            this.ckPowerProfile.Checked = true;
            this.ckPowerProfile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckPowerProfile.Location = new System.Drawing.Point(29, 302);
            this.ckPowerProfile.Name = "ckPowerProfile";
            this.ckPowerProfile.Size = new System.Drawing.Size(181, 17);
            this.ckPowerProfile.TabIndex = 0;
            this.ckPowerProfile.Text = "Ignore power profile of each task";
            this.ckPowerProfile.UseVisualStyleBackColor = true;
            this.ckPowerProfile.Visible = false;
            // 
            // gbExecution
            // 
            this.gbExecution.Controls.Add(this.label11);
            this.gbExecution.Controls.Add(this.cmbPeForMap);
            this.gbExecution.Controls.Add(this.lsUnMappedTask);
            this.gbExecution.Controls.Add(this.cmdAdd);
            this.gbExecution.Controls.Add(this.lsMappedTask);
            this.gbExecution.Controls.Add(this.btnSettings);
            this.gbExecution.Location = new System.Drawing.Point(327, 314);
            this.gbExecution.Name = "gbExecution";
            this.gbExecution.Size = new System.Drawing.Size(309, 214);
            this.gbExecution.TabIndex = 2;
            this.gbExecution.TabStop = false;
            this.gbExecution.Text = "Initial Mapping";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Select a PE";
            // 
            // cmbPeForMap
            // 
            this.cmbPeForMap.FormattingEnabled = true;
            this.cmbPeForMap.Location = new System.Drawing.Point(80, 19);
            this.cmbPeForMap.Name = "cmbPeForMap";
            this.cmbPeForMap.Size = new System.Drawing.Size(101, 21);
            this.cmbPeForMap.TabIndex = 4;
            this.cmbPeForMap.SelectedIndexChanged += new System.EventHandler(this.cmbPeForMap_SelectedIndexChanged);
            // 
            // lsUnMappedTask
            // 
            this.lsUnMappedTask.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.lsUnMappedTask.FullRowSelect = true;
            this.lsUnMappedTask.GridLines = true;
            this.lsUnMappedTask.Location = new System.Drawing.Point(6, 48);
            this.lsUnMappedTask.MultiSelect = false;
            this.lsUnMappedTask.Name = "lsUnMappedTask";
            this.lsUnMappedTask.Size = new System.Drawing.Size(130, 154);
            this.lsUnMappedTask.TabIndex = 3;
            this.lsUnMappedTask.UseCompatibleStateImageBehavior = false;
            this.lsUnMappedTask.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Unmapped Tasks";
            this.columnHeader5.Width = 103;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(142, 90);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(39, 23);
            this.cmdAdd.TabIndex = 2;
            this.cmdAdd.Text = ">>";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // lsMappedTask
            // 
            this.lsMappedTask.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.lsMappedTask.FullRowSelect = true;
            this.lsMappedTask.GridLines = true;
            this.lsMappedTask.Location = new System.Drawing.Point(187, 19);
            this.lsMappedTask.Name = "lsMappedTask";
            this.lsMappedTask.Size = new System.Drawing.Size(113, 148);
            this.lsMappedTask.TabIndex = 1;
            this.lsMappedTask.UseCompatibleStateImageBehavior = false;
            this.lsMappedTask.View = System.Windows.Forms.View.Details;
            this.lsMappedTask.SelectedIndexChanged += new System.EventHandler(this.lsExecutionTimeandPower_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mapped Tasks";
            this.columnHeader4.Width = 103;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(197, 173);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Save Map";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select a task";
            // 
            // cmbTaskSelect
            // 
            this.cmbTaskSelect.FormattingEnabled = true;
            this.cmbTaskSelect.Location = new System.Drawing.Point(105, 22);
            this.cmbTaskSelect.Name = "cmbTaskSelect";
            this.cmbTaskSelect.Size = new System.Drawing.Size(161, 21);
            this.cmbTaskSelect.TabIndex = 0;
            // 
            // gbMapping
            // 
            this.gbMapping.Controls.Add(this.button1);
            this.gbMapping.Controls.Add(this.label8);
            this.gbMapping.Controls.Add(this.cmbProcessor);
            this.gbMapping.Controls.Add(this.label10);
            this.gbMapping.Controls.Add(this.label2);
            this.gbMapping.Controls.Add(this.txtDynamicP);
            this.gbMapping.Controls.Add(this.cmbTaskSelect);
            this.gbMapping.Controls.Add(this.label9);
            this.gbMapping.Controls.Add(this.lsDynamicTable);
            this.gbMapping.Controls.Add(this.txtExecTime);
            this.gbMapping.Location = new System.Drawing.Point(12, 343);
            this.gbMapping.Name = "gbMapping";
            this.gbMapping.Size = new System.Drawing.Size(309, 324);
            this.gbMapping.TabIndex = 3;
            this.gbMapping.TabStop = false;
            this.gbMapping.Text = "ExecutionTime and Power";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Select a PE";
            // 
            // cmbProcessor
            // 
            this.cmbProcessor.FormattingEnabled = true;
            this.cmbProcessor.Location = new System.Drawing.Point(105, 49);
            this.cmbProcessor.Name = "cmbProcessor";
            this.cmbProcessor.Size = new System.Drawing.Size(161, 21);
            this.cmbProcessor.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Dynamic Power (W)";
            // 
            // txtDynamicP
            // 
            this.txtDynamicP.Location = new System.Drawing.Point(133, 98);
            this.txtDynamicP.Name = "txtDynamicP";
            this.txtDynamicP.Size = new System.Drawing.Size(133, 20);
            this.txtDynamicP.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Execution Time (ms)";
            // 
            // lsDynamicTable
            // 
            this.lsDynamicTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lsDynamicTable.FullRowSelect = true;
            this.lsDynamicTable.GridLines = true;
            this.lsDynamicTable.Location = new System.Drawing.Point(6, 152);
            this.lsDynamicTable.Name = "lsDynamicTable";
            this.lsDynamicTable.Size = new System.Drawing.Size(296, 166);
            this.lsDynamicTable.TabIndex = 1;
            this.lsDynamicTable.UseCompatibleStateImageBehavior = false;
            this.lsDynamicTable.View = System.Windows.Forms.View.Details;
            this.lsDynamicTable.SelectedIndexChanged += new System.EventHandler(this.lsTasks_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Task";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Processor";
            this.columnHeader11.Width = 67;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Exec.Time";
            this.columnHeader12.Width = 79;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Power";
            this.columnHeader13.Width = 72;
            // 
            // txtExecTime
            // 
            this.txtExecTime.Location = new System.Drawing.Point(133, 72);
            this.txtExecTime.Name = "txtExecTime";
            this.txtExecTime.Size = new System.Drawing.Size(133, 20);
            this.txtExecTime.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSavePe);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtPeTreshold);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtPeSupply);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lsProcessingElements);
            this.groupBox3.Controls.Add(this.txtPeCode);
            this.groupBox3.Location = new System.Drawing.Point(323, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 279);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Processing Elements";
            // 
            // btnSavePe
            // 
            this.btnSavePe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSavePe.Location = new System.Drawing.Point(220, 67);
            this.btnSavePe.Name = "btnSavePe";
            this.btnSavePe.Size = new System.Drawing.Size(64, 26);
            this.btnSavePe.TabIndex = 10;
            this.btnSavePe.Text = "Save";
            this.btnSavePe.UseVisualStyleBackColor = true;
            this.btnSavePe.Click += new System.EventHandler(this.btnSavePe_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Treshold Voltage (V)";
            // 
            // txtPeTreshold
            // 
            this.txtPeTreshold.Location = new System.Drawing.Point(108, 71);
            this.txtPeTreshold.Name = "txtPeTreshold";
            this.txtPeTreshold.Size = new System.Drawing.Size(109, 20);
            this.txtPeTreshold.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Supply Voltage (V)";
            // 
            // txtPeSupply
            // 
            this.txtPeSupply.Location = new System.Drawing.Point(108, 45);
            this.txtPeSupply.Name = "txtPeSupply";
            this.txtPeSupply.Size = new System.Drawing.Size(109, 20);
            this.txtPeSupply.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Code";
            // 
            // lsProcessingElements
            // 
            this.lsProcessingElements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lsProcessingElements.FullRowSelect = true;
            this.lsProcessingElements.GridLines = true;
            this.lsProcessingElements.Location = new System.Drawing.Point(6, 107);
            this.lsProcessingElements.Name = "lsProcessingElements";
            this.lsProcessingElements.Size = new System.Drawing.Size(278, 166);
            this.lsProcessingElements.TabIndex = 1;
            this.lsProcessingElements.UseCompatibleStateImageBehavior = false;
            this.lsProcessingElements.View = System.Windows.Forms.View.Details;
            this.lsProcessingElements.SelectedIndexChanged += new System.EventHandler(this.lsTasks_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "PE Code";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Supply V-Vdd";
            this.columnHeader8.Width = 92;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Treshold V-Vt";
            this.columnHeader9.Width = 107;
            // 
            // txtPeCode
            // 
            this.txtPeCode.Location = new System.Drawing.Point(108, 19);
            this.txtPeCode.Name = "txtPeCode";
            this.txtPeCode.Size = new System.Drawing.Size(109, 20);
            this.txtPeCode.TabIndex = 4;
            // 
            // cmdStart
            // 
            this.cmdStart.Image = ((System.Drawing.Image)(resources.GetObject("cmdStart.Image")));
            this.cmdStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdStart.Location = new System.Drawing.Point(393, 560);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(129, 37);
            this.cmdStart.TabIndex = 5;
            this.cmdStart.Text = "Start Design";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cmdCalc);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtQuanta);
            this.groupBox2.Controls.Add(this.lsIteration);
            this.groupBox2.Controls.Add(this.txtReport);
            this.groupBox2.Location = new System.Drawing.Point(642, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 639);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Process and Iteration";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(68, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Quanta Size";
            // 
            // txtQuanta
            // 
            this.txtQuanta.Location = new System.Drawing.Point(134, 13);
            this.txtQuanta.Name = "txtQuanta";
            this.txtQuanta.Size = new System.Drawing.Size(78, 20);
            this.txtQuanta.TabIndex = 2;
            // 
            // lsIteration
            // 
            this.lsIteration.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader18,
            this.columnHeader6,
            this.columnHeader17,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.lsIteration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsIteration.FullRowSelect = true;
            this.lsIteration.Location = new System.Drawing.Point(3, 436);
            this.lsIteration.Name = "lsIteration";
            this.lsIteration.Size = new System.Drawing.Size(533, 200);
            this.lsIteration.TabIndex = 1;
            this.lsIteration.UseCompatibleStateImageBehavior = false;
            this.lsIteration.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Iteration";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Task";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Processor";
            this.columnHeader17.Width = 72;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Extended Time";
            this.columnHeader14.Width = 137;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "New Voltage";
            this.columnHeader15.Width = 139;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "New Power";
            this.columnHeader16.Width = 116;
            // 
            // txtReport
            // 
            this.txtReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReport.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReport.Location = new System.Drawing.Point(3, 39);
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReport.Size = new System.Drawing.Size(533, 391);
            this.txtReport.TabIndex = 0;
            // 
            // cmdClear
            // 
            this.cmdClear.Enabled = false;
            this.cmdClear.Location = new System.Drawing.Point(528, 560);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(86, 37);
            this.cmdClear.TabIndex = 7;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdCalc
            // 
            this.cmdCalc.Location = new System.Drawing.Point(219, 11);
            this.cmdCalc.Name = "cmdCalc";
            this.cmdCalc.Size = new System.Drawing.Size(75, 23);
            this.cmdCalc.TabIndex = 4;
            this.cmdCalc.Text = "Calculator";
            this.cmdCalc.UseVisualStyleBackColor = true;
            this.cmdCalc.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 682);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbMapping);
            this.Controls.Add(this.gbExecution);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewProject";
            this.Text = "New Project";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbExecution.ResumeLayout(false);
            this.gbExecution.PerformLayout();
            this.gbMapping.ResumeLayout(false);
            this.gbMapping.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveTask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckPowerProfile;
        private System.Windows.Forms.GroupBox gbExecution;
        private System.Windows.Forms.GroupBox gbMapping;
        private System.Windows.Forms.ComboBox cmbParentTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaskCode;
        private System.Windows.Forms.ListView lsTasks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ComboBox cmbTaskSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDeadline;
        private System.Windows.Forms.ListView lsMappedTask;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSavePe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPeTreshold;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPeSupply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsProcessingElements;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox txtPeCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbProcessor;
        private System.Windows.Forms.ListView lsDynamicTable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDynamicP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtExecTime;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbPeForMap;
        private System.Windows.Forms.ListView lsUnMappedTask;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtReport;
        private System.Windows.Forms.ListView lsIteration;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQuanta;
        private System.Windows.Forms.Button cmdCalc;
    }
}