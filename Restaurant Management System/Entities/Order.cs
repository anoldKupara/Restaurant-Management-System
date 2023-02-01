namespace Restaurant_Management_System.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int MenuId { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public int UserId { get; set; }

        public Customer Customer { get; set; }
        public Menu Menu { get; set; }
        public Bill Bill { get; set; }
        public User User { get; set; }
    }
}
