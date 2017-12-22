using Adressbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adressbook.Data
{
    public class DbSeed
    {
        public static void Seed(ApplicationDbContext context)
        {
            var John = new Person { FirstName = "John", LastName = "Smith" };
            context.People.Add(John);
            var Sara = new Person { FirstName = "Sara", LastName = "Johnson" };
            context.People.Add(Sara);
            var Mickey = new Person { FirstName = "Mickey", LastName = "Mouse" };
            context.People.Add(Mickey);
            context.SaveChanges();

            var Adress1 = new Adress { AdressName = "Namngatan 12", PersonID = 0 };
            context.Adresses.Add(Adress1);
            var Vägen2 = new Adress { AdressName = "Gatvägen 5", PersonID = 1 };
            context.Adresses.Add(Vägen2);
            var Gatan = new Adress { AdressName = "Väggatan 13", PersonID = 2 };
            context.Adresses.Add(Gatan);
            context.SaveChanges();

            

            
        }
    }
}
