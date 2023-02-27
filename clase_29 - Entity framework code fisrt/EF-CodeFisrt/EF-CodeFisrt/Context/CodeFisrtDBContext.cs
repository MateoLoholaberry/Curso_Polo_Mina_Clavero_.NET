using EF_CodeFisrt.Modelos;
using Microsoft.EntityFrameworkCore;

namespace EF_CodeFisrt.Context
{
    public class CodeFisrtDBContext : DbContext
    {
        // Acá acoplamos el modelo de clases al DbContext de EF
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Deposito> Depositos { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Conectamos con nuestra base SQL Server usando un string de conexión
            optionsBuilder.UseSqlServer("Server=MATEO\\SQLEXPRESS;Initial Catalog=EFCodeFisrt;Integrated Security=true;Encrypt=False");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
