using Microsoft.EntityFrameworkCore;
using SkolaDB_Database_Labb3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaDB_Database_Labb3.Models
{
    internal class ActiveCourses
    {
        public static void GetCourses()
        {
            using (var context = new SkolaDbContext())
            {
                var Courses = context.Kursers
                    .Where //vet inte riktigt vad den gör :)
                    (k => k.KursId >= 0) 
                    .OrderBy // sortera efter PK/ID
                    (k => k.KursId)
                    .ToList(); // skapar list
                Console.Clear();
                Console.WriteLine("ID - Namn");
                                                         //utskrift och går igenom list
                foreach (var course in Courses)
                {
                    Console.WriteLine($"{course.KursId}    {course.KursN}");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
