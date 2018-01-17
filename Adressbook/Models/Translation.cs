using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adressbook.Models
{
    public class Translation
    {
        public int TranslationID { get; set; }
        public string CultureCode { get; set; }
        public string Term { get; set; }
        public string TranslatedTerm { get; set; }
    }
}
