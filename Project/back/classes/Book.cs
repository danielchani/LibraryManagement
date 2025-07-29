using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.back.classes
{
    [Serializable]
    public class Book
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; } 
        public string takenBy { get; set; }

        public Book(string title, string author, bool isAvailable, string takenby)
        {
            Title = title;
            Author = author;
            IsAvailable = isAvailable;
            takenBy = takenby;
        }
    }
}
