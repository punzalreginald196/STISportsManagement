namespace STISportsManagement
{
    partial class TermsandConoditions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TermsandConoditions));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 100);
            label1.Name = "label1";
            label1.Size = new Size(937, 260);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(235, 26);
            label2.Name = "label2";
            label2.Size = new Size(407, 54);
            label2.TabIndex = 1;
            label2.Text = "Terms and Conditions";
            // 
            // button1
            // 
            button1.Location = new Point(387, 401);
            button1.Name = "button1";
            button1.Size = new Size(141, 29);
            button1.TabIndex = 2;
            button1.Text = "Accept";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(370, 371);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(174, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Terms and Conditions";
            checkBox1.UseVisualStyleBackColor = true;
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
            // 
            // TermsandConoditions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(963, 455);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TermsandConoditions";
            Text = "TermsandConoditions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private CheckBox checkBox1;
        private Button button2;
    }
}