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
    public partial class PatientDetails : Form
    {
        public PatientDetails()
        {
            InitializeComponent();
        }


        public string specialist, bday, reg_day, gender;







        //set variables to date pickers
        private void reg_picker_ValueChanged(object sender, EventArgs e)
        {
            reg_day = reg_picker.Value.ToString("MM/dd/yyyy");
        }
        private void birth_picker_ValueChanged(object sender, EventArgs e)
        {
            bday = birth_picker.Value.ToString("MM/dd/yyyy");
        }




        //set variables to dropdown inputs
        private void comboBoxSpecialist_SelectedIndexChanged(object sender, EventArgs e)
        {
            specialist = comboBoxSpecialist.SelectedItem.ToString();
        }

        
        //check validation of input fields when leaving






        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void PatientDetails_Load_1(object sender, EventArgs e)
        {

            Display();
            //add specialist dropdown values
            comboBoxSpecialist.Items.Clear();
            comboBoxSpecialist.Items.Add("Cardiologists");
            comboBoxSpecialist.Items.Add("Endocrinologists");
            comboBoxSpecialist.Items.Add("Nephrologists");
            comboBoxSpecialist.Items.Add("Urologists");
            comboBoxSpecialist.Items.Add("Pulmonologists");

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            var fname = txt_fname.Text;
            var lname = txt_lname.Text;
            var phone = txt_phone.Text;
            var weight = txt_weight.Text;
            var height = txt_height.Text;
            var bloodType = txt_Btype.Text;
            var address = txt_address.Text;
            var drName = txt_drName.Text;
            bday = birth_picker.Text;
            reg_day = reg_picker.Text;
            specialist = comboBoxSpecialist.Text;


            //find doctor ID
            string dId = DBconnection.findDoctor(specialist, drName);


            //get values from radio button
            if (radiobtn_male.Checked)
            {
                gender = radiobtn_male.Text;
            }
            else if (radiobtn_female.Checked)
            {
                gender = radiobtn_female.Text;
            }


            //validate user inputs
            if (string.IsNullOrEmpty(txt_fname.Text.Trim()))
            {
                txt_fname.Focus();
                errorProvider1.SetError(txt_fname, "First Name is Required");
            }
            else if (string.IsNullOrEmpty(txt_lname.Text.Trim()))
            {
                txt_lname.Focus();
                errorProvider.SetError(txt_lname, "Last Name is Require");
            }
            else if (gender == null)
            {
                errorProvider.SetError(radiobtn_female, "Please Select Gender");
            }
            else if (bday == null)
            {
                birth_picker.Focus();
                errorProvider.SetError(birth_picker, "Birth Date is required");
            }
            else if (string.IsNullOrEmpty(txt_phone.Text.Trim()))
            {
                txt_phone.Focus();
                errorProvider.SetError(txt_phone, "Phone Number is Required");
            }
            else if (specialist == null)
            {
                comboBoxSpecialist.Focus();
                errorProvider.SetError(comboBoxSpecialist, "Please Select the Specialist");
            }
            else if (reg_day == null)
            {
                reg_picker.Focus();
                errorProvider.SetError(reg_picker, "Please Select the register Date");
            }
            else if (string.IsNullOrEmpty(txt_address.Text.Trim()))
            {
                txt_address.Focus();
                errorProvider.SetError(txt_address, "Patient address is Required");
            }
            else if (string.IsNullOrEmpty(txt_drName.Text.Trim()))
            {
                txt_drName.Focus();
                errorProvider.SetError(txt_drName, "Doctor's nmae is Required");
            }

            else
            {
                //passing data into database connection

                PatientsRegistration patient = new PatientsRegistration(fname, lname, gender, bday, phone, weight, height, bloodType, address, reg_day, specialist, drName, dId);
                DBconnection.AddPatient(patient);
                DBconnection.AddPatientWaitingList(fname, lname);
                Clear();



            }


        }
        //rest button
        private void btn_reset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //back button
        private void btn_back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Patient_Reg_Load(object sender, EventArgs e)
        {
            Display();
            //add specialist dropdown values
            comboBoxSpecialist.Items.Clear();
            comboBoxSpecialist.Items.Add("Cardiologists");
            comboBoxSpecialist.Items.Add("Endocrinologists");
            comboBoxSpecialist.Items.Add("Nephrologists");
            comboBoxSpecialist.Items.Add("Urologists");
            comboBoxSpecialist.Items.Add("Pulmonologists");


        }

        //display avsilable doctors list
        public void Display()
        {
            DBconnection.DisplayUser("Select Id, First_Name, Last_name, Specialist FROM Users WHERE User_Type='Doctor' ", dataGridView2);
        }


        //clear usser previous inputs
        public void Clear()
        {
            txt_fname.Clear();
            txt_lname.Clear();
            txt_weight.Clear();
            txt_height.Clear();
            txt_address.Clear();
            txt_Btype.Clear();
            txt_phone.Clear();
            comboBoxSpecialist.ResetText();
            radiobtn_male.Checked = false;
            radiobtn_female.Checked = false;
            txt_drName.Clear();
            birth_picker.Text = string.Empty;
            reg_picker.Text = string.Empty;
            reg_day = null;
            bday = null;
            errorProvider.Clear();
            errorProvider1.Clear();
        }

    }




   

        
}

