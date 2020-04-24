using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flowers.ViewModels
{
    public class WarehouseFlowerViewModel
    {
        public int PlantationId { get; set; }
        public int FlowerId { get; set; }
        public int Amount { get; set; }

        public List<SelectListItem> Plantations { get; set; }
        public List<SelectListItem> Flowers { get; set; }
    }
}
