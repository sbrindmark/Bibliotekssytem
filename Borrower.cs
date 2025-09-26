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
                Console.WriteLine("\nBorrower Menu");
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
                        BorrowBook(parameterList);
                        break;
                    case "4":
                        ReturnBook(parameterList);
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val.");
                        break;
                }
                if (running)
                {
                    Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

        }

        public List<Books> borrowedBooks = new List<Books>();

        public void BorrowBook(List<Books> books)
        {
            ListBooks(books);
            Console.Write("Vilken bok vill du låna? ");
            if (!int.TryParse(Console.ReadLine(), out int borrowId))
            {
                Console.WriteLine("Ogiltigt bok-ID");
                return;
            }
            Console.Write("Ange ditt användar-ID: ");
            if (!int.TryParse(Console.ReadLine(), out int borrowUserId))
            {
                Console.WriteLine("Ogiltigt användar-ID");
                return;
            }

            var bookToBorrow = books.FirstOrDefault(b => b.Id == borrowId);
            if (bookToBorrow != null && !bookToBorrow.IsBorrowed)
            {
                bookToBorrow.IsBorrowed = true;
                bookToBorrow.BorrowedByUserId = borrowUserId;
                Console.WriteLine($"Du har lånat boken '{bookToBorrow.Title}'.");
            }
            else
            {
                Console.WriteLine("Boken hittades inte eller är redan utlånad.");
            }
        }

        public void ReturnBook(List<Books> books)
        {
            ListBooks(books);
            Console.Write("Ange bok-ID att lämna tillbaka: ");
            if (!int.TryParse(Console.ReadLine(), out int returnId))
            {
                Console.WriteLine("Ogiltigt bok-ID");
                return;
            }
            Console.Write("Ange ditt användar-ID: ");
            if (!int.TryParse(Console.ReadLine(), out int returnUserId))
            {
                Console.WriteLine("Ogiltigt användar-ID");
                return;
            }

            var bookToReturn = books.FirstOrDefault(b => b.Id == returnId);
            if (bookToReturn != null && bookToReturn.IsBorrowed && bookToReturn.BorrowedByUserId == returnUserId)
            {
                bookToReturn.IsBorrowed = false;
                bookToReturn.BorrowedByUserId = null;
                Console.WriteLine($"Du har lämnat tillbaka boken '{bookToReturn.Title}'.");
            }
            else
            {
                Console.WriteLine("Ogiltig retur – kontrollera bok-ID och användar-ID.");
            }
        }
       

    }
}
