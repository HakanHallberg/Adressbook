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
        [Required]
        public string AdressName { get; set; }
    }
}
