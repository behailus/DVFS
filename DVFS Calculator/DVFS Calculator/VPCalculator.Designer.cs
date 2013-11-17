namespace DVFS_Calculator
{
    partial class VPCalculator
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
            this.cmdPowerC = new System.Windows.Forms.Button();
            this.cmdVoltage = new System.Windows.Forms.Button();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVoltageMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPowerd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewVolt = new System.Windows.Forms.TextBox();
            this.txtNewPower = new System.Windows.Forms.TextBox();
            this.txtTreshold = new System.Windows.Forms.TextBox();
            this.lblTr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdPowerC
            // 
            this.cmdPowerC.Location = new System.Drawing.Point(175, 226);
            this.cmdPowerC.Name = "cmdPowerC";
            this.cmdPowerC.Size = new System.Drawing.Size(119, 23);
            this.cmdPowerC.TabIndex = 0;
            this.cmdPowerC.Text = "Calculate Power";
            this.cmdPowerC.UseVisualStyleBackColor = true;
            this.cmdPowerC.Click += new System.EventHandler(this.cmdPowerC_Click);
            // 
            // cmdVoltage
            // 
            this.cmdVoltage.Location = new System.Drawing.Point(12, 226);
            this.cmdVoltage.Name = "cmdVoltage";
            this.cmdVoltage.Size = new System.Drawing.Size(101, 23);
            this.cmdVoltage.TabIndex = 1;
            this.cmdVoltage.Text = "Calculate Voltage";
            this.cmdVoltage.UseVisualStyleBackColor = true;
            this.cmdVoltage.Click += new System.EventHandler(this.cmdVoltage_Click);
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(114, 24);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(180, 20);
            this.txtExtension.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Extension Factor";
            // 
            // txtVoltageMax
            // 
            this.txtVoltageMax.Location = new System.Drawing.Point(114, 50);
            this.txtVoltageMax.Name = "txtVoltageMax";
            this.txtVoltageMax.Size = new System.Drawing.Size(180, 20);
            this.txtVoltageMax.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Voltage Max";
            // 
            // txtPowerd
            // 
            this.txtPowerd.Location = new System.Drawing.Point(114, 103);
            this.txtPowerd.Name = "txtPowerd";
            this.txtPowerd.Size = new System.Drawing.Size(180, 20);
            this.txtPowerd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dynamic Power";
            // 
            // txtNewVolt
            // 
            this.txtNewVolt.Location = new System.Drawing.Point(12, 165);
            this.txtNewVolt.Name = "txtNewVolt";
            this.txtNewVolt.Size = new System.Drawing.Size(144, 20);
            this.txtNewVolt.TabIndex = 2;
            // 
            // txtNewPower
            // 
            this.txtNewPower.Location = new System.Drawing.Point(160, 166);
            this.txtNewPower.Name = "txtNewPower";
            this.txtNewPower.Size = new System.Drawing.Size(144, 20);
            this.txtNewPower.TabIndex = 2;
            // 
            // txtTreshold
            // 
            this.txtTreshold.Location = new System.Drawing.Point(114, 77);
            this.txtTreshold.Name = "txtTreshold";
            this.txtTreshold.Size = new System.Drawing.Size(180, 20);
            this.txtTreshold.TabIndex = 2;
            // 
            // lblTr
            // 
            this.lblTr.AutoSize = true;
            this.lblTr.Location = new System.Drawing.Point(12, 80);
            this.lblTr.Name = "lblTr";
            this.lblTr.Size = new System.Drawing.Size(87, 13);
            this.lblTr.TabIndex = 3;
            this.lblTr.Text = "Treshold Voltage";
            // 
            // VPCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 261);
            this.Controls.Add(this.lblTr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewPower);
            this.Controls.Add(this.txtTreshold);
            this.Controls.Add(this.txtPowerd);
            this.Controls.Add(this.txtNewVolt);
            this.Controls.Add(this.txtVoltageMax);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.cmdVoltage);
            this.Controls.Add(this.cmdPowerC);
            this.Name = "VPCalculator";
            this.Text = "VPCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdPowerC;
        private System.Windows.Forms.Button cmdVoltage;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVoltageMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPowerd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewVolt;
        private System.Windows.Forms.TextBox txtNewPower;
        private System.Windows.Forms.TextBox txtTreshold;
        private System.Windows.Forms.Label lblTr;
    }
}