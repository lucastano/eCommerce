using eCommerce.LogicaNegocio.Entidades;
using eCommerce.LogicaNegocio.IRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.AccesoDatos.Repositorios
{
    public class ProductoRepositorio : IProductoRepositorio
    {
        private eCommerceContext _context;
        public ProductoRepositorio(eCommerceContext context)
        {
            _context = context;
        }

        public void create(Producto entidad)
        {
            if (entidad == null) throw new Exception("Algun dato incorrecto");
            _context.Productos.Add(entidad);
            _context.SaveChanges();
        }

        public void delete(Producto entidad)
        {
            if (entidad == null) throw new Exception("No se puede eliminar");
            _context.Productos.Remove(entidad);
            _context.SaveChanges();

        }

        public Producto? get(int id)
        {
            return _context.Productos.FirstOrDefault(p => p.Id == id);
        }

        //producto se puede actualizar el codigo EAN Y NOMBRE 
        public void update(Producto entidad)
        {
            if (entidad == null) throw new Exception("No se puede actualizar");
            Producto prod=get(entidad.Id);
            if (prod == null) throw new Exception("No existe producto");
            prod.Nombre = entidad.Nombre;
            prod.EAN= entidad.EAN;
            _context.SaveChanges();

        }
    }
}
