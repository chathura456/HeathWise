using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class User
    {
        public string first_name { get; set; }
        public string id { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public string birth_date { get; set; }
        public string phone { get; set; }
        public string special { get; set; }
        public string reg_date{ get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string type { get; set; }

        public User(string first_name, string last_name, string gender, string birth_date, string phone, string special, string reg_date, string uname, string password, string type)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.gender = gender;
            this.birth_date = birth_date;
            this.phone = phone;
            this.special = special;
            this.reg_date = reg_date;
            this.email = uname;
            this.password = password;
            this.type = type;
        }

        public User()
        {
        }

        public User(string first_name, string id, string last_name, string gender, string birth_date, string phone, string special, string reg_date, string email, string password, string type) : this(first_name, id, last_name, gender, birth_date, phone, special, reg_date, email, password)
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.gender = gender;
            this.birth_date = birth_date;
            this.phone = phone;
            this.special = special;
            this.reg_date = reg_date;
            this.email = email;
            this.password = password;
            this.type = type;
        }
    }
}
