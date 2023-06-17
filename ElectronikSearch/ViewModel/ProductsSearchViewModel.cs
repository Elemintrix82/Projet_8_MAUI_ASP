using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronikSearch.ViewModel
{
    public partial class ProductsSearchViewModel : BaseViewModel
    {
        public ObservableCollection<string> SearchTermsHistory { get; } = new();

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsSearchTermsHistoryNotEmpty))]
        bool isSearchTermsHistoryEmpty = true;

        bool IsSearchTermsHistoryNotEmpty => !isSearchTermsHistoryEmpty;

        public ProductsSearchViewModel() 
        {
            Title = "Rechercher";

        }
    }
}
