using eCommerce.API.DTO_S;
using eCommerce.Aplicacion.ICasosUso;
using eCommerce.LogicaNegocio.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IAddProducto ucAddProducto;
        private readonly IGetAllProductos ucGetAllProductos;
        private readonly IGetCategoria ucGetCategoria;

        public ProductosController(IAddProducto ucAddProducto, IGetAllProductos ucGetAllProductos, IGetCategoria ucGetCategoria)
        {
            this.ucAddProducto = ucAddProducto;
            this.ucGetAllProductos = ucGetAllProductos;
            this.ucGetCategoria = ucGetCategoria;
        }

        [HttpPost]
        public IActionResult add(addProductDTO dto) 
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(); }
                Producto prod = new Producto
                {
                    Nombre = dto.Nombre,
                    EAN = dto.EAN,
                    Categoria = ucGetCategoria.Ejecutar(dto.IdCategoria),

                };
                ucAddProducto.Ejecutar(prod);
                return Ok();


            }
            catch(Exception ex)
            {
                return StatusCode(500,ex.Message);
            }
        
        }

        [HttpGet]

        public IEnumerable<ProductoDTO> getAll() 
        {
            var productos=ucGetAllProductos.Ejecutar();
            return productos.Select(p => new ProductoDTO
            {
                Nombre = p.Nombre,
                EAN = p.EAN,
                Categoria = new CategoriaDTO
                {
                    Id = p.Categoria.Id,
                    Nombre = p.Categoria.Nombre,
                    Descripcion = p.Categoria.Descripcion
                }
            });
        
        }
    }
}
