using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginUser.Models
{
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string Correo { get; set; } = string.Empty;

        [Required, StringLength(255)]
        public string Password_Hash { get; set; } = string.Empty;

        [Required]
        [Column("rol_id")]
        public int RolId { get; set; }
    }
}
