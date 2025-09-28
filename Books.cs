using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Bibliotekssytem
{
    // Representerar en bok i biblioteket
    public class Books : ISearchable
    {
        public int Id { get; set; } // Unikt ID för boken
        public string ISBN { get; set; } // ISBN-nummer
        public string Title { get; set; } // Boktitel
        public string Author { get; set; } // Författare
        public bool IsBorrowed { get; set; } // Om boken är utlånad
        public int? BorrowedByUserId { get; set; } // Vilken användare som har lånat boken

        // Konstruktor för att skapa en ny bok
        public Books(int id, string title, string author, string isbn)
        {
            Id = id;
            Title = title;
            Author = author;
            ISBN = isbn;
            IsBorrowed = false;
            BorrowedByUserId = null;
        }

        // Returnerar en strängrepresentation av boken
        public override string ToString()
        {
            return $"[{Id}] {Title} av {Author} (ISBN: {ISBN})" +
                   (IsBorrowed ? " - Utlånad" : " - Tillgänglig");
        }

        // Sökfunktion för att matcha bok mot ett sökord
        public void Search(string keyword)
        {
            if (Title?.Contains(keyword, StringComparison.OrdinalIgnoreCase) == true ||
                Author?.Contains(keyword, StringComparison.OrdinalIgnoreCase) == true ||
                ISBN?.Contains(keyword, StringComparison.OrdinalIgnoreCase) == true)
            {
                Console.WriteLine(ToString());
            }
        }
    }
}
