namespace Flowers.Models
{
    public class SupplyFlower : IEntity
    {
        public int Id { get; set; }
        public int FlowerId { get; set; }
        public int SupplyId { get; set; }

        public int Amount { get; set; }
    }
}
