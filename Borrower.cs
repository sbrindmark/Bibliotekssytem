using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssytem
{
    public class Borrower : User
    {

        public override void ShowMenu(List<Books> parameterList)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Borrower Menu");
                Console.WriteLine("1. Search Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Borrow Book");
                Console.WriteLine("4. Return Book");
                Console.WriteLine("5. Exit");
                // kraftigt genererad med AI
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        SearchBook(parameterList);
                        break;
                    case "2":
                        ListBooks(parameterList);
                        break;
                    case "3":
                        //Låna bok
                        break;
                    case "4":
                        //Lämna tillbaka bok
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val.");
                        break;
                }
            }

        }

        public List<Books> borrowedBooks = new List<Books>();

        public void BorrowBook(Books bookToBorrow)
        {
            if (bookToBorrow.isBorrowed)
            {
                Console.WriteLine("Boken är redan utlånad.");
                return;
            }

            bookToBorrow.isBorrowed = true;
            Console.WriteLine($" Du har lånat boken '{bookToBorrow.Title}'.");
        }

        public void ReturnBook(Books bookToReturn)
        {
            if (!bookToReturn.isBorrowed)
            {
                Console.WriteLine("Den här boken är inte utlånad.");
                return;
            }

            bookToReturn.isBorrowed = false;
            Console.WriteLine($"Du har lämnat tillbaka boken '{bookToReturn.Title}'.");
        }



    }
}
