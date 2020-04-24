using Flowers.Models;
using Flowers.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Flowers.Controllers
{
    public class PlantationsController : Controller
    {
        private readonly IRepository<Plantation> _plantations;

        public PlantationsController(IRepository<Plantation> plantations) =>
            _plantations = plantations;

        [HttpGet] 
        public IActionResult All() =>
            View(_plantations.All());

        [HttpGet]
        public IActionResult Get(string id)
        {
            var plantation = _plantations.Get(Convert.ToInt32(id));

            return View(plantation);
        }

        [HttpGet]
        public IActionResult Add() =>
            View();

        [HttpPost]
        public IActionResult Add(Plantation model)
        {
            _plantations.Add(model);

            return RedirectToAction(nameof(All));
        }

        public IActionResult Remove(string value)
        {
            var id = Convert.ToInt32(value);

            _plantations.Remove(id);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public IActionResult Update(string id)
        {
            var plantation = _plantations.Get(Convert.ToInt32(id));

            return View(plantation);
        }

        [HttpPost]
        public IActionResult Update(Plantation model)
        {
            _plantations.Update(model);

            return RedirectToAction(nameof(All));
        }

        //public IActionResult AddFlower()
        //{

        //}
    }
}
