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
    public partial class SportsEquipments : Form
    {
        public SportsEquipments()
        {
            InitializeComponent();
        }

        private void Basketballbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Basketball selected!");
        }

        private void Volleyballbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Volleyball selected!");
        }

        private void Arnisbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arnis selected!");
        }

        private void GymEquipmentsbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gym Equipment selected!");
        }

        private void Bandmintonbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Badminton selected!");
        }

        private void Propsbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Props selected!");
        }

        private void Bandmintonbtn_Click_1(object sender, EventArgs e)
        {

        }

        private void Volleyballbtn_Click_1(object sender, EventArgs e)
        {

        }

        private void Arnisbtn_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
