namespace Restaurant_Management_System.Entities
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int ReorderLevel { get; set; }
        public int MenuId { get; set; }

        public Menu Menu { get; set; }
    }
}
