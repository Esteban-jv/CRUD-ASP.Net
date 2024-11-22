using ProyectoCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace ProyectoCrud.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            // build with ctor
        }

        // Agregar los modelos aquí. Esto es básicamente como funciona el registro de apps en django en el admin para que lo tome en cuenta.
        public DbSet<Contact> Contact { get; set; }
    }
}
