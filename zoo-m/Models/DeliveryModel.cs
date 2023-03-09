using System.Globalization;

namespace zoo_m.Models
{
    public class DeliveryModel
    {
        public int OrderId { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public bool Confirmation { get; set; }
    }
}
