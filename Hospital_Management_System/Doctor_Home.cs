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
    public partial class Doctor_Home : Form
    {
        public string id,name;
        PatientPrescription form;
        public Doctor_Home()
        {
            InitializeComponent();
            form= new PatientPrescription(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //display patients details when loding from
        private void Doctor_Home_Load(object sender, EventArgs e)
        {
            id = DBconnection.id;
            name = DBconnection.name;
            lblid.Text = "Dr ID: " + id;
            lblname.Text = "Dr Name: "+name;
            DisplayPatientDetails(id);
            DisplayLabPatients(id);
        }
        //display patient queue
        public void DisplayPatientDetails(string id)
        {
            DBconnection.DisplayUser("SELECT * FROM patientswaiting WHERE DId='"+id+"' ", dataGridView1);
        }
        //display swtcing to lab queue
        public void DisplayLabPatients(string id)
        {
            DBconnection.DisplayUser("SELECT * FROM patientlab WHERE DId='" + id + "' ", dataGridView2);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //fill the prescription of patients
            if (e.ColumnIndex == 1)
            {
                form.ssno = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.fname1 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.lname1 = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.did1 = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                form.drname = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.setValues();
                form.ShowDialog();
                return;
            }
            //remove patients
           
                if (e.ColumnIndex == 2)
                {
               
                if (MessageBox.Show("Are You want to delete this user record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBconnection.RemovePatient(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    DisplayPatientDetails(id);
                }
                    return;
                }

            if (e.ColumnIndex == 0)
            {
                //switch patient to lab testing
                
                    DBconnection.AddPatientTOLab(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    DBconnection.RemovePatient(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    DisplayPatientDetails(id);
                    DisplayLabPatients(id);
                
                return;
            }



        }
    }
}
