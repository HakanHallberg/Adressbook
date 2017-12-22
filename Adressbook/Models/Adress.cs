using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Adressbook.Models
{
    public class Adress
    {
        public int AdressID { get; set; }
        [Display(Name = "Adress")]
        [Required]
        public string AdressName { get; set; }
        public int PersonID { get; set; }
        public Person Person { get; set; }

    }
}
