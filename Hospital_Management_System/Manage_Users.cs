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
    public partial class Manage_Users : Form
    {
        Add_User form;
        public Manage_Users()
        {
            InitializeComponent();
            form = new Add_User(this);
        }
        private void Manage_Users_Load(object sender, EventArgs e)
        {
            Display();
        }

        //add_user button
        private void button1_Click(object sender, EventArgs e)
        {
            //open add_user window
            form.Clear();
            form.ShowDialog();
        }

        //display user's data
        public void Display()
        {
            DBconnection.DisplayUser("Select Id, First_Name, Last_name, Gender, Birth_Date, Phone_No, Specialist, Reg_Date, Email, Password, User_Type FROM Users", dataGridView1);
        }

        //set values to datagridview
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //edit user button
                form.Clear();
                form.id1 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.fname1=dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.lname1 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.gender1 = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.birth1 = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.phone1 = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.special1 = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.reg_date1 = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                form.email1 = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                form.password1 = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                form.type1 = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }

            if(e.ColumnIndex == 1)
            {
                //delete user button
                if(MessageBox.Show("Are You want to delete this user record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBconnection.DeleteUser(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
