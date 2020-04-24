using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Flowers.ViewModels
{
    public class SupplyFlowerViewModel
    {
        public int PlantationId { get; set; }
        public int FlowerId { get; set; }
        public int Amount { get; set; }

        public List<SelectListItem> Plantations { get; set; }
        public List<SelectListItem> Flowers { get; set; }
    }
}
