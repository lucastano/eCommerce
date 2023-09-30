using eCommerce.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.LogicaNegocio.IRepositorios
{
    public interface IProductoRepositorio:IRepositorio<Producto>
    {
        //aca van a ir los propios de producto, por el momento solo vamos a usar el crud
    }
}
