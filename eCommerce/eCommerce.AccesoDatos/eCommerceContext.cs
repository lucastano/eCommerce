using eCommerce.LogicaNegocio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.AccesoDatos
{
    public class eCommerceContext:DbContext
    {
        public DbSet<Categoria>Categorias { get; set; }
        public DbSet<Compra>Compras { get; set; }
        public DbSet<Producto>Productos { get; set; }
        public DbSet<Usuario>Usuarios { get; set; }

        public eCommerceContext(DbContextOptions<eCommerceContext> options) : base(options) 
        { 
        
        
        
        }

        
    }
}
