using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssytem
{
    public class Books : ISearchable
    {
        string title, author;
        int isbn;
        public bool isBorrowed;

        private List<Books> books = new List<Books>();
        public List<Books> GetAllBooks()
        {
            Console.WriteLine("De böcker som finns i lager är: ");
            return books;
        }

        public Books(string title, string author, int isbn)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            isBorrowed = false;
        }

        public void Search(string keyWord)
        {
            if (title?.Contains(keyWord, StringComparison.OrdinalIgnoreCase) == true ||
                title?.Contains(keyWord, StringComparison.OrdinalIgnoreCase) == true ||
                author?.Contains(keyWord, StringComparison.OrdinalIgnoreCase) == true ||
                isbn.ToString().Contains(keyWord))
            {
                Console.WriteLine($"Hittade: {this.title} av {this.author} (ISBN: {this.isbn})");
            }
        }


    }
}
