using Microsoft.AspNetCore.Mvc;
using Sneakers_shop.Models;

namespace Sneakers_shop.Controllers
{
    public class ProdukcjaButowController : Controller
    {
        private static AppDbContext context = new AppDbContext();

        public static List<ProdukcjaButow_Model> lista = context.produkcjaButow_Models.ToList();

        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////

        public IActionResult Index()
        {
            return View(lista);
        }


        ////////////////////////////////////////////////////////////////////////////////////////
        //Dodawanie 


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Add([FromForm] ProdukcjaButow_Model produkcjaButow_Model)
        {
            produkcjaButow_Model.Prod_Marka = "Adidas";
            produkcjaButow_Model.Prod_Model = "Superstar";
            produkcjaButow_Model.Prod_Rodzaj = Erodzaj.Klasyczne;
            produkcjaButow_Model.Prod_Kolor = Ekolor.Białe;
            produkcjaButow_Model.Prod_Cena = 400;



            context.produkcjaButow_Models.Add(produkcjaButow_Model);
            context.SaveChanges();

            lista = context.produkcjaButow_Models.ToList(); //zapisujemy w liste
            return View("index", lista); // i wysyłamy w action 'index' naszą liste.
        }



    }
}
