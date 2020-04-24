using System;

namespace Flowers.Models
{
    public class Supply : IEntity
    {
        public int Id { get; set; }
        public int PlantationId { get; set; }
        public int WarehouseId { get; set; }

        public DateTime ScheduledDate { get; set; }
        public DateTime ClosedDate { get; set; }

        public Status Status { get; set; }
    }
}
