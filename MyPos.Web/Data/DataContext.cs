using Microsoft.EntityFrameworkCore;
using MyPos.Web.Data.Entities;

namespace MyPos.Web.Data
{
    public class DataContext : DbContext
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="options"></param>
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        /// <summary>
        /// Agregar la tabla ProductGroups
        /// </summary>
        public DbSet<ProductGroup> ProductGroups { get; set; }

    }
}
