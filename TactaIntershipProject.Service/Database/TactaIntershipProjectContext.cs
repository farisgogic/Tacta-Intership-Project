using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TactaIntershipProject.Service.Database
{
    public partial class TactaIntershipProjectContext : DbContext
    {
        public TactaIntershipProjectContext()
        {
            
        }
        public TactaIntershipProjectContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Shoppers> Shoppers { get; set; }
        public virtual DbSet<ShoppingList> ShoppingLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost, 1401; Initial Catalog=TactaIntershipProject; user=sa; Password=Konjic1981; TrustServerCertificate=True");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            onModelCreatingPartial(modelBuilder);
        }

        partial void onModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
