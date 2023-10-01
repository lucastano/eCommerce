using eCommerce.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Aplicacion.ICasosUso
{
    public interface IGetAllProductos
    {
        IEnumerable<Producto> Ejecutar();
    }
}
