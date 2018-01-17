using Adressbook.Controllers;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Adressbook.Localizers
{
    public class HomeStringLocalizer : IStringLocalizer<HomeController>
    {
        public LocalizedString this[string name]
        {
            get
            {
                return new LocalizedString(name, "." + name + ".");
            }
        }

        public LocalizedString this[string name, params object[] arguments] => throw new NotImplementedException();

        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
        {
            throw new NotImplementedException();
        }

        public IStringLocalizer WithCulture(CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
