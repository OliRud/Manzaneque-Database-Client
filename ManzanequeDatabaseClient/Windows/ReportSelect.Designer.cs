namespace ManzanequeDatabaseClient.Windows
{
    partial class ReportSelect
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
            label5 = new Label();
            btnMonthlyCallSummary = new Button();
            btnMonthlyTechnicianJobs = new Button();
            btnOfficeWorkload = new Button();
            btnEquipmentReliability = new Button();
            btn1Submit = new Button();
            entTechnicianID = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            entOfficeID = new NumericUpDown();
            btn2Submit = new Button();
            label9 = new Label();
            label3 = new Label();
            entYear = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            entMonth = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)entTechnicianID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entOfficeID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entMonth).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 279);
            label5.Name = "label5";
            label5.Size = new Size(156, 15);
            label5.TabIndex = 4;
            label5.Text = "Individual Technician Report";
            // 
            // btnMonthlyCallSummary
            // 
            btnMonthlyCallSummary.Location = new Point(12, 115);
            btnMonthlyCallSummary.Name = "btnMonthlyCallSummary";
            btnMonthlyCallSummary.Size = new Size(229, 71);
            btnMonthlyCallSummary.TabIndex = 6;
            btnMonthlyCallSummary.Text = "Month Call Summary";
            btnMonthlyCallSummary.UseVisualStyleBackColor = true;
            btnMonthlyCallSummary.Click += btnMonthlyCallSummary_Click;
            // 
            // btnMonthlyTechnicianJobs
            // 
            btnMonthlyTechnicianJobs.Location = new Point(12, 192);
            btnMonthlyTechnicianJobs.Name = "btnMonthlyTechnicianJobs";
            btnMonthlyTechnicianJobs.Size = new Size(229, 71);
            btnMonthlyTechnicianJobs.TabIndex = 7;
            btnMonthlyTechnicianJobs.Text = "Month Technician Jobs";
            btnMonthlyTechnicianJobs.UseVisualStyleBackColor = true;
            btnMonthlyTechnicianJobs.Click += btnMonthlyTechnicianJobs_Click;
            // 
            // btnOfficeWorkload
            // 
            btnOfficeWorkload.Location = new Point(12, 424);
            btnOfficeWorkload.Name = "btnOfficeWorkload";
            btnOfficeWorkload.Size = new Size(229, 71);
            btnOfficeWorkload.TabIndex = 8;
            btnOfficeWorkload.Text = "Office Workload Report";
            btnOfficeWorkload.UseVisualStyleBackColor = true;
            btnOfficeWorkload.Click += btnOfficeWorkload_Click;
            // 
            // btnEquipmentReliability
            // 
            btnEquipmentReliability.Location = new Point(12, 501);
            btnEquipmentReliability.Name = "btnEquipmentReliability";
            btnEquipmentReliability.Size = new Size(229, 71);
            btnEquipmentReliability.TabIndex = 9;
            btnEquipmentReliability.Text = "Equipment Reliability Report";
            btnEquipmentReliability.UseVisualStyleBackColor = true;
            btnEquipmentReliability.Click += btnEquipmentReliability_Click;
            // 
            // btn1Submit
            // 
            btn1Submit.Location = new Point(165, 297);
            btn1Submit.Name = "btn1Submit";
            btn1Submit.Size = new Size(76, 41);
            btn1Submit.TabIndex = 10;
            btn1Submit.Text = "Submit";
            btn1Submit.UseVisualStyleBackColor = true;
            btn1Submit.Click += btn1Submit_Click;
            // 
            // entTechnicianID
            // 
            entTechnicianID.Location = new Point(39, 308);
            entTechnicianID.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            entTechnicianID.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            entTechnicianID.Name = "entTechnicianID";
            entTechnicianID.Size = new Size(120, 23);
            entTechnicianID.TabIndex = 11;
            entTechnicianID.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 310);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 12;
            label7.Text = "ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 380);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 16;
            label8.Text = "ID";
            // 
            // entOfficeID
            // 
            entOfficeID.Location = new Point(39, 378);
            entOfficeID.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            entOfficeID.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            entOfficeID.Name = "entOfficeID";
            entOfficeID.Size = new Size(120, 23);
            entOfficeID.TabIndex = 15;
            entOfficeID.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btn2Submit
            // 
            btn2Submit.Location = new Point(165, 367);
            btn2Submit.Name = "btn2Submit";
            btn2Submit.Size = new Size(76, 41);
            btn2Submit.TabIndex = 14;
            btn2Submit.Text = "Submit";
            btn2Submit.UseVisualStyleBackColor = true;
            btn2Submit.Click += btn2Submit_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 349);
            label9.Name = "label9";
            label9.Size = new Size(115, 15);
            label9.TabIndex = 13;
            label9.Text = "Office Failure Report";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(194, 232, 206);
            label3.Location = new Point(-174, 85);
            label3.Name = "label3";
            label3.Size = new Size(527, 13);
            label3.TabIndex = 21;
            label3.Text = "                                                                                                                                  ";
            // 
            // entYear
            // 
            entYear.Location = new Point(124, 62);
            entYear.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            entYear.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            entYear.Name = "entYear";
            entYear.Size = new Size(117, 23);
            entYear.TabIndex = 29;
            entYear.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 28;
            label2.Text = "Select Year";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(86, 30);
            label1.TabIndex = 27;
            label1.Text = "Select Month \r\n(1-12, Jan-Dec)";
            // 
            // entMonth
            // 
            entMonth.Location = new Point(124, 22);
            entMonth.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            entMonth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            entMonth.Name = "entMonth";
            entMonth.Size = new Size(117, 23);
            entMonth.TabIndex = 26;
            entMonth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ReportSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 244, 234);
            ClientSize = new Size(253, 587);
            Controls.Add(entYear);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(entMonth);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(entOfficeID);
            Controls.Add(btn2Submit);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(entTechnicianID);
            Controls.Add(btn1Submit);
            Controls.Add(btnEquipmentReliability);
            Controls.Add(btnOfficeWorkload);
            Controls.Add(btnMonthlyTechnicianJobs);
            Controls.Add(btnMonthlyCallSummary);
            Controls.Add(label5);
            Name = "ReportSelect";
            Text = "Select A Report";
            ((System.ComponentModel.ISupportInitialize)entTechnicianID).EndInit();
            ((System.ComponentModel.ISupportInitialize)entOfficeID).EndInit();
            ((System.ComponentModel.ISupportInitialize)entYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)entMonth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Button btnMonthlyCallSummary;
        private Button btnMonthlyTechnicianJobs;
        private Button btnOfficeWorkload;
        private Button btnEquipmentReliability;
        private Button btn1Submit;
        private NumericUpDown entTechnicianID;
        private Label label7;
        private Label label8;
        private NumericUpDown entOfficeID;
        private Button btn2Submit;
        private Label label9;
        private Label label3;
        private NumericUpDown entYear;
        private Label label2;
        private Label label1;
        private NumericUpDown entMonth;
    }
}