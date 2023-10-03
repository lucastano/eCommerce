using eCommerce.Aplicacion.ICasosUso;
using eCommerce.LogicaNegocio.Entidades;
using eCommerce.LogicaNegocio.IRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Aplicacion.CasosUso
{
    public class GetCategoria : IGetCategoria
    {
        private readonly ICategoriaRepositorio repositorio;

        public GetCategoria(ICategoriaRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public Categoria Ejecutar(int id)
        {
            return repositorio.get(id);
        }
    }
}
