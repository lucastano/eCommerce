using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.LogicaNegocio.IRepositorios
{
    public interface IRepositorio<T>
    {
        //CRUD
        void create(T entidad);
        T? get();
        void update(T entidad);
        void delete(T entidad);


    }
}
