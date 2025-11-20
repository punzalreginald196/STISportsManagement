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

    public partial class DetailedStudent : Form
    {
        private string studentId;

        public DetailedStudent(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            LoadStudentDetails();
        }

        private void LoadStudentDetails()
        {
        
            string[] studentDetails = { "Name: Reginald T. Punzal", "ID: " + studentId, "Course: BSIT" };

            foreach (string detail in studentDetails)
            {
                ListViewItem item = new ListViewItem(detail);
                StudentView.Items.Add(item);
            }
        }


        private void Continuebtn_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void DetailedStudent_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StudentView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}