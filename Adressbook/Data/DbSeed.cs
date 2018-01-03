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
            var John = new Person { FirstName = "John@BlaH", LastName = "Smith" };
            context.People.Add(John);
            var Sara = new Person { FirstName = "Sara", LastName = "Johnson" };
            context.People.Add(Sara);
            var Mickey = new Person { FirstName = "Mickey", LastName = "Mouse" };
            context.People.Add(Mickey);
            context.SaveChanges();

            var Adress1 = new Adress { AdressName = "Namngatan 12", Person = John };
            context.Adresses.Add(Adress1);
            var Vägen2 = new Adress { AdressName = "Gatvägen 5", Person = Sara };
            context.Adresses.Add(Vägen2);
            var Gatan = new Adress { AdressName = "Väggatan@13", Person = Mickey };
            context.Adresses.Add(Gatan);
            context.SaveChanges();

            

            
        }
    }
}
