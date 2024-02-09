using Microsoft.EntityFrameworkCore;
using SkolaDB_Database_Labb3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaDB_Database_Labb3.Models
{
    internal class StudentInfo
    {
      

        public static void showinfo()
        {

            using (var context = new SkolaDbContext())
            {
                var Students = context.Studenters
                .Include(s => s.Klass)
                .OrderBy(s => s.Klass.KlassN) // Sorterar elever efter klassnamn
                .ThenBy(s => s.LastName) // Sedan efter elevens efternamn
                .ThenBy(s => s.FirstName) // 
                .Select(s => new
                {

                    StudentFName = $"{s.FirstName}",
                    StudentLName = $"{s.LastName}",
                    StudentClass = s.Klass.KlassN,
                    StudenPN = s.Pn

                })
                .ToList();

                if (!Students.Any()) //ifall databas töms
                {
                    Console.WriteLine("Inga elever hittades.");
                    return;
                }
                /* oklart varför det krångar i konsolen med att det inte blir helt 
                  centererat utan att behöva ändra en jävla massa med tecken och skit */
                
                Console.WriteLine($"{"Namn",-30} {"Efternamn"} {"Klass",45} {"Personnummer",19}"); // psykos för att få det centrerat
                Console.WriteLine(new string('-', 100)); // Skapar en skiljelinje
              
                foreach (var Student in Students)
                {
                    Console.WriteLine($"{Student.StudentFName,-30} {Student.StudentLName,-30} {Student.StudentClass,-10}  {Student.StudenPN,-50}");
                }
            }
            Console.ReadKey();
            Console.Clear();

        }
    }

}   

