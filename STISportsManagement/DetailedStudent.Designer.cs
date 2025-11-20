namespace STISportsManagement
{
    partial class DetailedStudent
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
            StudentView = new ListView();
            Continuebtn = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // StudentView
            // 
            StudentView.Location = new Point(133, 121);
            StudentView.Name = "StudentView";
            StudentView.Size = new Size(519, 178);
            StudentView.TabIndex = 0;
            StudentView.UseCompatibleStateImageBehavior = false;
            StudentView.SelectedIndexChanged += StudentView_SelectedIndexChanged;
            // 
            // Continuebtn
            // 
            Continuebtn.BackColor = SystemColors.Highlight;
            Continuebtn.ForeColor = SystemColors.ButtonHighlight;
            Continuebtn.Location = new Point(307, 329);
            Continuebtn.Name = "Continuebtn";
            Continuebtn.Size = new Size(152, 33);
            Continuebtn.TabIndex = 1;
            Continuebtn.Text = "Continue";
            Continuebtn.UseVisualStyleBackColor = false;
            Continuebtn.Click += Continuebtn_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 57);
            label1.Name = "label1";
            label1.Size = new Size(226, 38);
            label1.TabIndex = 2;
            label1.Text = "Student Details:";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(51, 31);
            button1.TabIndex = 9;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DetailedStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Continuebtn);
            Controls.Add(StudentView);
            Name = "DetailedStudent";
            Text = "DetailedStudent";
            Load += DetailedStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView StudentView;
        private Button Continuebtn;
        private Label label1;
        private Button button1;
    }
}