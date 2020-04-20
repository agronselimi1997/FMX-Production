using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMX_Production
{
    class Employe
    {
        int id { get; set; }
        string employeName { get; set; }
        string employeSurname { get; set; }
        bool isPhotograph { get; set; }
        bool isFlycamist { get; set; }
        bool isKranist { get; set; }
        bool isDronist { get; set; }
        bool isKameraman { get; set; }
        public string employeEmail { get; set; }
        public string  phoneNumber { get; set; }
        public string  fullinfo {
            get { return employeName +" " + employeSurname;  }
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
