using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginUser.Models.Entities
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
        [Column("Password_Hash")]
        public string Password { get; set; } = string.Empty;

        [Required]
        [Column("rol_id")]
        public int RolId { get; set; }
    }
}
