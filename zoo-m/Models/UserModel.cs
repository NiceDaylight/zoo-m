using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace zoo_m.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string UserName { get; set; }
        [Column(TypeName = "nvarchar(60)")]
        [Key]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Password { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(11)")]
        public string Phone { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Type { get; set; }
    }
}
