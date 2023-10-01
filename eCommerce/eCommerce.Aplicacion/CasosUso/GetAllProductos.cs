using eCommerce.Aplicacion.ICasosUso;
using eCommerce.LogicaNegocio.Entidades;
using eCommerce.LogicaNegocio.IRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Aplicacion.CasosUso
{
    public class GetAllProductos : IGetAllProductos
    {
        private readonly IProductoRepositorio _repositorio;

        public GetAllProductos(IProductoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public IEnumerable<Producto> Ejecutar()
        {
            return _repositorio.getAll();
        }
    }
}
