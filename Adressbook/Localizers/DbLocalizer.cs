using Adressbook.Controllers;
using Adressbook.Data;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Adressbook.Localizers
{
    public class DbLocalizer : IStringLocalizer<HomeController>
    {
        private readonly ApplicationDbContext context;

        public DbLocalizer(ApplicationDbContext context)
        {
            this.context = context;
        }

        public LocalizedString this[string name]
        {
            get
            {
                var item = context.Translations.Single(t => t.Term == name);
                return new LocalizedString(name, item.TranslatedTerm);
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
