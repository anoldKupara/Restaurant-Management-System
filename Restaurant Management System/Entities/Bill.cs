namespace Restaurant_Management_System.Entities
{
    public class Bill
    {
        public int BillId { get; set; }
        public int OrderId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
        public DateTime Date { get; set; }

        public Order Order { get; set; }
    }
}
