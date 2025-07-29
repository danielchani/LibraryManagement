using Library_Management_System.back.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.back.Files
{
    public class FileUtils
    {
        public static void SavepersonsToFile(BindingList<Person> persons)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileInfo fi = new System.IO.FileInfo("persons.bin");
            using (var binaryFile = fi.Create())
            {
                binaryFormatter.Serialize(binaryFile, persons);
                binaryFile.Flush();
            }
        }

        public static BindingList<Person> LoadpersonsFromFile()
        {
            BindingList<Person> persons;
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileInfo fi = new System.IO.FileInfo("persons.bin");
                using (var binaryFile = fi.OpenRead())
                {
                    persons = (BindingList<Person>)binaryFormatter.Deserialize(binaryFile);
                }
            }
            catch (Exception ex)
            {
                persons = new BindingList<Person>();
            }
            return persons;
        }



        public static void SavebooksToFile(BindingList<Book> books)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileInfo fi = new System.IO.FileInfo("books.bin");
            using (var binaryFile = fi.Create())
            {
                binaryFormatter.Serialize(binaryFile, books);
                binaryFile.Flush();
            }
        }

        public static BindingList<Book> LoadbooksFromFile()
        {
            BindingList<Book> books;
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileInfo fi = new System.IO.FileInfo("books.bin");
                using (var binaryFile = fi.OpenRead())
                {
                    books = (BindingList<Book>)binaryFormatter.Deserialize(binaryFile);
                }
            }
            catch (Exception ex)
            {
                books = new BindingList<Book>();
            }
            return books;
        }

        internal static void SavepersonsToFile(BindingList<Book> books)
        {
            throw new NotImplementedException();
        }
    }
}
