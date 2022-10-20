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
    public partial class Login : Form
    {
        public string emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        public string id1, fname1, lname1, gender1, birth1, phone1, special1, reg_date1, email1, password1, type1;
        public Login()
        {
            InitializeComponent();
        }

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
                DBconnection.UserLogin(email, pass,user);
                
                
                type1 = user.type;
                if (type1 == "Doctor")
                {
                    Doctor_Home doctor_Home = new Doctor_Home();
                    doctor_Home.Show();
                    Hide();
                }
                else if (type1 == "Receptionist")
                {
                    Receptionist receptionist = new Receptionist();
                    receptionist.Show();
                    Hide();
                }
                else if (type1 == "Pharmacist")
                {
                    Pharmacist pharmacist = new Pharmacist();
                    pharmacist.Show();
                    Hide();
                }
                else if (type1 == "Biologist")
                {
                    Biologist biologist = new Biologist();
                    biologist.Show();
                    Hide();
                }
                else if (type1 == "Patient")
                {
                    Patient patient = new Patient();
                    patient.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Account type not defined. Please cantact receptionist");
                }

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
    }
}
