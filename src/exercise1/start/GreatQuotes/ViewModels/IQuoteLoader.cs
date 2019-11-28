using System;
using System.Collections.Generic;
using System.Text;

namespace GreatQuotes.ViewModels
{
    public interface IQuoteLoader
    {
        IEnumerable<GreatQuoteViewModel> Load();
        void Save(IEnumerable<GreatQuoteViewModel> quotes);
    }
}
