namespace Restaurant_Management_System.Entities
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<Inventory> Inventory { get; set; }
    }
}
