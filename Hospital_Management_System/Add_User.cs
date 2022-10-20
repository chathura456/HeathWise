using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
namespace Hospital_Management_System
{
    public partial class Add_User : Form
    {
        private readonly Manage_Users _parent;
        public string emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        public string type, specialist, bday, reg_day, gender, acc_type;
        public string id1, fname1, lname1, gender1, birth1, phone1, special1, reg_date1, email1, password1, type1;

        public Add_User(Manage_Users parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        private void Add_User_Load(object sender, EventArgs e)
        {
            //add user type dropdown menu values
            dropdown_type.Items.Clear();
            dropdown_type.Items.Add("Patient");
            dropdown_type.Items.Add("Doctor");
            dropdown_type.Items.Add("Pharmacist");
            dropdown_type.Items.Add("Biologist");
            dropdown_type.Items.Add("Receptionist");

            //add specialist dropdown values
            dropdown_spc.Items.Clear();
            dropdown_spc.Items.Add("Cardiologists");
            dropdown_spc.Items.Add("Endocrinologists");
            dropdown_spc.Items.Add("Nephrologists");
            dropdown_spc.Items.Add("Urologists");
            dropdown_spc.Items.Add("Pulmonologists");

            //add values to update screen
            if (type1 != null)
            {
                dropdown_type.SelectedItem = type1;
            }
            if (special1 != null)
            {
                dropdown_spc.SelectedItem = special1;
                string spcvalue = special1;
                dropdown_spc.Enabled = false;
                if (type1 == "Doctor")
                {
                    dropdown_spc.Enabled = true;
                }
            }
            if (birth1 != null)
            {
                birth_picker.Value = DateTime.ParseExact(birth1, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            }
            if (reg_date1 != null)
            {
                reg_picker.Value = DateTime.ParseExact(reg_date1, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            }
        }

        //submit button
        private void button1_Click(object sender, EventArgs e)
        {
            var fname = txt_fname.Text;
            var lname = txt_lname.Text;
            var phone = txt_phone.Text;
            var email = txt_uname.Text;
            var pass = txt_pass.Text;
            //get values from radio button
            if (radiobtn_male.Checked)
            {
                gender = radiobtn_male.Text;
            }
            else if (radiobtn_female.Checked)
            {
                gender = radiobtn_female.Text;
            }
            if (type == null)
            {
                dropdown_type.Focus();
                errorProvider1.SetError(dropdown_type, "Please Select User Type");
            }
            else if (string.IsNullOrEmpty(txt_fname.Text.Trim()))
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
            else if (dropdown_spc.Enabled == true && specialist == null)
            {
                dropdown_spc.Focus();
                errorProvider.SetError(dropdown_spc, "Please Select the Specialist");
            }
            else if (reg_day == null)
            {
                reg_picker.Focus();
                errorProvider.SetError(reg_picker, "Please Select the register Date");
            }
            else if (string.IsNullOrEmpty(txt_uname.Text.Trim()))
            {
                txt_uname.Focus();
                errorProvider.SetError(txt_uname, "User's Email is Required");
            }
            else if (string.IsNullOrEmpty(txt_pass.Text.Trim()))
            {
                txt_pass.Focus();
                errorProvider.SetError(txt_pass, "Password is Required");
            }
            else if (string.IsNullOrEmpty(txt_pass2.Text.Trim()))
            {
                txt_pass2.Focus();
                errorProvider.SetError(txt_pass2, "Re-Password is Required");
            }
            else if (txt_pass.Text != txt_pass2.Text)
            {
                txt_pass2.Focus();
                errorProvider.SetError(txt_pass2, "Password not matching");
            }
            if (txt_pass.Text != txt_pass2.Text)
            {
                errorProvider.SetError(txt_pass2, "Password not matching");
            }
            else
            {
                if (button1.Text == "Submit")
                {
                    User user = new User(fname, lname, gender, bday, phone, specialist, reg_day, email, pass, type);
                    DBconnection.AddUser(user);
                    Clear();
                }
                if (button1.Text == "Update")
                {
                    User user = new User(fname, lname, gender, bday, phone, specialist, reg_day, email, pass, type);
                    DBconnection.UpdateUser(user, id1);
                    Clear();
                    this.Close();
                }
            }
            _parent.Display();
        }


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
        private void dropdown_spc_SelectedIndexChanged(object sender, EventArgs e)
        {
            specialist = dropdown_spc.SelectedItem.ToString();
        }
        private void dropdown_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = dropdown_type.SelectedItem.ToString();
            //specialist dropdown enabled when Doctor value selected in user type menu
            if (type == "Doctor")
            {
                dropdown_spc.Enabled = true;
            }
            else
            {
                dropdown_spc.Enabled = false;
            }
        }


        //check validation of input fields when leaving
        private void dropdown_type_Leave(object sender, EventArgs e)
        {
            if (type == null)
            {
                errorProvider1.SetError(dropdown_type, "Please Select User's Account Type");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void txt_fname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_fname.Text.Trim()))
            {
                errorProvider1.SetError(txt_fname, "First Name is Required");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void txt_lname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_lname.Text.Trim()))
            {
                errorProvider1.SetError(txt_lname, "LastName is Required");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void birth_picker_Leave(object sender, EventArgs e)
        {
            if (bday == null)
            {
                errorProvider.SetError(birth_picker, "Birth Date is required");
            }
            else
            {
                errorProvider.Clear();
            }
        }
        private void txt_phone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_phone.Text.Trim()))
            {
                errorProvider.SetError(txt_phone, "Phone Number is Required");
            }
            else
            {
                errorProvider.Clear();
            }
        }
        private void dropdown_spc_Leave(object sender, EventArgs e)
        {
            if (dropdown_spc.Enabled == true && specialist == null)
            {
                errorProvider.SetError(dropdown_spc, "Please Select the Specialist");
            }
            else
            {
                errorProvider.Clear();
            }
        }
        private void reg_picker_Leave(object sender, EventArgs e)
        {
            if (reg_day == null)
            {
                errorProvider.SetError(reg_picker, "Please Select the register Date");
            }
            else
            {
                errorProvider.Clear();
            }
        }
        private void txt_uname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_uname.Text.Trim()))
            {
                errorProvider.SetError(txt_uname, "User's Email is Required");
            }
            else if (Regex.IsMatch(txt_uname.Text, emailPattern) == false)
            {
                txt_uname.Focus();
                errorProvider.SetError(txt_uname, "please Enter Valid Email Address");
            }
            else
            {
                errorProvider.Clear();
            }
        }
        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_pass.Text.Trim()))
            {
                errorProvider.SetError(txt_pass, "Password is Required");
            }
            else
            {
                errorProvider.Clear();
            }
        }
        private void txt_pass2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_pass.Text.Trim()))
            {
                errorProvider.SetError(txt_pass, "Re-Password is Required");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        //clear button
        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            txt_fname.Clear();
            txt_lname.Clear();
            txt_uname.Clear();
            txt_pass2.Clear();
            txt_pass.Clear();
            txt_phone.Clear();
            txt_uname.Clear();
            dropdown_spc.ResetText();
            dropdown_spc.Enabled = false;
            radiobtn_male.Checked = false;
            radiobtn_female.Checked = false;
            dropdown_type.ResetText();
            birth_picker.Text = string.Empty;
            reg_picker.Text = string.Empty;
            reg_day = null;
            bday = null;
            errorProvider.Clear();
            errorProvider1.Clear();
        }
       
        //check validation when typing a input
        private void txt_uname_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txt_uname.Text, emailPattern) == false)
            {
                errorProvider.SetError(txt_uname, "please Enter Valid Email Address");
            }
            else
            {
                errorProvider.Clear();
            }
        }
        private void txt_pass2_TextChanged(object sender, EventArgs e)
        {
            if (txt_pass.Text != txt_pass2.Text)
            {
                errorProvider.SetError(txt_pass2, "Password not matching");
            }
            else
            {
                errorProvider.Clear();
            }
        }


        /*********************************User Details Update*************************************/
        public void UpdateInfo()
        {
            //topic and button value change
            label1.Text = "User Details Update";
            button1.Text = "Update";

            //textbox values set
            txt_fname.Text = fname1;
            txt_lname.Text = lname1;
            txt_pass.Text = password1;
            txt_pass2.Text = password1;
            txt_phone.Text = phone1;
            txt_uname.Text = email1;

            //radio button values set
            if (gender1 == "Male")
            {
                radiobtn_male.Checked = true;
                gender = radiobtn_male.Text;
            }
            if (gender1 == "Female")
            {
                radiobtn_female.Checked = true;
                gender = radiobtn_female.Text;
            }
        }
    }
}
