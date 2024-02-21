using System.ComponentModel.DataAnnotations;

namespace Parcial1_Ap1_VladimirGuzman.Models
{
    public class Metas
    {
        [Key]
        public int MetaId { get; set; }
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage ="Debes espesificar cual es tu menta")]
        public string? Descripcion { get; set; }
        [Required(ErrorMessage ="Desbes ingresar el monto")]
        [Range(1, int.MaxValue, ErrorMessage ="No puede ser un monto Menor que 0")]
        public float Monto { get; set; }
    }
}
