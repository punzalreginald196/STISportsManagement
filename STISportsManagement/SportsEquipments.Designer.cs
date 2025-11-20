namespace STISportsManagement
{
    partial class SportsEquipments
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
            Basketballbtn = new Button();
            Volleyballbtn = new Button();
            Bandmintonbtn = new Button();
            Arnisbtn = new Button();
            Propsbtn = new Button();
            GymEquipmentsbtn = new Button();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Basketballbtn
            // 
            Basketballbtn.Location = new Point(127, 169);
            Basketballbtn.Name = "Basketballbtn";
            Basketballbtn.Size = new Size(157, 66);
            Basketballbtn.TabIndex = 0;
            Basketballbtn.Text = "Basketball";
            Basketballbtn.UseVisualStyleBackColor = true;
            Basketballbtn.Click += Basketballbtn_Click;
            // 
            // Volleyballbtn
            // 
            Volleyballbtn.Location = new Point(351, 169);
            Volleyballbtn.Name = "Volleyballbtn";
            Volleyballbtn.Size = new Size(142, 61);
            Volleyballbtn.TabIndex = 1;
            Volleyballbtn.Text = "VolleyBall";
            Volleyballbtn.UseVisualStyleBackColor = true;
            Volleyballbtn.Click += Volleyballbtn_Click_1;
            // 
            // Bandmintonbtn
            // 
            Bandmintonbtn.Location = new Point(557, 166);
            Bandmintonbtn.Name = "Bandmintonbtn";
            Bandmintonbtn.Size = new Size(145, 66);
            Bandmintonbtn.TabIndex = 2;
            Bandmintonbtn.Text = "Badminton";
            Bandmintonbtn.UseVisualStyleBackColor = true;
            Bandmintonbtn.Click += Bandmintonbtn_Click_1;
            // 
            // Arnisbtn
            // 
            Arnisbtn.Location = new Point(140, 286);
            Arnisbtn.Name = "Arnisbtn";
            Arnisbtn.Size = new Size(144, 56);
            Arnisbtn.TabIndex = 3;
            Arnisbtn.Text = "Arnis";
            Arnisbtn.UseVisualStyleBackColor = true;
            Arnisbtn.Click += Arnisbtn_Click_1;
            // 
            // Propsbtn
            // 
            Propsbtn.Location = new Point(351, 286);
            Propsbtn.Name = "Propsbtn";
            Propsbtn.Size = new Size(142, 56);
            Propsbtn.TabIndex = 4;
            Propsbtn.Text = "Props";
            Propsbtn.UseVisualStyleBackColor = true;
            // 
            // GymEquipmentsbtn
            // 
            GymEquipmentsbtn.Location = new Point(557, 286);
            GymEquipmentsbtn.Name = "GymEquipmentsbtn";
            GymEquipmentsbtn.Size = new Size(145, 56);
            GymEquipmentsbtn.TabIndex = 5;
            GymEquipmentsbtn.Text = "GymEquipments";
            GymEquipmentsbtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(351, 105);
            label3.Name = "label3";
            label3.Size = new Size(140, 28);
            label3.TabIndex = 6;
            label3.Text = "Ortigas-Cainta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(351, 24);
            label2.Name = "label2";
            label2.Size = new Size(123, 81);
            label2.TabIndex = 7;
            label2.Text = "STI";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(27, 24);
            button1.Name = "button1";
            button1.Size = new Size(51, 31);
            button1.TabIndex = 8;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SportsEquipments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(835, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(GymEquipmentsbtn);
            Controls.Add(Propsbtn);
            Controls.Add(Arnisbtn);
            Controls.Add(Bandmintonbtn);
            Controls.Add(Volleyballbtn);
            Controls.Add(Basketballbtn);
            Name = "SportsEquipments";
            Text = "SportsEquipments";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Basketballbtn;
        private Button Volleyballbtn;
        private Button Bandmintonbtn;
        private Button Arnisbtn;
        private Button Propsbtn;
        private Button GymEquipmentsbtn;
        private Label label3;
        private Label label2;
        private Button button1;
    }
}