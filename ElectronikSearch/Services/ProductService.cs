using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ElectronikSearch.Services
{
    public class ProductService
    {
        const string BASE_SEARCH_URL = "https://localhost:7016/api/Produit";

        HttpClient client;

        public ProductService() 
        {
            client = new HttpClient();
        }

        public async Task<List<Produit>> GetRandomProductsAsync()
        {
            var page = new Random().Next(1, 1000);

            //var url = $"{BASE_SEARCH_URL}";

            var response = await client.GetAsync("https://localhost:7016/api/Produit");

            var products = await GetProductsAsync(response);
            foreach (Produit p in products)
            {
                Console.WriteLine("PRODUITTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT");

                Console.WriteLine(p);
            }


            return products;
        }

        private async Task<List<Produit>> GetProductsAsync(HttpResponseMessage response)
        {
            List<Produit> products = new();

            if(response.IsSuccessStatusCode)
            {
                //products = (await response.Content.ReadFromJsonAsync<ProductsResult>()).Products;
                products = await response.Content.ReadFromJsonAsync<List<Produit>>();
            }

            foreach (Produit p in products)
            {
                Console.WriteLine("PRODUITTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT");
                Console.WriteLine(p);
            }

            return products ;
        }
    }
}
