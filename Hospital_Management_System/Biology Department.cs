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
            if (e.ColumnIndex == 0)
            {
                //Shoe patient profile

                DBconnection.showProfile(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                ProfilePatient profilePatient = new ProfilePatient();
                profilePatient.Show();


                return;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        //log out button
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
        }

        //display data in data gridview and user details
        private void Biology_Department_Load(object sender, EventArgs e)
        {
            textBox1.Text = DBconnection.id;
            textBox2.Text = DBconnection.name;
            textBox3.Text = DBconnection.phoneNumber;

            //display data in datagridView

            DBconnection.DisplayUser("SELECT * FROM patientlab", dataGridView1);
        }
    }
}
