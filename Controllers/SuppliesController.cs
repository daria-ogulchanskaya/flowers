using Flowers.Models;
using Flowers.Repositories;
using Flowers.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Flowers.Controllers
{
    public class SuppliesController : Controller
    {
        private readonly IRepository<Supply> _supplies;
        private readonly IRepository<Plantation> _plantations;
        private readonly IRepository<Warehouse> _warehouses;

        public SuppliesController(
            IRepository<Supply> supplies, 
            IRepository<Warehouse> warehouses, 
            IRepository<Plantation> plantations
            )
        {
            _supplies = supplies;
            _warehouses = warehouses;
            _plantations = plantations;
        }

        [HttpGet]
        public IActionResult All() =>
            View(_supplies.All());

        [HttpGet]
        public IActionResult Get(string id)
        {
            var supply = _supplies.Get(Convert.ToInt32(id));

            return View(supply);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var supply = new AddSupplyViewModel
            {
                Plantations = Plantations(),
                Warehouses = Warehouses()
            };

            return View(supply);
        }

        [HttpPost]
        public IActionResult Add(AddSupplyViewModel vm)
        {
            var supply = new Supply
            {
                Id = vm.Id,
                PlantationId = vm.PlantationId,
                WarehouseId = vm.WarehouseId,
                ScheduledDate = vm.ScheduledDate,
                ClosedDate = vm.ClosedDate,
                Status = vm.Status
            };

            _supplies.Add(supply);

            return RedirectToAction(nameof(All));
        }

        public IActionResult Remove(string value)
        {
            var id = Convert.ToInt32(value);

            _supplies.Remove(id);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public IActionResult Update(string id)
        {
            var supply = new UpdateSupplyViewModel
            {
                Id = Convert.ToInt32(id),
                Plantations = Plantations(),
                Warehouses = Warehouses()
            };

            return View(supply);
        }

        [HttpPost]
        public IActionResult Update(UpdateSupplyViewModel vm)
        {
            var supply = new Supply
            {
                Id = vm.Id,
                PlantationId = vm.PlantationId,
                WarehouseId = vm.WarehouseId,
                ScheduledDate = vm.ScheduledDate,
                ClosedDate = vm.ClosedDate,
                Status = vm.Status
            };

            _supplies.Update(supply);

            return RedirectToAction(nameof(All));
        }

        private List<SelectListItem> Plantations()
        {
            var items = new List<SelectListItem>();

            foreach (var plantation in _plantations.All())
                items.Add(new SelectListItem { Text = plantation.Name, Value = plantation.Id.ToString() });

            return items;
        }

        private List<SelectListItem> Warehouses()
        {
            var items = new List<SelectListItem>();

            foreach (var warehouse in _warehouses.All())
                items.Add(new SelectListItem { Text = warehouse.Name, Value = warehouse.Id.ToString() });

            return items;
        }
    }
}
