
using eCommerce.AccesoDatos;
using eCommerce.AccesoDatos.Repositorios;
using eCommerce.Aplicacion.CasosUso;
using eCommerce.Aplicacion.ICasosUso;
using eCommerce.LogicaNegocio.IRepositorios;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            // Add services to the container.

            builder.Services.AddDbContext<eCommerceContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("eCommerceContext"));

            });

            //add scoped repositorios 
            builder.Services.AddScoped<IProductoRepositorio, ProductoRepositorio>();
            builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            builder.Services.AddScoped<ICategoriaRepositorio, CategoriaRepositorio>();
            // add scoped casos uso 
            builder.Services.AddScoped<IAddProducto, AddProducto>();
            builder.Services.AddScoped<IGetAllProductos, GetAllProductos>();
            builder.Services.AddScoped<IGetCategoria, GetCategoria>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}