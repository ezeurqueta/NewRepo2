using System.ComponentModel.DataAnnotations;
using WebApiAutores.Validaciones;

namespace WebApiAutores.DTOs
{
    public class LibroCreacionDTO
    {
        [PrimeraLetraMayuscula]
        [StringLength(maximumLength: 250, ErrorMessage = "El campo {0} no debe tener mas de {1} caracteres")]
        public string Titulo { get; set; }
        public DateTime fechaPublicacion { get; set; }
        public List<int> AutoresId { get; set; }
    }
}
