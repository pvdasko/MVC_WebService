namespace TestWeb.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StoreContext : DbContext
    {
        public StoreContext()
            : base("name=StoreContext")
        {
        }

        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Measure> Measure { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventory>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Measure>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.IdOrder)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.IdUm)
                .IsFixedLength();

            modelBuilder.Entity<Vendor>()
                .Property(e => e.RFC)
                .IsFixedLength();

            modelBuilder.Entity<Vendor>()
                .Property(e => e.Telephone)
                .IsFixedLength();
        }
    }
}
