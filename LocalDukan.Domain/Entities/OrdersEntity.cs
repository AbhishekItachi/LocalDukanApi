
namespace LocalDukan.Domain.Entities
{
    public class OrdersEntity
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Tag { get; set; }
        public string Slot { get; set; }
        public decimal Total { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
