using Flowers.Models;
using Flowers.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Flowers.Controllers
{
    public class WarehousesController : Controller
    {
        private readonly IRepository<Warehouse> _warehouses;

        public WarehousesController(IRepository<Warehouse> warehouses) =>
            _warehouses = warehouses;

        [HttpGet]
        public IActionResult All() =>
            View(_warehouses.All());

        [HttpGet]
        public IActionResult Get(string id)
        {
            var warehouse = _warehouses.Get(Convert.ToInt32(id));

            return View(warehouse);
        }

        [HttpGet]
        public IActionResult Add() =>
            View();
            
        [HttpPost]
        public IActionResult Add(Warehouse model)
        {
            _warehouses.Add(model);

            return RedirectToAction(nameof(All));
        }

        public IActionResult Remove(string value)
        {
            var id = Convert.ToInt32(value);

            _warehouses.Remove(id);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public IActionResult Update(string id)
        {
            var warehouse = _warehouses.Get(Convert.ToInt32(id));

            return View(warehouse);
        }

        [HttpPost]
        public IActionResult Update(Warehouse model)
        {
            _warehouses.Update(model);

            return RedirectToAction(nameof(All));
        }



        //public IActionResult AddFlower()
        //{

        //}
    }
}
