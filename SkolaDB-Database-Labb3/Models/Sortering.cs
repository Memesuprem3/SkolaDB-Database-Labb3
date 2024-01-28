using SkolaDB_Database_Labb3.Data;
using SkolaDB_Database_Labb3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaDB_Database_Labb3.Models
{
    internal class Sortering 
    {
        public void Sort()
        {
            Console.WriteLine("Välj sortering: Ange '1' för förnamn, '2' för efternamn.");
            string sortChoice = Console.ReadLine();
            string sortColumn = sortChoice == "1" ? "FirstName" : "LastName";

            Console.WriteLine("Välj ordning: Ange '1' för stigande, '2' för fallande.");
            string orderChoice = Console.ReadLine();
            bool ascending = orderChoice == "1";
            Console.Clear();
            using (var context = new SkolaDbContext())
            {
                var query = context.Studenters.AsQueryable();

                query = sortColumn == "FirstName" ?
                        ascending ? query.OrderBy(s => s.FirstName) : query.OrderByDescending(s => s.FirstName) :
                        ascending ? query.OrderBy(s => s.LastName) : query.OrderByDescending(s => s.LastName);

                foreach (var s in query)
                {
                    Console.WriteLine($"ID: {s.StudentId}, Namn: {s.FirstName} {s.LastName}");
                    
                }

            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}


