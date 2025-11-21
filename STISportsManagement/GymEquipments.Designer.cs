namespace STISportsManagement
{
    partial class GymEquipments
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
            textBox1 = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(304, 242);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(323, 206);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 14;
            label5.Text = "16/20";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(305, 294);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 294);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 12;
            label4.Text = "Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 249);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 11;
            label3.Text = "Time:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 206);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 10;
            label2.Text = "Item Left:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 82);
            label1.Name = "label1";
            label1.Size = new Size(312, 54);
            label1.TabIndex = 9;
            label1.Text = "GymEquipments";
            // 
            // button1
            // 
            button1.Location = new Point(305, 361);
            button1.Name = "button1";
            button1.Size = new Size(130, 37);
            button1.TabIndex = 8;
            button1.Text = "Borrow";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(51, 31);
            button2.TabIndex = 16;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // GymEquipments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "GymEquipments";
            Text = "GymEquipments";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}