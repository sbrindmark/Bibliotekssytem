using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Bibliotekssytem
{
    public class Books : ISearchable
    {
        public string ISBN;
        public string Title;
        public string Author;

        public Books(string title, string author, string isbn)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"{Title} av {Author} (ISBN: {ISBN})";
        }

        public void Search(string keyWord) 
        {
            if (Title?.Contains(keyWord, StringComparison.OrdinalIgnoreCase) == true ||
                Title?.Contains(keyWord, StringComparison.OrdinalIgnoreCase) == true ||
                Author?.Contains(keyWord, StringComparison.OrdinalIgnoreCase) == true ||
                ISBN.ToString().Contains(keyWord))
            {
                Console.WriteLine($"Hittade: {Title} av {Author} (ISBN: {ISBN})");
            }
        }
        /*public void BorrowBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                Console.WriteLine("Fel: Boken finns inte.");
                return;
            }

        }


    }
}
