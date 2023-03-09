using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace zoo_m.Models
{
    public class PetModel
    {
        [Key]
        public int PetId { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string Name { get; set; }
    }
}
