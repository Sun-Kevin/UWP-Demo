using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindData
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }       

    }
    internal class BookManager
    {
        internal static List<Book> books = new List<Book>();

        internal static List<Book> GetBooks()
        {
            books.Add(new Book { ID = 1000, Title = "Learning C# step by step", Author = "Kevin Sun" });
            books.Add(new Book { ID = 1000, Title = "Thinking in Java", Author = "Tom Cruise" });
            books.Add(new Book { ID = 1000, Title = "Introduction to UWP", Author = "Bob Tabor" });
            books.Add(new Book { ID = 1000, Title = "Create Android Apps", Author = "Google" });
            books.Add(new Book { ID = 1000, Title = "How to use Visual Studio", Author = "Microsoft" });
            books.Add(new Book { ID = 1000, Title = "iOS Development", Author = "Apple" });

            return books;
        }
    }
}
