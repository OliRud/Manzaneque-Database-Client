namespace ManzanequeDatabaseClient.Windows
{
    partial class ResolveTicket
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
            entTicketID = new NumericUpDown();
            label1 = new Label();
            entDateTime = new DateTimePicker();
            label2 = new Label();
            entResolveTime = new NumericUpDown();
            label3 = new Label();
            entResolution = new TextBox();
            label4 = new Label();
            btnSubmit = new Button();
            ((System.ComponentModel.ISupportInitialize)entTicketID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entResolveTime).BeginInit();
            SuspendLayout();
            // 
            // entTicketID
            // 
            entTicketID.Location = new Point(12, 32);
            entTicketID.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            entTicketID.Name = "entTicketID";
            entTicketID.Size = new Size(62, 23);
            entTicketID.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 7;
            label1.Text = "Enter ID of the ticket";
            // 
            // entDateTime
            // 
            entDateTime.Location = new Point(12, 95);
            entDateTime.Name = "entDateTime";
            entDateTime.Size = new Size(200, 23);
            entDateTime.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(224, 20);
            label2.TabIndex = 10;
            label2.Text = "Enter date and time of resoluton";
            // 
            // entResolveTime
            // 
            entResolveTime.Location = new Point(12, 164);
            entResolveTime.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            entResolveTime.Name = "entResolveTime";
            entResolveTime.Size = new Size(62, 23);
            entResolveTime.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 141);
            label3.Name = "label3";
            label3.Size = new Size(192, 20);
            label3.TabIndex = 11;
            label3.Text = "Enter hours taken to resolve";
            // 
            // entResolution
            // 
            entResolution.Location = new Point(12, 234);
            entResolution.Multiline = true;
            entResolution.Name = "entResolution";
            entResolution.Size = new Size(256, 204);
            entResolution.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 211);
            label4.Name = "label4";
            label4.Size = new Size(188, 20);
            label4.TabIndex = 14;
            label4.Text = "Resolution (200 characters)";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(67, 463);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(137, 50);
            btnSubmit.TabIndex = 15;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // ResolveTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 244, 234);
            ClientSize = new Size(280, 533);
            Controls.Add(btnSubmit);
            Controls.Add(label4);
            Controls.Add(entResolution);
            Controls.Add(entResolveTime);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(entDateTime);
            Controls.Add(entTicketID);
            Controls.Add(label1);
            Name = "ResolveTicket";
            Text = "Resolve Ticket";
            ((System.ComponentModel.ISupportInitialize)entTicketID).EndInit();
            ((System.ComponentModel.ISupportInitialize)entResolveTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown entTicketID;
        private Label label1;
        private DateTimePicker entDateTime;
        private Label label2;
        private NumericUpDown entResolveTime;
        private Label label3;
        private TextBox entResolution;
        private Label label4;
        private Button btnSubmit;
    }
}