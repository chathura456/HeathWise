using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Hospital_Management_System
{
    public partial class PatientPrescription : Form
    {
        private readonly Doctor_Department _parent;
        public string ssno,fname1,lname1,did1,drname;
        public string date;

        public PatientPrescription(Doctor_Department parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //get the user inputs
            var age = txt_age.Text;
            var diagnosis = txt_diag.Text;
            var medicine = txt_med.Text;
            var other = txt_other.Text;
            Prescription prescription = new Prescription(ssno,fname1, lname1, date, age, diagnosis, medicine, other, did1, drname);
            DBconnection.AddPrescription(prescription);
            clear();
        }


        //reset the user inputs 
        private void btnReset_Click(object sender, EventArgs e)
        {

            clear();

        }

        private void PatientPrescription_Load(object sender, EventArgs e)
        {

        }

        private void btanClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //clear user inputs
        public void clear()
        {
            txt_age.Clear();
            txt_diag.Clear();
            txt_med.Clear();
            txt_other.Clear();
        }


        //set variables to date pickers
        private void date_picker_ValueChanged(object sender, EventArgs e)
        {
            date = date_picker.Value.ToString("MM/dd/yyyy");
        }
       




        //set  patient details for the prescription

        public void setValues()
        {
            txt_ssno.Text = ssno;
            txt_drid.Text = did1;
            txt_drname.Text = drname;
            txt_fname.Text = fname1;
            txt_lname.Text = lname1;
        }
       








        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
