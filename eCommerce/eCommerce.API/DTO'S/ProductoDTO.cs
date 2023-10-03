namespace eCommerce.API.DTO_S
{
    public class ProductoDTO
    {
        public string Nombre { get; set; }
        public string EAN { get; set; }
        public CategoriaDTO Categoria { get; set; }

    }
}
