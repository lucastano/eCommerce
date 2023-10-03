using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.LogicaNegocio.Entidades
{
    [NotMapped]
    public class ProductoCantidad
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
