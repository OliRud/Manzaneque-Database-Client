namespace ManzanequeDatabaseClient.Windows
{
    partial class CustomQuery
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
            entQuery = new TextBox();
            btnSubmit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // entQuery
            // 
            entQuery.Location = new Point(12, 32);
            entQuery.Multiline = true;
            entQuery.Name = "entQuery";
            entQuery.Size = new Size(438, 359);
            entQuery.TabIndex = 0;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(162, 397);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(137, 41);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(163, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter your custom query here";
            // 
            // CustomQuery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 244, 234);
            ClientSize = new Size(464, 444);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Controls.Add(entQuery);
            Name = "CustomQuery";
            Text = "Custom Query";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox entQuery;
        private Button btnSubmit;
        private Label label1;
    }
}