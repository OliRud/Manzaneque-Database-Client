namespace ManzanequeDatabaseClient
{
    partial class initLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            entLoginBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(197, 199);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // entLoginBox
            // 
            entLoginBox.Location = new Point(131, 170);
            entLoginBox.Name = "entLoginBox";
            entLoginBox.Size = new Size(204, 23);
            entLoginBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Green;
            label1.Location = new Point(153, 259);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 2;
            label1.Text = "Helpdesk Account = Helpdesk1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 0);
            label2.Location = new Point(207, 235);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Accounts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Green;
            label3.Location = new Point(158, 275);
            label3.Name = "label3";
            label3.Size = new Size(166, 15);
            label3.TabIndex = 4;
            label3.Text = "Manager Account = Manager ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Green;
            label5.Location = new Point(168, 290);
            label5.Name = "label5";
            label5.Size = new Size(141, 15);
            label5.TabIndex = 6;
            label5.Text = "Admin Account = Admin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.OliveDrab;
            label4.Location = new Point(106, 31);
            label4.Name = "label4";
            label4.Size = new Size(259, 57);
            label4.TabIndex = 7;
            label4.Text = "Manzaneque";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Script", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Olive;
            label6.Location = new Point(168, 88);
            label6.Name = "label6";
            label6.Size = new Size(140, 25);
            label6.TabIndex = 8;
            label6.Text = "Database Client";
            // 
            // initLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 244, 234);
            ClientSize = new Size(470, 327);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(entLoginBox);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "initLogin";
            Text = "Login";
            FormClosing += initLogin_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox entLoginBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
    }
}