using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace zoo_m.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }
        public int PetId { get; set; }
        public PetModel Pet { get; set; }
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Brand { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Description { get; set; }
        [Column(TypeName = "bit")]
        public int Presence { get; set; }
        public int Price { get; set; }
    }
}
