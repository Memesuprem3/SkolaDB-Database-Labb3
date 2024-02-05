using SkolaDB_Database_Labb3.Data;
using SkolaDB_Database_Labb3.Models;

using SkolaDbContext context = new SkolaDbContext();

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
            SortStudents.Sort();
            break;
        case "2":
            Console.Clear();
            ChoseClass.Choose();
            break;
        case "3":
            Console.Clear();
            AddEmployee.AddNewEmplyoee();
            break;
        case "4":
            Console.WriteLine("Avslutar programmet...");
            return;
        default:
            Console.WriteLine("Ogiltigt val, försök igen.");
            break;
    }
}
    
