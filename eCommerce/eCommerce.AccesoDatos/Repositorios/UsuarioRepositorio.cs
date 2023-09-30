using eCommerce.LogicaNegocio.Entidades;
using eCommerce.LogicaNegocio.IRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.AccesoDatos.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        //dependence inyection a clase contexto 
        private eCommerceContext _context;
        public UsuarioRepositorio(eCommerceContext context)
        {
            _context = context;
        }

        public void create(Usuario entidad)
        {
            if (entidad == null) throw new Exception("algun dato erroneo en usuario");
            _context.Usuarios.Add(entidad);
            _context.SaveChanges();

        }

        public void delete(Usuario entidad)
        {
            if (entidad == null) throw new Exception("No existe usuario");
            _context.Usuarios.Remove(entidad);

            _context.SaveChanges();
        }

        public Usuario? get(int id)
        {
            return _context.Usuarios.FirstOrDefault(u=>u.Id==id);
        }

        public IEnumerable<Usuario> GetAllUsuarios()
        {
            return _context.Usuarios;
        }

        public Usuario GetPorId(int id)
        {
            throw new NotImplementedException();
            //innecesario
        }

        //se puede editar direccion , nombre completo y mail 
        public void update(Usuario entidad)
        {
            Usuario usuarioAEditar = get(entidad.Id);
            if (usuarioAEditar == null) throw new Exception("No existe usuario");
            usuarioAEditar.Email = entidad.Email;
            usuarioAEditar.Direccion= entidad.Direccion;
            usuarioAEditar.NombreCompleto= entidad.NombreCompleto;
            _context.SaveChanges();


        }
    }
}
