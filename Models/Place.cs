namespace Flowers.Models
{
    public abstract class Place : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
    }
}
