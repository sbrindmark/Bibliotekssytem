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
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsBorrowed { get; set; }
        public int? BorrowedByUserId { get; set; }

        public Books(int id, string title, string author, string isbn)
        {
            Id = id;
            Title = title;
            Author = author;
            ISBN = isbn;
            IsBorrowed = false;
            BorrowedByUserId = null;
        }

        public override string ToString()
        {
            return $"[{Id}] {Title} av {Author} (ISBN: {ISBN})" +
                   (IsBorrowed ? " - Utlånad" : " - Tillgänglig");
        }

        public void Search(string keyword)
        {
            if (Title?.Contains(keyword, StringComparison.OrdinalIgnoreCase) == true ||
                Author?.Contains(keyword, StringComparison.OrdinalIgnoreCase) == true ||
                ISBN?.Contains(keyword, StringComparison.OrdinalIgnoreCase) == true)
            {
                Console.WriteLine(ToString());
            }        }
    }
}
