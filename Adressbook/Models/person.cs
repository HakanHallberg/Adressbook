using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Adressbook.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        [Required]
        public string FirstName { get; set; }
        
        [Required ]
        public string LastName { get; set; }
        
    }
}
