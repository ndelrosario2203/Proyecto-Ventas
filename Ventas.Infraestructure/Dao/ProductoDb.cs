using Microsoft.Extensions.Logging;
using Ventas.Domain.Entities;
using Ventas.Infraestructure.Context;
using Ventas.Infraestructure.Interfaces;
using Ventas.Infraestructure.Model;

namespace Ventas.Infraestructure.Dao
{
    public class ProductoDb : DaoBase<Producto>, IProductoDb
    {
        private readonly VentasContext context;
        private readonly ILogger<VentaDb> logger;

        public ProductoDb(VentasContext context, ILogger<VentaDb> logger) : base(context)
        {
            this.context = context;
            this.logger = logger;
        }

        public List<ProductosPorCategoria> ObtenerProducosPorCategoria(int category)
        {
            List<ProductosPorCategoria> Productos = new List<ProductosPorCategoria>();

            try
            {
                Productos = (from producto in context.productos
                                join categoria in context.categorias
                                on producto.IdCategoria equals categoria.IdCategoria
                                where producto.Eliminado == false
                                && categoria.Eliminado == false
                                && categoria.IdCategoria == category
                                orderby producto.FechaRegistro descending
                                select new ProductosPorCategoria()
                                {
                                    ProductoId = producto.IdProducto,
                                    CodigoBarra = producto.CodigoBarra,
                                    Marca = producto.Marca,
                                    Stock = producto.Stock,
                                    NombreCategoria = categoria.Descripcion

                                }).ToList();
                return Productos;
            }
            catch (Exception ex)
            {
                this.logger.LogError("Error cargando la información.", ex.ToString());
                throw;
            }
        }
    }
}