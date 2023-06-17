using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronikSearch.ViewModel
{
    [QueryProperty("Product", "Product")]

    public partial class ProductDetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        Produit product;
        [RelayCommand]
        async Task OpenProductAsync(Produit product)
        {
            if (product is null)
                return;

            try
            {
                Uri uri = new(product.ProductName);
                await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception)
            {
                await Shell.Current.DisplayAlert("Erreur", "impossible d'ouvrir le navigateur", "OK");
            }
        }
    }
}
