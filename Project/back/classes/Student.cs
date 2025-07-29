using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.back.classes
{
    [Serializable]
    public class Student : Citizen
    {

        public string StudentID { get; set; }
        public string Major { get; set; }

        public Student(string city, string phone_Number, string id, string name, string book ,string studentid, string major) : base(city, phone_Number, id,name ,book)
        {
            StudentID = studentid;
            Major = major;
        }
    }

}
