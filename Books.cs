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
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

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

            if (book.IsBorrowed)
            {
                Console.WriteLine("Fel: Boken är redan utlånad.");
            }
            else
            {
                book.IsBorrowed = true;
                Console.WriteLine($"Du har lånat boken: {book.Title}");
            }
        }

        public void ReturnBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                Console.WriteLine("Fel: Boken finns inte.");
                return;
            }

            if (!book.IsBorrowed)
            {
                Console.WriteLine("Fel: Boken är inte utlånad.");
            }
            else
            {
                book.IsBorrowed = false;
                Console.WriteLine($"Du har lämnat tillbaka boken: {book.Title}");
            }*/
        }
    }


