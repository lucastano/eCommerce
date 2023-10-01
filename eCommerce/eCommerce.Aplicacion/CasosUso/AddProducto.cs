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
    public class AddProducto : IAddProducto
    {
        private readonly IProductoRepositorio _repositorio;

        public AddProducto(IProductoRepositorio _repositorio)
        {
            this._repositorio = _repositorio;

        }
        public void Ejecutar(Producto entidad)
        {
            if (entidad == null) throw new Exception("No se puede agegar ");
            _repositorio.create(entidad);
        }
    }
}
