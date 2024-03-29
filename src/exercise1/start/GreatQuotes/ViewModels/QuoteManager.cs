﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GreatQuotes.ViewModels
{
    public class QuoteManager
    {
        private IQuoteLoader loader;
        static readonly Lazy<QuoteManager> instance = new Lazy<QuoteManager>(() => new QuoteManager());
        public static QuoteManager Instance { get => instance.Value; }
        public IList<GreatQuoteViewModel> Quotes { get; set; }
        private QuoteManager()
        {
            loader = QuoteLoaderFactory.Create();
            Quotes = new ObservableCollection<GreatQuoteViewModel>(loader.Load());
        }
        public void Save()
        {
            loader.Save(Quotes);
        }
    }
}
