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
            SuspendLayout();
            // 
            // SportsEquipmentsbtn
            // 
            SportsEquipmentsbtn.Location = new Point(96, 164);
            SportsEquipmentsbtn.Name = "SportsEquipmentsbtn";
            SportsEquipmentsbtn.Size = new Size(160, 46);
            SportsEquipmentsbtn.TabIndex = 0;
            SportsEquipmentsbtn.Text = "SportsEquipments";
            SportsEquipmentsbtn.UseVisualStyleBackColor = true;
            SportsEquipmentsbtn.Click += SportsEquipmentsbtn_Click;
            // 
            // Historybtn
            // 
            Historybtn.Location = new Point(361, 161);
            Historybtn.Name = "Historybtn";
            Historybtn.Size = new Size(180, 52);
            Historybtn.TabIndex = 2;
            Historybtn.Text = "History";
            Historybtn.UseVisualStyleBackColor = true;
            Historybtn.Click += Historybtn_Click;
            // 
            // Profilebtn
            // 
            Profilebtn.Location = new Point(623, 155);
            Profilebtn.Name = "Profilebtn";
            Profilebtn.Size = new Size(188, 58);
            Profilebtn.TabIndex = 3;
            Profilebtn.Text = "Profile";
            Profilebtn.UseVisualStyleBackColor = true;
            Profilebtn.Click += Profilebtn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(Profilebtn);
            Controls.Add(Historybtn);
            Controls.Add(SportsEquipmentsbtn);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button SportsEquipmentsbtn;
        private Label label1;
        private Button Historybtn;
        private Button Profilebtn;
    }
}