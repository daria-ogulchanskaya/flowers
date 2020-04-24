using Flowers.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Flowers.ViewModels
{
    public class UpdateSupplyViewModel
    {
        public int Id { get; set; }

        public int PlantationId { get; set; }
        public int WarehouseId { get; set; }

        public DateTime ScheduledDate { get; set; }
        public DateTime ClosedDate { get; set; }

        public Status Status { get; set; }

        public List<SelectListItem> Plantations { get; set; }
        public List<SelectListItem> Warehouses { get; set; }
    }
}
