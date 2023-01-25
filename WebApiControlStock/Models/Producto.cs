using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiControlStock.Validations;

namespace WebApiControlStock.Models
{
    [Table("Producto")]
    public class Producto
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="varchar(50)")]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName ="char(1)")]
        [ProductoSoloHyS]
        public string LineaProducto { get; set; }
        [Column(TypeName = "money")]
        [PrecioMayorCero]
        public decimal Precio { get; set; }
        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }
    }
}
