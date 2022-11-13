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
    public partial class Biology_Department : Form
    {
        public Biology_Department()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Biology_Department_Load(object sender, EventArgs e)
        {
            textBox1.Text = DBconnection.id;
            textBox2.Text = DBconnection.name;
            textBox3.Text = DBconnection.phoneNumber;
            DBconnection.DisplayUser("SELECT * FROM patientlab", dataGridView1);
        }
    }
}
