namespace STISportsManagement
{
    partial class History
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
            HistoryView = new ListView();
            label1 = new Label();
            SuspendLayout();
            // 
            // HistoryView
            // 
            HistoryView.Location = new Point(169, 162);
            HistoryView.Name = "HistoryView";
            HistoryView.Size = new Size(446, 195);
            HistoryView.TabIndex = 0;
            HistoryView.UseCompatibleStateImageBehavior = false;
            HistoryView.SelectedIndexChanged += HistoryView_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 41);
            label1.Name = "label1";
            label1.Size = new Size(190, 62);
            label1.TabIndex = 1;
            label1.Text = "History";
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(HistoryView);
            Name = "History";
            Text = "History";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView HistoryView;
        private Label label1;
    }
}