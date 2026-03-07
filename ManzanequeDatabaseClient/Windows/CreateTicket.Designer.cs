namespace ManzanequeDatabaseClient.Windows
{
    partial class CreateTicket
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
            btnSubmit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            entEmployeeID = new NumericUpDown();
            entSerialNumber = new NumericUpDown();
            entAssetID = new NumericUpDown();
            entTechnicianID = new NumericUpDown();
            entNote = new TextBox();
            ((System.ComponentModel.ISupportInitialize)entEmployeeID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entSerialNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entAssetID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entTechnicianID).BeginInit();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(148, 495);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(137, 50);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(206, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter the caller's employee ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(328, 20);
            label2.TabIndex = 2;
            label2.Text = "Enter the serial number of the relevant hardware";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 141);
            label3.Name = "label3";
            label3.Size = new Size(303, 20);
            label3.TabIndex = 3;
            label3.Text = "Enter the Asset ID of the concerned software";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 208);
            label4.Name = "label4";
            label4.Size = new Size(416, 40);
            label4.TabIndex = 4;
            label4.Text = "Enter a technician's ID who is specialised to resolve this issue, \r\nrefer to the table viewer to learn more";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 292);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 5;
            label5.Text = "Note (200 Characters)";
            // 
            // entEmployeeID
            // 
            entEmployeeID.Location = new Point(12, 36);
            entEmployeeID.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            entEmployeeID.Name = "entEmployeeID";
            entEmployeeID.Size = new Size(154, 23);
            entEmployeeID.TabIndex = 6;
            // 
            // entSerialNumber
            // 
            entSerialNumber.Location = new Point(12, 100);
            entSerialNumber.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            entSerialNumber.Name = "entSerialNumber";
            entSerialNumber.Size = new Size(154, 23);
            entSerialNumber.TabIndex = 7;
            // 
            // entAssetID
            // 
            entAssetID.Location = new Point(12, 164);
            entAssetID.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            entAssetID.Name = "entAssetID";
            entAssetID.Size = new Size(154, 23);
            entAssetID.TabIndex = 8;
            // 
            // entTechnicianID
            // 
            entTechnicianID.Location = new Point(13, 251);
            entTechnicianID.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            entTechnicianID.Name = "entTechnicianID";
            entTechnicianID.Size = new Size(154, 23);
            entTechnicianID.TabIndex = 9;
            // 
            // entNote
            // 
            entNote.Location = new Point(13, 315);
            entNote.MaxLength = 200;
            entNote.Multiline = true;
            entNote.Name = "entNote";
            entNote.Size = new Size(400, 165);
            entNote.TabIndex = 10;
            // 
            // CreateTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 244, 234);
            ClientSize = new Size(475, 557);
            Controls.Add(entNote);
            Controls.Add(entTechnicianID);
            Controls.Add(entAssetID);
            Controls.Add(entSerialNumber);
            Controls.Add(entEmployeeID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Name = "CreateTicket";
            Text = "Create Ticket";
            ((System.ComponentModel.ISupportInitialize)entEmployeeID).EndInit();
            ((System.ComponentModel.ISupportInitialize)entSerialNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)entAssetID).EndInit();
            ((System.ComponentModel.ISupportInitialize)entTechnicianID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown entEmployeeID;
        private NumericUpDown entSerialNumber;
        private NumericUpDown entAssetID;
        private NumericUpDown entTechnicianID;
        private TextBox entNote;
    }
}