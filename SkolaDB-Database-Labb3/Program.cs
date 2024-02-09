using SkolaDB_Database_Labb3.Data;
using SkolaDB_Database_Labb3.Models;

using SkolaDbContext context = new SkolaDbContext();

static void WriteCenteredLine(string text)
{
    int screenWidth = Console.WindowWidth;
    int stringWidth = text.Length;
    int spaces = (screenWidth / 2) + (stringWidth / 2);

    Console.WriteLine(text.PadLeft(spaces));
}

while (true)
{

    Console.Clear();
    WriteCenteredLine("================== Välkommen till Skolans Administrationsprogram ==================");
    WriteCenteredLine("1. Visa och sortera elever");
    WriteCenteredLine("2. Visa elever i en specifik klass");
    WriteCenteredLine("3. Visa information om elever");
    WriteCenteredLine("4. Lägg till ny personal");
    WriteCenteredLine("5. Visa alla lärare");
    WriteCenteredLine("6. Visa aktiva kurser");
    WriteCenteredLine("7. Avsluta programmet");
    WriteCenteredLine("===================================================================================");
    WriteCenteredLine("Välj ett alternativ (1-7): ");

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
    
