using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssytem
{
    public class Borrower : User
    {
        
        public override void ShowMenu()
        {
            Console.WriteLine("Borrower Menu");
            Console.WriteLine("1. Search Book");
            Console.WriteLine("2. View All Books");
            Console.WriteLine("3. Borrow Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Exit");
        }

        public List<Books> borrowedBooks = new List<Books>();

        public void BorrowBook(Books bookToBorrow)
        {
            if (bookToBorrow.isBorrowed)
            {
                Console.WriteLine("This book is already borrowed.");
                return;
            }

            bookToBorrow.isBorrowed = true;
            borrowedBooks.Add(bookToBorrow);
            Console.WriteLine($"You have borrowed: {bookToBorrow.title}");
        }

        public void ReturnBook(Books bookToReturn)
        {
            if (!borrowedBooks.Contains(bookToReturn))
            {
                Console.WriteLine("You have not borrowed this book.");
                return;
            }

            bookToReturn.isBorrowed = false;
            borrowedBooks.Remove(bookToReturn);
            Console.WriteLine($"You have returned: {bookToReturn.title}");
        }

    }
}
