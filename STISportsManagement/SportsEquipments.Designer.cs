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
            SuspendLayout();
            // 
            // Basketballbtn
            // 
            Basketballbtn.Location = new Point(127, 114);
            Basketballbtn.Name = "Basketballbtn";
            Basketballbtn.Size = new Size(157, 66);
            Basketballbtn.TabIndex = 0;
            Basketballbtn.Text = "Basketball";
            Basketballbtn.UseVisualStyleBackColor = true;
            Basketballbtn.Click += Basketballbtn_Click;
            // 
            // Volleyballbtn
            // 
            Volleyballbtn.Location = new Point(351, 114);
            Volleyballbtn.Name = "Volleyballbtn";
            Volleyballbtn.Size = new Size(142, 61);
            Volleyballbtn.TabIndex = 1;
            Volleyballbtn.Text = "VolleyBall";
            Volleyballbtn.UseVisualStyleBackColor = true;
            // 
            // Bandmintonbtn
            // 
            Bandmintonbtn.Location = new Point(557, 109);
            Bandmintonbtn.Name = "Bandmintonbtn";
            Bandmintonbtn.Size = new Size(145, 66);
            Bandmintonbtn.TabIndex = 2;
            Bandmintonbtn.Text = "Badminton";
            Bandmintonbtn.UseVisualStyleBackColor = true;
            Bandmintonbtn.Click += Bandmintonbtn_Click_1;
            // 
            // Arnisbtn
            // 
            Arnisbtn.Location = new Point(140, 240);
            Arnisbtn.Name = "Arnisbtn";
            Arnisbtn.Size = new Size(144, 56);
            Arnisbtn.TabIndex = 3;
            Arnisbtn.Text = "Arnis";
            Arnisbtn.UseVisualStyleBackColor = true;
            // 
            // Propsbtn
            // 
            Propsbtn.Location = new Point(351, 240);
            Propsbtn.Name = "Propsbtn";
            Propsbtn.Size = new Size(142, 56);
            Propsbtn.TabIndex = 4;
            Propsbtn.Text = "Props";
            Propsbtn.UseVisualStyleBackColor = true;
            // 
            // GymEquipmentsbtn
            // 
            GymEquipmentsbtn.Location = new Point(557, 240);
            GymEquipmentsbtn.Name = "GymEquipmentsbtn";
            GymEquipmentsbtn.Size = new Size(145, 56);
            GymEquipmentsbtn.TabIndex = 5;
            GymEquipmentsbtn.Text = "GymEquipments";
            GymEquipmentsbtn.UseVisualStyleBackColor = true;
            // 
            // SportsEquipments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GymEquipmentsbtn);
            Controls.Add(Propsbtn);
            Controls.Add(Arnisbtn);
            Controls.Add(Bandmintonbtn);
            Controls.Add(Volleyballbtn);
            Controls.Add(Basketballbtn);
            Name = "SportsEquipments";
            Text = "SportsEquipments";
            ResumeLayout(false);
        }

        #endregion

        private Button Basketballbtn;
        private Button Volleyballbtn;
        private Button Bandmintonbtn;
        private Button Arnisbtn;
        private Button Propsbtn;
        private Button GymEquipmentsbtn;
    }
}