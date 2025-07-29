using Library_Management_System.back.Files;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.back.classes
{
    [Serializable]
    public class Citizen : Person
    {
        public string City { get; set; }
        public string Phone_Number { get; set; }
        public string Book { get; set; }

        public Citizen(string city, string phone_Number, string id, string name, string book) : base(id, name)
        {
            City = city;
            Phone_Number = phone_Number;
            Book = book;

            // Load all books from file
            if (BooksManagement.GetBooks() != null)
            {
                // Check if the book exists in the library
                Book matchingBook = BooksManagement.GetBooks().FirstOrDefault(b => b.Title.Equals(book, StringComparison.OrdinalIgnoreCase));

                if (matchingBook != null)
                {
                    // Update the book's properties
                    matchingBook.IsAvailable = false;
                    matchingBook.takenBy = name.ToString();
                }
                else
                {
                    // Handle the case where the book is not found
                    MessageBox.Show("The book is not available in the library.");
                    Book = null;
                }
            }
        }
    }
}
