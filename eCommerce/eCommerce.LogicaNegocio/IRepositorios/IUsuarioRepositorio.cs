using eCommerce.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.LogicaNegocio.IRepositorios
{
    public interface IUsuarioRepositorio:IRepositorio<Usuario>
    {
        IEnumerable<Usuario> GetAllUsuarios();
        Usuario GetPorId(int id);
        
    }
}
