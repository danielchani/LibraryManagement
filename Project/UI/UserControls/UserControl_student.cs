using Library_Management_System.back.classes;
using Library_Management_System.back.Files;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.UI.UserControls
{
    public partial class UserControl_student : UserControl
    {
        BindingList<Student> students;
        public UserControl_student(BindingList<Student> students)
        {
            InitializeComponent();
            this.students = students;
        }

        private void BT_Borrow_Click(object sender, EventArgs e)
        {
            string name = TXT_SN.Text;
            string ID = TXT_ID.Text;
            string st_ID = TXT_SID.Text;
            string M = TXT_SM.Text;
            string B = TXT_B.Text;
            string P = txt_p.Text;
            string c = txt_c.Text;
            Student s = new Student(c, P, ID, name, B, st_ID, M);
            PersonManagement.AddPerson(s);
            students.Add(s);
            
        }
    }
}
