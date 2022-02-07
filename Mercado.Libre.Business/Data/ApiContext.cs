using Microsoft.EntityFrameworkCore;

namespace Mercado.Libre.Business.Data
{
    public class ApiContext: DbContext
    {
        public DbSet<Satellite> Satellites { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        { 
        }
    }
}
