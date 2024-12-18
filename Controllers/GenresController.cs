﻿using Bookstore.Data;
using Bookstore.Models;
using Bookstore.Service;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    public class GenresController : Controller
    {
        private readonly GenreService _service;

        public GenresController(GenreService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {           
            return View(_service.FindAll());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Genre genre) 
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _service.Insert(genre);

            return RedirectToAction(nameof(Index));
        }
    }
}
