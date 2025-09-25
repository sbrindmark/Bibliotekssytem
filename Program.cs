namespace Bibliotekssytem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Librarian librarian = new Librarian();
            Borrower borrower = new Borrower();
            List<Books> books = new List<Books>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Välkommen till Bibliotekssystemet!");
                Console.WriteLine("Välj användartyp:");
                Console.WriteLine("1. Bibliotekarie");
                Console.WriteLine("2. Låntagare");
                Console.WriteLine("0. Avsluta");
                Console.Write("Ditt val: ");
                string input = Console.ReadLine();

                if (input == "0")
                {
                    Console.WriteLine("Avslutar programmet...");
                    break;
                }

                switch (input)
                {
                    case "1":
                        librarian.ShowMenu(books);
                        break;
                    case "2":
                        borrower.ShowMenu(books);
                        break;
                    default:
                        Console.WriteLine("Felaktigt val, försök igen.");
                        Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
                        Console.ReadKey();
                        break;
                }

                Console.ReadLine();
            }

        }
    }
}
