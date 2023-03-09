using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace zoo_m.Models
{
    public class CategoryModel
    {
        [Key]
        public int CategoryId { get; set; }
        public int PetId { get; set; }
        public PetModel Pet { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string CategoryName { get; set; }
    }
}
