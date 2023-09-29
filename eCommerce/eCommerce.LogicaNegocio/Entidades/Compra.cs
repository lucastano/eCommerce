using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.LogicaNegocio.Entidades
{
    public class Compra
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public List<ProductoCantidad> carrito { get; set; }
    }
}
