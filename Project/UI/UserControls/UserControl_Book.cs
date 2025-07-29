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
    public partial class UserControl_Book : UserControl
    {
        BindingList<Book> books;

        public UserControl_Book(BindingList<Book> books)
        {
            InitializeComponent();
            this.books = books;  
        }

        private void BT_return_Click(object sender, EventArgs e)
        {
            string name = TXT_title.Text;
            string Aut = TXT_Aut.Text;
            string Taken = TXT_TB.Text;
            bool A = radioButton1.Checked;
            Book s = new Book(name, Aut, A, Taken);
            BooksManagement.AddBook(s);
            books.Add(s);
        }
    }
}
