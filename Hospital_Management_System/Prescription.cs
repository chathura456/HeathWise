namespace Hospital_Management_System
{
    public class Prescription
    {
        public string ssno;
        public string fname1;
        public string lname1;
        public string date;
        public string age;
        public string diagnosis;
        public string medicine;
        public string other;
        public string did1;
        public string drname;

        public Prescription(string ssno, string fname1, string lname1, string date, string age, string diagnosis, string medicine, string other, string did1, string drname)
        {
            this.ssno = ssno;
            this.fname1 = fname1;
            this.lname1 = lname1;
            this.date = date;
            this.age = age;
            this.diagnosis = diagnosis;
            this.medicine = medicine;
            this.other = other;
            this.did1 = did1;
            this.drname = drname;
        }
    }
}