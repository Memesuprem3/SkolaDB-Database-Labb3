using SkolaDB_Database_Labb3.Data;
using SkolaDB_Database_Labb3.Models;

namespace SkolaDB_Database_Labb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using SkolaDbContext context = new SkolaDbContext();
           
            Sortering sortering = new Sortering();
            VäljKlass Välj = new VäljKlass();
            AddPersonal addPersonal = new AddPersonal();


            
            while (true)
            {
                Console.WriteLine("\nVälkommen till skolans administrationsprogram!");
                Console.WriteLine("1. Visa och sortera elever");
                Console.WriteLine("2. Visa elever i en specifik klass");
                Console.WriteLine("3. Lägg till ny personal");
                Console.WriteLine("4. Avsluta programmet");
                Console.WriteLine("Välj ett alternativ (1-4):");

                var val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                        Console.Clear();    
                        sortering.Sort();
                        break;
                    case "2":
                        Console.Clear();
                        Välj.Välj();
                        break;
                    case "3":
                        Console.Clear();
                        addPersonal.LäggTillNyPersonal();
                        break;
                    case "4":
                        Console.WriteLine("Avslutar programmet...");
                        return;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
            }
        }
    }
}
    
