using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class PatientsRegistration
    {
        
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public string birth_date { get; set; }
        public string phone { get; set; }
        public string weight { get; set; }
        public string height { get; set; }
        public string bloodType { get; set; }
        public string address { get; set; }
        public string reg_day { get; set; }
        public string specilist { get; set; }
        public string drname { get; set; }
        public string dId { get; set; }

        public PatientsRegistration(string first_name, string last_name, string gender, string birth_date, string phone, string weight, string height, string bloodType, string address, string reg_day, string specialist, string drname, string dId)
        {

          
            this.first_name = first_name;
            this.last_name = last_name;
            this.gender = gender;
            this.birth_date = birth_date;
            this.phone = phone;
            this.weight = weight;
            this.height = height;
            this.bloodType = bloodType;
            this.address = address;
            this.reg_day = reg_day;
            this.specilist= specialist;
            this.drname = drname;
            this.dId = dId;
           

        }





    }
}
