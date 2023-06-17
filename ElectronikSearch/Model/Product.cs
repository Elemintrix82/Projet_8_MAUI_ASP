using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ElectronikSearch.Model
{
    public class Product
    {
        public string Code { get; set; }

        public string Url { get; set; }

        [JsonPropertyName("product_name")]
        public string ProductName { get; set; }

        public string GenericName { get; set; }

        public string Quantity { get; set; }

        [JsonPropertyName("ingredients_text")]
        public string IngredientsText { get; set; }

        public string Brands { get; set; }

        [JsonPropertyName("nutriscore_grade")]
        public string NustriscoreGrade { get; set; }          

        public string NustriscoreGradeImage
        {
            get => $"nutriscore_{NustriscoreGrade}.png";
        }

        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }
    }
}
