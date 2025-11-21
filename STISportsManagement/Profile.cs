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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            LoadProfile();
        }

        private void LoadProfile()
        {
            string[] profileData = {
                "Name: " +
                "Reginald Punzal",
                "ID: 02000263574",
                "Course: BSIT"
            };

            foreach (var p in profileData)
            {
                ProfileView.Items.Add(new ListViewItem(p));
            }
        }

        private void ProfileView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }
    }
}
