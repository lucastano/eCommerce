using eCommerce.LogicaNegocio.Entidades;
using eCommerce.LogicaNegocio.IRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.AccesoDatos.Repositorios
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        eCommerceContext _context;
        public CategoriaRepositorio(eCommerceContext context)
        {
            _context = context;
        }


        public void create(Categoria entidad)
        {
            if (entidad == null) throw new Exception("No se puede agregar");
            _context.Categorias.Add(entidad);
            _context.SaveChanges();
        }

        public void delete(Categoria entidad)
        {
            throw new NotImplementedException();
        }

        public Categoria? get(int id)
        {
            return _context.Categorias.FirstOrDefault(c => c.Id == id);
        }

        public void update(Categoria entidad)
        {
            throw new NotImplementedException();
        }
    }
}
