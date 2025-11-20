namespace STISportsManagement
{
    partial class Form1
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
            StudentId = new TextBox();
            label1 = new Label();
            Enterbtn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // StudentId
            // 
            StudentId.Location = new Point(354, 233);
            StudentId.Multiline = true;
            StudentId.Name = "StudentId";
            StudentId.Size = new Size(247, 37);
            StudentId.TabIndex = 0;
            StudentId.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(417, 172);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            label1.Click += label1_Click;
            // 
            // Enterbtn
            // 
            Enterbtn.BackColor = SystemColors.Highlight;
            Enterbtn.ForeColor = SystemColors.ButtonHighlight;
            Enterbtn.Location = new Point(417, 294);
            Enterbtn.Name = "Enterbtn";
            Enterbtn.Size = new Size(117, 33);
            Enterbtn.TabIndex = 2;
            Enterbtn.Text = "Enter";
            Enterbtn.UseVisualStyleBackColor = false;
            Enterbtn.Click += Enterbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(417, 51);
            label2.Name = "label2";
            label2.Size = new Size(123, 81);
            label2.TabIndex = 3;
            label2.Text = "STI";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(400, 132);
            label3.Name = "label3";
            label3.Size = new Size(140, 28);
            label3.TabIndex = 4;
            label3.Text = "Ortigas-Cainta";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 210);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 5;
            label4.Text = "Student Number:";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(953, 412);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Enterbtn);
            Controls.Add(label1);
            Controls.Add(StudentId);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox StudentId;
        private Label label1;
        private Button Enterbtn;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
