namespace STISportsManagement
{
    partial class WelcomePage
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
            label2 = new Label();
            label3 = new Label();
            StudentLoginbtn = new Button();
            AdminLoginbtn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(344, 39);
            label2.Name = "label2";
            label2.Size = new Size(123, 81);
            label2.TabIndex = 4;
            label2.Text = "STI";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(344, 120);
            label3.Name = "label3";
            label3.Size = new Size(140, 28);
            label3.TabIndex = 5;
            label3.Text = "Ortigas-Cainta";
            label3.Click += label3_Click;
            // 
            // StudentLoginbtn
            // 
            StudentLoginbtn.BackColor = SystemColors.Highlight;
            StudentLoginbtn.ForeColor = SystemColors.ButtonHighlight;
            StudentLoginbtn.Location = new Point(327, 214);
            StudentLoginbtn.Name = "StudentLoginbtn";
            StudentLoginbtn.Size = new Size(162, 35);
            StudentLoginbtn.TabIndex = 6;
            StudentLoginbtn.Text = "Student Login";
            StudentLoginbtn.UseVisualStyleBackColor = false;
            StudentLoginbtn.Click += button1_Click;
            // 
            // AdminLoginbtn
            // 
            AdminLoginbtn.BackColor = SystemColors.Highlight;
            AdminLoginbtn.ForeColor = SystemColors.HighlightText;
            AdminLoginbtn.Location = new Point(327, 270);
            AdminLoginbtn.Name = "AdminLoginbtn";
            AdminLoginbtn.Size = new Size(162, 29);
            AdminLoginbtn.TabIndex = 7;
            AdminLoginbtn.Text = "Admin Login";
            AdminLoginbtn.UseVisualStyleBackColor = false;
            AdminLoginbtn.Click += AdminLoginbtn_Click;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 450);
            Controls.Add(AdminLoginbtn);
            Controls.Add(StudentLoginbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "WelcomePage";
            Text = "WelcomePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Button StudentLoginbtn;
        private Button AdminLoginbtn;
    }
}