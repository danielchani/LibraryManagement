using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.back.classes
{
    [Serializable]
    public class Emplyee : Citizen
    {
        public string EmployeeID { get; set; }
        public string section { get; set; }

        public Emplyee(string city, string phone_Number, string id, string name, string book, string employeeID, string department)
            : base(city, phone_Number, id, name, book)
        {
            EmployeeID = employeeID;
            section = department;
        }
    }
}
