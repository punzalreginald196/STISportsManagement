namespace STISportsManagement
{
    partial class Home
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
            SportsEquipmentsbtn = new Button();
            Historybtn = new Button();
            Profilebtn = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // SportsEquipmentsbtn
            // 
            SportsEquipmentsbtn.BackColor = SystemColors.Highlight;
            SportsEquipmentsbtn.ForeColor = SystemColors.ButtonHighlight;
            SportsEquipmentsbtn.Location = new Point(96, 229);
            SportsEquipmentsbtn.Name = "SportsEquipmentsbtn";
            SportsEquipmentsbtn.Size = new Size(160, 46);
            SportsEquipmentsbtn.TabIndex = 0;
            SportsEquipmentsbtn.Text = "SportsEquipments";
            SportsEquipmentsbtn.UseVisualStyleBackColor = false;
            SportsEquipmentsbtn.Click += SportsEquipmentsbtn_Click;
            // 
            // Historybtn
            // 
            Historybtn.BackColor = SystemColors.Highlight;
            Historybtn.ForeColor = SystemColors.ButtonHighlight;
            Historybtn.Location = new Point(357, 226);
            Historybtn.Name = "Historybtn";
            Historybtn.Size = new Size(180, 52);
            Historybtn.TabIndex = 2;
            Historybtn.Text = "History";
            Historybtn.UseVisualStyleBackColor = false;
            Historybtn.Click += Historybtn_Click;
            // 
            // Profilebtn
            // 
            Profilebtn.BackColor = SystemColors.Highlight;
            Profilebtn.ForeColor = SystemColors.ButtonHighlight;
            Profilebtn.Location = new Point(615, 226);
            Profilebtn.Name = "Profilebtn";
            Profilebtn.Size = new Size(188, 52);
            Profilebtn.TabIndex = 3;
            Profilebtn.Text = "Profile";
            Profilebtn.UseVisualStyleBackColor = false;
            Profilebtn.Click += Profilebtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(390, 46);
            label2.Name = "label2";
            label2.Size = new Size(123, 81);
            label2.TabIndex = 5;
            label2.Text = "STI";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(390, 127);
            label3.Name = "label3";
            label3.Size = new Size(140, 28);
            label3.TabIndex = 6;
            label3.Text = "Ortigas-Cainta";
            label3.Click += label3_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(900, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Profilebtn);
            Controls.Add(Historybtn);
            Controls.Add(SportsEquipmentsbtn);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SportsEquipmentsbtn;
        private Label label1;
        private Button Historybtn;
        private Button Profilebtn;
        private Label label2;
        private Label label3;
    }
}