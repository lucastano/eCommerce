using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.LogicaNegocio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreCompleto { get; set; }
        public byte[] PasswordHash  { get; set; }
        public byte[] PasswordSolt { get; set; }
        public string Direccion { get; set; }
        public List<Compra> ComprasFinalizadas { get; set; }
        public Compra Compra { get; set; }

    }
}
