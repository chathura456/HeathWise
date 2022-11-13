using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class Doctor_Department : Form
    {
        public string id, name,specialist,phone;
        PatientPrescription form;
        public Doctor_Department()
        {
            InitializeComponent();
            form = new PatientPrescription(this);
        }


        //display patients details when loding from
        private void Doctor_Department_Load(object sender, EventArgs e)
        {
            id = DBconnection.id;
            name = DBconnection.name;
            phone = DBconnection.phoneNumber;
            specialist = DBconnection.specialist;
            lblid.Text = id;
            lblname.Text =  name;
            lblphoneNo.Text = phone;
            lblspecialist.Text = specialist;    
            DisplayPatientDetails(id);
            DisplayLabPatients(id);
        }

        //display patient queue
        public void DisplayPatientDetails(string id)
        {
            DBconnection.DisplayUser("SELECT * FROM patientswaiting WHERE DId='" + id + "' ", dataGridView1);
        }
        //display swtcing to lab queue
        public void DisplayLabPatients(string id)
        {
            DBconnection.DisplayUser("SELECT * FROM patientlab WHERE DId='" + id + "' ", dataGridView2);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            //fill the prescription of patients
            if (e.ColumnIndex == 2)
            {
                form.ssno = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.fname1 = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.lname1 = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.did1 = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                form.drname = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                form.setValues();
                form.ShowDialog();
                return;
            }
            //remove patients

            if (e.ColumnIndex == 3)
            {

                if (MessageBox.Show("Are You want to delete this record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBconnection.RemovePatient(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    DisplayPatientDetails(id);
                }
                return;
            }

            if (e.ColumnIndex == 0)
            {
                //switch patient to lab testing

                DBconnection.AddPatientTOLab(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                DBconnection.RemovePatient(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                DisplayPatientDetails(id);
                DisplayLabPatients(id);

                return;
            }
            if (e.ColumnIndex == 1)
            {
                //switch patient to lab testing

                DBconnection.showProfile(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
              ProfilePatient profilePatient = new ProfilePatient();
                profilePatient.Show();
             

                return;
            }


        }
        //log out button 
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form login_Form = new Login_Form();
            login_Form.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Doctor_Department_Load_1(object sender, EventArgs e)
        {
            id = DBconnection.id;
            name = DBconnection.name;
            phone = DBconnection.phoneNumber;
            specialist = DBconnection.specialist;
            lblid.Text = id;
            lblname.Text = name;
            lblphoneNo.Text = phone;
            lblspecialist.Text = specialist;
            DisplayPatientDetails(id);
            DisplayLabPatients(id);
        }

    




        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }





    }
}
