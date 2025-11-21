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



        private void Volleyballbtn_Click(object sender, EventArgs e)
        {

        }

        private void Arnisbtn_Click(object sender, EventArgs e)
        {

        }

        private void GymEquipmentsbtn_Click(object sender, EventArgs e)
        {

        }
        private void Bandmintonbtn_Click_1(object sender, EventArgs e)
        {
            Bandminton bandminton = new Bandminton();
            bandminton.Show();
            this.Hide();
        }

        private void Volleyballbtn_Click_1(object sender, EventArgs e)
        {
            Volleyball volleyball = new Volleyball();
            volleyball.Show();
            this.Hide();
        }

        private void Arnisbtn_Click_1(object sender, EventArgs e)
        {
            Arnis arnis = new Arnis();
            arnis.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void GymEquipmentsbtn_Click_1(object sender, EventArgs e)
        {
            GymEquipments gymEquipments = new GymEquipments();
            gymEquipments.Show();
            this.Hide();
        }

        private void Propsbtn_Click(object sender, EventArgs e)
        {
            Props props = new Props();
            props.Show();
            this.Hide();
        }

        private void Basketballbtn_Click(object sender, EventArgs e)
        {
            Basketball basketball = new Basketball();
            basketball.Show();
            this.Hide();


        }
    }
}
