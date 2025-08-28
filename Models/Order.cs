namespace ERPSystem.Models
{
    public class Order :BaseEntity<int>
    {
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }

        // shipping ??
    }
}
