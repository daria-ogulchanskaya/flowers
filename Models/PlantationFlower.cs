namespace Flowers.Models
{
    public class PlantationFlower : IEntity
    {
        public int Id { get; set; }
        public int FlowerId { get; set; }
        public int PlantationId { get; set; }

        public int Amount { get; set; }
    }
}
