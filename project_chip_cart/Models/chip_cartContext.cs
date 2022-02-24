using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using project_chip_cart.Models;

#nullable disable

namespace ProductDBContext
{
    public partial class chip_cartContext : DbContext
    {
        public chip_cartContext()
        {
        }

        public chip_cartContext(DbContextOptions<chip_cartContext> options)
            : base(options)
        {
        }

        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderTable> OrderTables { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<SequelizeMetum> SequelizeMeta { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("host=localhost;database=chip_cart;user id=postgres;password=root;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "English_United States.1252");

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cartid).HasColumnName("cartid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("createdAt");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Productid).HasColumnName("productid");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("updatedAt");
            });

            modelBuilder.Entity<OrderTable>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("createdAt");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("date")
                    .HasColumnName("orderDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("updatedAt");

                entity.Property(e => e.Userid)
                    .HasMaxLength(255)
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Categories)
                    .HasMaxLength(255)
                    .HasColumnName("categories");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("createdAt");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("updatedAt");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<SequelizeMetum>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("SequelizeMeta_pkey");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasColumnName("address");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("createdAt");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(255)
                    .HasColumnName("mobile");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("updatedAt");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
