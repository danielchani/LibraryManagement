using Library_Management_System.back.classes;
using Library_Management_System.back.Files;
using Library_Management_System.Enum;
using Library_Management_System.UI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CB1.DataSource = Enum_CB1.GetValues(typeof(Enum_CB1));
        }
       private void CB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            if (CB1.SelectedItem.ToString() == Enum_CB1.student.ToString())
            {
                BindingList<Student> students = PersonManagement.GetPersonByType<Student>();
                panel1.Controls.Add(new UserControl_student(students));
                dataGridView1.DataSource = students;
            }
            else if (CB1.SelectedItem.ToString() == Enum_CB1.employee.ToString())
            {
                BindingList<Emplyee> faculty = PersonManagement.GetPersonByType<Emplyee>();
                panel1.Controls.Add(new UserControl_Employee(faculty));
                dataGridView1.DataSource = faculty;
            }
            else if (CB1.SelectedItem.ToString() == Enum_CB1.Books.ToString())
            {
                BindingList<Book> book = BooksManagement.GetBookByType<Book>();
                panel1.Controls.Add(new UserControl_Book(book));
                dataGridView1.DataSource = book;
            }
            else if (CB1.SelectedItem.ToString() == Enum_CB1.citizen.ToString())
            {
                BindingList<Citizen> citizens = PersonManagement.GetPersonByType<Citizen>();
                panel1.Controls.Add(new UserControl_citizen(citizens));
                dataGridView1.DataSource = citizens;
            }
        }
        private void dataGridViewPerson_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (CB1.SelectedItem.ToString() == Enum_CB1.Books.ToString())
            {
                Book bookToDelete = (Book)dataGridView1.Rows[e.Row.Index].DataBoundItem;
                BooksManagement.RemoveBooks(bookToDelete);
            }
            else
            {
                Person personToDelete = (Person)dataGridView1.Rows[e.Row.Index].DataBoundItem;
                PersonManagement.RemovePerson(personToDelete);
            }
        }
        private void FormPersons_FormClosing(object sender, FormClosingEventArgs e)
        {
            PersonManagement.SavePersons();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            PersonManagement.SavePersons();
            BooksManagement.SaveBooks();
            Application.Exit();

        }
      
    }
}
