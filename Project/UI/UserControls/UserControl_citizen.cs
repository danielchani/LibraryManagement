using Library_Management_System.back.classes;
using Library_Management_System.back.Files;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.UI.UserControls
{
    public partial class UserControl_citizen : UserControl
    {
        BindingList<Citizen> citizens;
        public UserControl_citizen(BindingList<Citizen> citizens)
        {
            InitializeComponent();
            this.citizens = citizens;
        }

        private void BT_Click(object sender, EventArgs e)
        {
            string city = textBox1.Text;
            string phone_Number = textBox2.Text;
            string id = TXT_ID.Text;
            string name = TXT_SN.Text;
            string book = textBox3.Text;
            Citizen citizen = new Citizen(city, phone_Number, id, name, book);
            PersonManagement.AddPerson(citizen);
            citizens.Add(citizen);
        }
    }
}
