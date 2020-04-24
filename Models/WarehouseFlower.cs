namespace Flowers.Models
{
    public class WarehouseFlower
    {
        public int Id { get; set; }
        public int FlowerId { get; set; }
        public int WarehouseId { get; set; }

        public int Amount { get; set; }
    }
}
