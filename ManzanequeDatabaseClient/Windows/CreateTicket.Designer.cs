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
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
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
            label3.Size = new Size(287, 20);
            label3.TabIndex = 3;
            label3.Text = "Enter the Asset ID of the relevant software";
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 36);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(154, 23);
            numericUpDown1.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(12, 100);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(154, 23);
            numericUpDown2.TabIndex = 7;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(12, 164);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(154, 23);
            numericUpDown3.TabIndex = 8;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(13, 251);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(154, 23);
            numericUpDown4.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 315);
            textBox1.MaxLength = 200;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 165);
            textBox1.TabIndex = 10;
            // 
            // CreateTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 244, 234);
            ClientSize = new Size(475, 557);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Name = "CreateTicket";
            Text = "Create Ticket";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
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
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private TextBox textBox1;
    }
}