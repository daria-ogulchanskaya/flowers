using Flowers.Models;
using Flowers.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Flowers.Controllers
{
    public class FlowersController : Controller
    {
        private readonly IRepository<Flower> _flowers;

        public FlowersController(IRepository<Flower> flowers) =>
            _flowers = flowers;

        [HttpGet]
        public IActionResult All() =>
            View(_flowers.All());

        [HttpGet]
        public IActionResult Get(string id)
        {
            var flower = _flowers.Get(Convert.ToInt32(id));

            return View(flower);
        }

        [HttpGet]
        public IActionResult Add() =>
            View();

        [HttpPost]
        public IActionResult Add(Flower model)
        {
            _flowers.Add(model);

            return RedirectToAction(nameof(All));
        }

        public IActionResult Remove(string value)
        {
            var id = Convert.ToInt32(value);

            _flowers.Remove(id);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public IActionResult Update(string id)
        {
            var flower = _flowers.Get(Convert.ToInt32(id));

            return View(flower);
        }

        [HttpPost]
        public IActionResult Update(Flower model)
        {
            _flowers.Update(model);

            return RedirectToAction(nameof(All));
        }
    }
}
