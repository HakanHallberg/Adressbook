using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Adressbook.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        [Display(Name ="First name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name ="Last name")]
        [Required ]
        public string LastName { get; set; }
        [Display(Name = "Adress")]
        [Required]
        public int AdressID { get; set; }

    }
}
