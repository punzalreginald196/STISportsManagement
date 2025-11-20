using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STISportsManagement
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            LoadHistory();
        }

        private void LoadHistory()
        {
            string[] historyData = {
                "Basketball - 2 hours",
                "Gym Equipment - 1 day",
                "Volleyball - 3 hours"
            };

            foreach (var h in historyData)
            {
                HistoryView.Items.Add(new ListViewItem(h));
            }
        }

        private void HistoryView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}