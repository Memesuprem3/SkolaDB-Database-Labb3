using SkolaDB_Database_Labb3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaDB_Database_Labb3.Models
{
    internal class AddPersonal
    {

        public void LäggTillNyPersonal()
        {
            Console.WriteLine("Ange för och efternamn:");
            string förnamn = Console.ReadLine();

            Console.WriteLine("Ange Personnummer:");
            string Pn = Console.ReadLine();

            Console.WriteLine("Ange Tjänst:");
            string Tjänst = Console.ReadLine();

            //Personal info läggs till 
            var nyPersonal = new Personal
            {
                Namn = förnamn,
                 Pn = Pn,
                 Tjänst = Tjänst
                
            };
            //lagras i databas
            using (var context = new SkolaDbContext())
            {
                context.Personals.Add(nyPersonal);
                context.SaveChanges();
            }

            Console.WriteLine("Ny Medarbetare har lagts till i Personaldatabasen.");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
