using Microsoft.EntityFrameworkCore;
using SkolaDB_Database_Labb3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaDB_Database_Labb3.Models
{


    internal class SortEmployee
    {
        public static void ShowTeachers()
        {
            Console.Clear();

            using (var context = new SkolaDbContext())
            {

                // kurs = avdeling säger vi
                var lärarePerAvdelning = context.Kursers
                    .Include
                    (k => k.Lärare)
                    .GroupBy
                    (k => k.KursN) // Gruppera kurser baserat på kursnamn, som då representerar avdelningen
                    .Select
                    (g => new
                    {
                        Avdelning = g.Key,
                        AntalLärare = g.Select(k => k.LärareId).Distinct().Count() // Räkna unika lärare per avdelning
                    })
                     .ToList();
                // gå igenom för utskrift
                foreach (var avdelning in lärarePerAvdelning)
                {
                    Console.WriteLine($"Avdelning: {avdelning.Avdelning}, Antal Lärare: {avdelning.AntalLärare}");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
