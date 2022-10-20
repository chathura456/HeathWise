using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public class DBconnection
    {
        //create mysql connection
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=hospital_management;Convert Zero Datetime=True;Allow Zero Datetime=True";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("MySQL Connection! \n"+e.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return conn;
        }

        //user details added to the mysql database
        public static void AddUser(User user)
        {
            string sql = "INSERT INTO Users Values (null,@first_name,@last_name,@gender,@birth_date,@phone_no,@specialist,@reg_date,@email,@password,@type)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = user.first_name;
            cmd.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = user.last_name;
            cmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = user.gender;
            cmd.Parameters.Add("@birth_date", MySqlDbType.VarChar).Value = user.birth_date;
            cmd.Parameters.Add("@phone_no", MySqlDbType.VarChar).Value = user.phone;
            cmd.Parameters.Add("@specialist", MySqlDbType.VarChar).Value = user.special;
            cmd.Parameters.Add("@reg_date", MySqlDbType.VarChar).Value = user.reg_date;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = user.email;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = user.password;
            cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = user.type;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully! \n" , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        //user details update
        public static void UpdateUser(User user, string id)
        {
            string sql = "Update Users Set First_Name = @first_name, Last_name = @last_name, Gender = @gender, Birth_Date = @birth_date, Phone_No = @phone_no, Specialist = @specialist, Reg_Date = @reg_date, Email = @email, Password = @password, User_Type = @type WHERE Id = @id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = user.first_name;
            cmd.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = user.last_name;
            cmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = user.gender;
            cmd.Parameters.Add("@birth_date", MySqlDbType.VarChar).Value = user.birth_date;
            cmd.Parameters.Add("@phone_no", MySqlDbType.VarChar).Value = user.phone;
            cmd.Parameters.Add("@specialist", MySqlDbType.VarChar).Value = user.special;
            cmd.Parameters.Add("@reg_date", MySqlDbType.VarChar).Value = user.reg_date;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = user.email;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = user.password;
            cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = user.type;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        //delete user
        public static void  DeleteUser(string id)
        {
            string sql = "DELETE FROM Users Where Id = @id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        //display all user's details using datagridview
        public static void DisplayUser(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            dgv.DataSource = dataTable;
            con.Close();
        }

        //user login
        public static void UserLogin(string email,string pass,User user)
        {
            string sql = "SELECT * FROM Users WHERE Email=@email and Password=@password";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
           cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = pass;

           
            try
            {
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    user.first_name = reader["First_Name"].ToString();
                    user.type = reader["User_Type"].ToString();
                   MessageBox.Show("Login Successfully! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    
                }
                else
                {
                    MessageBox.Show("Email or Password Incorrect \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
  
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
