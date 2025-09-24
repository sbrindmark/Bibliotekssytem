using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssytem
{
    public class Books : ISearchable
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public Books(string isbn, string title, string author)
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
    }

}
