using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    public class GenresController : Controller
    {
        public IActionResult Index()
        {
            List<Genre> generes = new List<Genre>
            {
                new Genre
                {
                    Id = 1,
                    Name = "Romance"
                },
                new Genre
                {
                    Id = 2,
                    Name = "Ficção Cientifica"
                },
                new Genre
                {
                    Id= 3,
                    Name = "Comedia"
                }
            };
            return View(generes);
        }
    }
}
