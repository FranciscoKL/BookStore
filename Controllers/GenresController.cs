using Bookstore.Data;
using Bookstore.Models;
using Bookstore.Models.ViewModels;
using Bookstore.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bookstore.Controllers
{
    public class GenresController : Controller
    {
        private readonly GenreService _service;

        public GenresController(GenreService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {           
            return View(await _service.FindAllAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Genre genre) 
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _service.InsertAsync(genre);

            return RedirectToAction(nameof(Index));
        }

        


        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}
