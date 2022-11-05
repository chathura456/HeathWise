using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class SearchApointment : Form
    {
        public SearchApointment()
        {
            InitializeComponent();
        }












        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Pharmacist_Department_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //search appointment
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string name=txt_name.Text;
            DBconnection.DisplayUser("Select SSNo, First_Name, Last_name, Gender,Birth_Date,Phone_No,Appointed_Specialist,Appointed_Dr FROM patientsdetails WHERE First_Name='"+name+"' ", dataGridView1);
            txt_name.Clear();
        }

        //close and go to back
        private void btn_back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }
    }
}
