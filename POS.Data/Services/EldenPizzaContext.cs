using Microsoft.EntityFrameworkCore;
using POS.Data.Entities;
using POS.Data.Maps;

namespace EldenPizza.POS.WebApi.Infrastructure
{
    public class EldenPizzaContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClienteDireccion> ClienteDirecciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TipoProducto> TipoProductos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetallePedido> DetallePedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ClienteDireccionMap());
            modelBuilder.ApplyConfiguration(new PedidoMap());
            modelBuilder.ApplyConfiguration(new DetallePedidoMap());
            modelBuilder.ApplyConfiguration(new TipoProductoMap());
            modelBuilder.ApplyConfiguration(new ProductoMap());
        }

        public DbSet<TipoProducto> TiposProducto => Set<TipoProducto>();
        //public DbSet<Producto> Productos => Set<Producto>();

        public EldenPizzaContext(DbContextOptions<EldenPizzaContext> options) : base(options)
        {
            
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TipoProductoMap());
            modelBuilder.ApplyConfiguration(new ProductoMap());
        }*/
    }
 }
