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
        } // kraftigt genererad med AI

    }
}
