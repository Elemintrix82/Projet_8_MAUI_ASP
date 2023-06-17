
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronikSearch.ViewModel
{
    public partial class ProductsViewModel : BaseViewModel
    {
        ProductService productService;

        [ObservableProperty]
        bool isRefreshing;

        public ObservableCollection<Produit> Products { get; set; } = new();

        public bool FirstRun { get; set; } = true;

        public ProductsViewModel(ProductService productService) 
        {
            Title = "Produits";
            this.productService = productService;
        }

        [RelayCommand]
        async Task GetRandomProductsAsync()
        {
            if (IsBusy) return;

            try
            {
                IsBusy = true;

                var products = await productService.GetRandomProductsAsync();

                Products.Clear();

                foreach (var product in products)
                {
                    Products.Add(product);
                }
            }
            catch(Exception)
            {
                await Shell.Current.DisplayAlert("Erreur", "Impossible de récupérer la liste des produits.", "Ok");
            }
            finally
            {
                IsBusy = false;
                IsRefreshing = false;
            }
        }
       
        [RelayCommand]
        async Task GoToDetailsAsync(Produit product)
        {
            if (product is null)
                return;

            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true, new Dictionary<string, object>
        {
            { "Product", product }
        });
        }
    }
}
