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

                    case "3": // Låna bok
                        Console.Write("Vilken bok vill du låna? ");
                        int borrowId = int.Parse(Console.ReadLine());

                        Console.Write("Ange ditt användar-ID: ");
                        int borrowUserId = int.Parse(Console.ReadLine());

                        var bookToBorrow = parameterList.FirstOrDefault(b => b.Id == borrowId);
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
                        break;

                    case "4": // Lämna tillbaka bok
                        Console.Write("Ange bok namn att lämna tillbaka: ");
                        int returnId = int.Parse(Console.ReadLine());

                        Console.Write("Ange ditt användar-ID: ");
                        int returnUserId = int.Parse(Console.ReadLine());

                        var bookToReturn = parameterList.FirstOrDefault(b => b.Id == returnId);
                        if (bookToReturn != null && bookToReturn.IsBorrowed && bookToReturn.BorrowedByUserId == returnUserId)
                        {
                            bookToReturn.IsBorrowed = false;
                            bookToReturn.BorrowedByUserId = null;
                            Console.WriteLine($" Du har lämnat tillbaka boken '{bookToReturn.Title}'.");
                        }
                        else
                        {
                            Console.WriteLine("Ogiltig retur – kontrollera bok-ID och användar-ID.");
                        }
                        break;

                    case "5":
                        // ev. avsluta eller gå tillbaka
                        running = false;
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
            if (bookToBorrow.IsBorrowed)
            {
                Console.WriteLine("Boken är redan utlånad.");
                return;
            }

            bookToBorrow.IsBorrowed = true;
            Console.WriteLine($" Du har lånat boken '{bookToBorrow.Title}'.");
        }

        public void ReturnBook(Books bookToReturn)
        {
            if (!bookToReturn.IsBorrowed)
            {
                Console.WriteLine("Den här boken är inte utlånad.");
                return;
            }

            bookToReturn.IsBorrowed = false;
            Console.WriteLine($"Du har lämnat tillbaka boken '{bookToReturn.Title}'.");
        }



    }
}
