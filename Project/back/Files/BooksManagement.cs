using Library_Management_System.back.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.back.Files
{
    public class BooksManagement
    {
        private static BindingList<Book> books;

        static BooksManagement()
        {
            books = FileUtils.LoadbooksFromFile();
        }

        public static BindingList<Book> GetBooks()
        {
            return books;
        }

        public static void RemoveBooks(Book b)
        {
            books.Remove(b);
        }

        public static void AddBook(Book b)
        {
            books.Add(b);
        }
        public static BindingList<T> GetBookByType<T>() where T : Book
        {
            BindingList<T> requestedBook = new BindingList<T>();
            foreach (var book in books)
            {
                if (book is T)
                {
                    requestedBook.Add(book as T);
                }
            }
            return requestedBook;
        }

        public static void SaveBooks()
        {
            FileUtils.SavebooksToFile(books);
        }
    }
}
