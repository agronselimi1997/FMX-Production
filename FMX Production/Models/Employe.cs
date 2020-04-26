using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMX_Production
{
    class Employe
    {
        public int id { get; set; }
        public string employeName { get; set; }
        public string employeSurname { get; set; }
        public bool isPhotograph { get; set; }
        public bool isFlycamist { get; set; }
        public bool isKranist { get; set; }
        public bool isDronist { get; set; }
        public bool isKameraman { get; set; }
        public string employeEmail { get; set; }
        public string phoneNumber { get; set; }
        public string fullinfo
        {
            get { return employeName + " " + employeSurname; }
        }
        public int getId()
        {
            return id;
        }

        public Employe(string employeName, string employeSurname, bool isPhotograph, bool isFlycamist, bool isKranist, bool isDronist, bool isKameraman, string employeEmail, string phoneNumber)
        {
            this.employeName = employeName;
            this.employeSurname = employeSurname;
            this.isPhotograph = isPhotograph;
            this.isFlycamist = isFlycamist;
            this.isKranist = isKranist;
            this.isDronist = isDronist;
            this.isKameraman = isKameraman;
            this.employeEmail = employeEmail;
            this.phoneNumber = phoneNumber;
        }

        public Employe(System.Int32 Id, System.String Name, System.String Surname, System.String Email, System.String Phonenumber, System.Boolean isPhotograph, System.Boolean isCameraman,
            System.Boolean isKranist, System.Boolean isDronist, System.Boolean isFlycamist)
        {
            this.id = Id;
            this.employeName = Name;
            this.employeSurname = Surname;
            this.isPhotograph = isPhotograph;
            this.isFlycamist = isFlycamist;
            this.isKranist = isKranist;
            this.isDronist = isDronist;
            this.isKameraman = isCameraman;
            this.employeEmail = Email;
            this.phoneNumber = Phonenumber;

        }



    }
}
