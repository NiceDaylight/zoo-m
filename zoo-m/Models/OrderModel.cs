namespace zoo_m.Models
{
    public class OrderModel
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public UserModel User { get; set; }
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }
        public bool Confirm { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int Amount { get; set; }
        public int Cost { get; set; }
    }
}
