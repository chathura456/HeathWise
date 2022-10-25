using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hospital_Management_System
{
    public class DBconnection
    {
        public static string id,name;
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
                     id=reader["id"].ToString();
                    name=reader["First_name"].ToString();
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


        //Add patient details to the database 

        public static void AddPatient(PatientsRegistration patient)
        {
            string sql = "INSERT INTO patientsdetails Values (null,@First_Name,@Last_name,@Gender,@Birth_Date,@Phone_No,@Weight,@height,@Blood_Type,@Address,@Reg_Date,@Appointed_Specialist,@Appointed_Dr,@DId)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@First_Name", MySqlDbType.VarChar).Value = patient.first_name;
            cmd.Parameters.Add("@Last_name", MySqlDbType.VarChar).Value = patient.last_name;
            cmd.Parameters.Add("@Gender", MySqlDbType.VarChar).Value = patient.gender;
            cmd.Parameters.Add("@Birth_Date", MySqlDbType.VarChar).Value = patient.birth_date;
            cmd.Parameters.Add("@Phone_No", MySqlDbType.VarChar).Value = patient.phone;
            cmd.Parameters.Add("@Weight", MySqlDbType.VarChar).Value = patient.weight;
            cmd.Parameters.Add("@height", MySqlDbType.VarChar).Value = patient.height;
            cmd.Parameters.Add("@Blood_Type", MySqlDbType.VarChar).Value = patient.bloodType;
            cmd.Parameters.Add("@Address", MySqlDbType.VarChar).Value = patient.address;
            cmd.Parameters.Add("@Reg_Date", MySqlDbType.VarChar).Value = patient.reg_day;
            cmd.Parameters.Add("@Appointed_Specialist", MySqlDbType.VarChar).Value = patient.specilist;
            cmd.Parameters.Add("@Appointed_Dr", MySqlDbType.VarChar).Value = patient.drname;
            cmd.Parameters.Add("@DId", MySqlDbType.VarChar).Value = patient.dId;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }


        //find the doctor according to patient registration

        public static string findDoctor(string specialist,string drName)
        {
            string id;
            string sql = "SELECT Id  FROM users WHERE Specialist=@specialis and First_Name=@fname";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@specialis", MySqlDbType.VarChar).Value = specialist;
            cmd.Parameters.Add("@fname", MySqlDbType.VarChar).Value = drName;

            try
            {
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                id = reader["Id"].ToString();
                return id;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Cannot Find Doctor! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();


            return null;
            
                

        }

        //add patient for doctors waiting list


        public static void AddPatientWaitingList(string fname,string lname)
        {
            string sql = "INSERT INTO patientswaiting SELECT SSNo,First_Name,Last_Name,Reg_Date,Appointed_Specialist,Appointed_Dr,DId FROM patientsdetails WHERE First_Name='"+fname+ "' and Last_Name='"+lname+"' ";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
        
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully for waiting list! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! waiting list \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        //remove patient form waiting list
        public static void RemovePatient(string id)
        {
            string sql = "DELETE FROM patientswaiting Where SSNo = @id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Remove form queue Successfully! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        //switch patient to the lab tesing list
        public static void AddPatientTOLab(string id)
        {
            string sql = "INSERT INTO patientlab SELECT * FROM patientswaiting Where SSNo = @id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added to Lab queue Successfully! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }




        //Add patient's prescription  details to the database 

        public static void AddPrescription(Prescription prescription)
        {
            string sql = "INSERT INTO patientsprescription Values (@SSNo,@First_Name,@Last_name,@Date,@Age,@Diagnosis,@Medicines,@Notes,@Appointed_Dr,@DId)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@SSNo", MySqlDbType.VarChar).Value = prescription.ssno;
            cmd.Parameters.Add("@First_Name", MySqlDbType.VarChar).Value = prescription.fname1;
            cmd.Parameters.Add("@Last_name", MySqlDbType.VarChar).Value = prescription.lname1;
            cmd.Parameters.Add("@Date", MySqlDbType.VarChar).Value = prescription.date;
            cmd.Parameters.Add("@Age", MySqlDbType.VarChar).Value = prescription.age;
            cmd.Parameters.Add("@Diagnosis", MySqlDbType.VarChar).Value = prescription.diagnosis;
            cmd.Parameters.Add("@Medicines", MySqlDbType.VarChar).Value = prescription.medicine;
            cmd.Parameters.Add("@Notes", MySqlDbType.VarChar).Value = prescription.other;
            cmd.Parameters.Add("@Appointed_Dr", MySqlDbType.VarChar).Value = prescription.drname;
            cmd.Parameters.Add("@DId", MySqlDbType.VarChar).Value = prescription.did1;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Prescription Added Successfully! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }




    }
}
