using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Sneakers_shop.Models;
using Sneakers_shop.Services;

namespace Sneakers_shop.Controllers
{
    public class ButyController : Controller
    {
        private readonly IButyService _butyService;
        public ButyController(AppDbContext context, IButyService postService)
        {
            _butyService = postService;
        }

        public IActionResult Index()
        {
            return View(_butyService.FindAll());
        }

        //Dodawanie 

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add([FromForm] Buty buty)
        {
            if (ModelState.IsValid)
            {
                _butyService.Save(buty);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }
    }
}
