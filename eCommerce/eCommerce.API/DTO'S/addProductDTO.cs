using eCommerce.LogicaNegocio.Entidades;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.API
{
    public class addProductDTO
    {
        [Required]
        [Display(Name ="Nombre de Producto")]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Codigo EAN de producto")]
        public string EAN { get; set; }
        [Required]
        [Display(Name = "Categoria del producto")]
        public int IdCategoria { get; set; }
    }
}
