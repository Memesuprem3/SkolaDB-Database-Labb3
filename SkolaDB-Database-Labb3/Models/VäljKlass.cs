using SkolaDB_Database_Labb3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaDB_Database_Labb3.Models
{
    internal class VäljKlass
    {

        public void Välj()
        {
            using (var context = new SkolaDbContext())
            {
                while (true)
                {
                    
                    Console.WriteLine("\nTillgängliga klasser:");
                    var klasser = context.Klassers.ToList();
                    foreach (var k in klasser)
                    {
                        Console.WriteLine($"Klass ID: {k.KlassId}, Namn: {k.KlassN}");
                    }

                    Console.WriteLine("Välj en klass genom att ange dess ID (eller ange '0' för att gå tillbaka):");
                    int klassId = Convert.ToInt32(Console.ReadLine());

                    //Loop för att hänga kvar
                    if (klassId == 0)
                    {
                        Console.Clear();
                        break;
                        
                    }
                    Console.Clear();
                    
                    var elever = context.Studenters
                                        .Where(s => s.KlassId == klassId)
                                        .ToList();

                    Console.WriteLine($"\nElever i klass {klassId}:");
                    foreach (var elev in elever)
                    {
                        Console.WriteLine($"Elev ID: {elev.StudentId}, Namn: {elev.FirstName} {elev.LastName}");
                    }
                    Console.WriteLine(new string('-', 35));
                    Console.WriteLine("tryck på valfri tangent för att fortsätta");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
