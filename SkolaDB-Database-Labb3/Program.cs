using SkolaDB_Database_Labb3.Data;
using SkolaDB_Database_Labb3.Models;

using SkolaDbContext context = new SkolaDbContext();

while (true)
{
    Console.WriteLine("\nVälkommen till skolans administrationsprogram!");
    Console.WriteLine("1. Visa och sortera elever");
    Console.WriteLine("2. Visa elever i en specifik klass");
    Console.WriteLine("3. Visa information om elever");
    Console.WriteLine("4. lägg till ny personal");
    Console.WriteLine("5. Visa alla lärare");
    Console.WriteLine("6. Visa Aktiva kurser");
    Console.WriteLine("7. Avsluta programmet");
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
            StudentInfo.showinfo();
            break;
        case "4":
            Console.Clear();
            AddEmployee.AddNewEmplyoee();
            break;
        case "5":
            Console.Clear();
            SortEmployee.ShowTeachers();
            break;
        case "6":
            Console.Clear();
            ActiveCourses.GetCourses();
            break;
        case "7":
            Console.WriteLine("Avslutar programmet...");
            return;
        default:
            Console.WriteLine("Ogiltigt val, försök igen.");
            break;
    }
}
    
