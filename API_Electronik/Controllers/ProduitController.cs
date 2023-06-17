using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_Electronik.Models;

namespace API_Electronik.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduitController : ControllerBase
    {
        private readonly ILogger<ProduitController> logger;
        private List<Produit> _produits;

        public ProduitController(ILogger<ProduitController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public List<Produit> Get()
        {
            _produits = new List<Produit>();
            _produits.Add(new Produit { ImageUrl = "C:\\Users\\f\\Desktop\\API_Electronik\\Images\\Relais.jpg", ProductName="Relai", Quantity=20, Brands="Fed technology"});
            _produits.Add(new Produit { ImageUrl = "C:\\Users\\f\\Desktop\\API_Electronik\\Images\\led.jpeg", ProductName = "Led", Quantity = 35, Brands = "Fed technology" });
            _produits.Add(new Produit { ImageUrl = "C:\\Users\\f\\Desktop\\API_Electronik\\Images\\Condensateur.jpg", ProductName="Condensateur plat", Quantity=2, Brands= "Fed technology" });
            _produits.Add(new Produit { ImageUrl = "C:\\Users\\f\\Desktop\\API_Electronik\\Images\\pil.jpg", ProductName="Condensateur", Quantity=7, Brands= "Fed technology" });
            _produits.Add(new Produit { ImageUrl = "C:\\Users\\f\\Desktop\\API_Electronik\\Images\\pic.jpg", ProductName="PIC", Quantity=56, Brands= "Fed technology" });
            _produits.Add(new Produit { ImageUrl = "C:\\Users\\f\\Desktop\\API_Electronik\\Images\\res1.jpg", ProductName="Résistance", Quantity=104, Brands= "Fed technology" });
            _produits.Add(new Produit { ImageUrl = "C:\\Users\\f\\Desktop\\API_Electronik\\Images\\arduino.jpg", ProductName="Carte Arduino", Quantity=35, Brands= "Fed technology" });
            _produits.Add(new Produit { ImageUrl = "C:\\Users\\f\\Desktop\\API_Electronik\\Images\\Esp32.jpg", ProductName = "ESP 32", Quantity = 01, Brands = "Fed technology" });
            _produits.Add(new Produit { ImageUrl = "C:\\Users\\f\\Desktop\\API_Electronik\\Images\\EspCam.jpg", ProductName = "ESP 32 CAM", Quantity = 35, Brands = "Fed technology" });
            _produits.Add(new Produit { ImageUrl = "C:\\Users\\f\\Desktop\\API_Electronik\\Images\\pcb.jpg", ProductName = "PCB", Quantity = 69, Brands = "Fed technology" });
            _produits.Add(new Produit { ImageUrl = "C:\\Users\\f\\Desktop\\API_Electronik\\Images\\Potentiometre.jpg", ProductName = "Potentiomètre", Quantity = 68, Brands = "Fed technology" });
            _produits.Add(new Produit { ImageUrl = "C:\\Users\\f\\Desktop\\API_Electronik\\Images\\Buzzer.jpg", ProductName = "Buzzer", Quantity = 35, Brands = "Fed technology" });
            _produits.Add(new Produit { ImageUrl = "C:\\Users\\f\\Desktop\\API_Electronik\\Images\\Composant.jpg", ProductName = "Composants", Quantity = 50, Brands = "Fed technology" });
            _produits.Add(new Produit { ImageUrl = "C:\\Users\\f\\Desktop\\API_Electronik\\Images\\LCD.jpg", ProductName = "LCD", Quantity = 100, Brands = "Fed technology" });


            return _produits;
        }
    }
}
