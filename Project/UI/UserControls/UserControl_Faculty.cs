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
    public partial class UserControl_Employee : UserControl
    {
        BindingList<Emplyee> employee;
        public UserControl_Employee(BindingList<Emplyee> employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void BT_Borrow_Click(object sender, EventArgs e)
        {
            string name = TXT_EN.Text;
            string id = TXT_EID.Text;
            string Eid = TXT_ESID.Text;
            string section = TXT_ES.Text;
            string city = textBox3.Text;
            string book = textBook.Text;
            string pn = textBox2.Text;
            Emplyee employe = new Emplyee(city, pn, id, name, book, Eid, section);
            PersonManagement.AddPerson(employe);
            employee.Add(employe);
        }
    }
}
