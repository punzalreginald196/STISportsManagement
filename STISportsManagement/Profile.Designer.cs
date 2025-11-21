namespace STISportsManagement
{
    partial class Profile
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
            ProfileView = new ListView();
            label1 = new Label();
            logoutbtn = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // ProfileView
            // 
            ProfileView.Location = new Point(214, 113);
            ProfileView.Name = "ProfileView";
            ProfileView.Size = new Size(385, 191);
            ProfileView.TabIndex = 0;
            ProfileView.UseCompatibleStateImageBehavior = false;
            ProfileView.SelectedIndexChanged += ProfileView_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(310, 26);
            label1.Name = "label1";
            label1.Size = new Size(172, 62);
            label1.TabIndex = 1;
            label1.Text = "Profile";
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = SystemColors.Highlight;
            logoutbtn.ForeColor = SystemColors.ButtonHighlight;
            logoutbtn.Location = new Point(379, 347);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(96, 29);
            logoutbtn.TabIndex = 2;
            logoutbtn.Text = "Logout";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(51, 31);
            button2.TabIndex = 17;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(logoutbtn);
            Controls.Add(label1);
            Controls.Add(ProfileView);
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ProfileView;
        private Label label1;
        private Button logoutbtn;
        private Button button2;
    }
}