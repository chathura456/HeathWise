using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Login_Form : Form
    {
        public string emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        public string id1, fname1, lname1, gender1, birth1, phone1, special1, reg_date1, email1, password1, type1;

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_pass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_pass.Text.Trim()))
            {
                txt_pass.Focus();
                errorProvider1.SetError(txt_pass, "Password Cannot be null");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txt_email.Text, emailPattern) == false)
            {
                errorProvider1.SetError(txt_email, "please Enter Valid Email Address");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        //login button
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_email.Text.Trim()))
            {
                txt_email.Focus();
                errorProvider1.SetError(txt_email, "Email Cannot be null");
            }
            else if (string.IsNullOrEmpty(txt_pass.Text.Trim()))
            {
                txt_email.Focus();
                errorProvider1.SetError(txt_pass, "Password Cannot be null");
            }
            else
            {
                string email = txt_email.Text.Trim();
                string pass = txt_pass.Text.Trim();
                User user = new User(id1, fname1, lname1, gender1, birth1, phone1, special1, reg_date1, email1, password1, type1);
                DBconnection.UserLogin(email, pass, user);

                type1 = user.type;
                if (type1 == "Doctor")
                {
                    Doctor_Department doctor_Department = new Doctor_Department();
                    doctor_Department.Show();
                    Hide();
                }
                else if (type1 == "Receptionist")
                {
                    Admin admin = new Admin();
                    admin.Show();
                    Hide();
                }
                else if (type1 == "Pharmacist")
                {
                    Pharmacist_Department pharmacist_Department = new Pharmacist_Department();
                    pharmacist_Department.Show();
                    Hide();
                }
                else if (type1 == "Biologist")
                {
                    Biology_Department biology_Department = new Biology_Department();
                    biology_Department.Show();
                    Hide();
                }
                else if (type1 == "Patient")
                {
                    MessageBox.Show("Patient cannot log in to Hospital Management System, Please login using our website! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_email.Clear();
                    txt_pass.Clear();
                    errorProvider1.Clear();
                }

            }
        }

        public Login_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
