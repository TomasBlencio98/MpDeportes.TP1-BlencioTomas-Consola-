using Microsoft.EntityFrameworkCore;
using MpDeportes.TP1.Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MpDeportes.TP1.Datos
{
    public class MpDeportesDbContext:DbContext
    {
        public MpDeportesDbContext()
        {
            
        }
        public MpDeportesDbContext(DbContextOptions<MpDeportesDbContext> op)
            :base(op)
        {
            
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Shoe> Shoes { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<ShoeSize> ShoesSizes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            ob.UseSqlServer(@"Data Source=.; 
                Initial Catalog=MpDeportes; 
                Trusted_Connection=true; 
                TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var brandList = new List<Brand>()
            {
                new Brand() {  BrandId=1,  BrandName="Adidas" },
                new Brand() { BrandId=2,  BrandName="Reebook" },
                new Brand() {  BrandId=3,  BrandName="Nike" }
            };
            modelBuilder.Entity<Brand>().HasData(brandList);

            var colorList = new List<Color>()
            {
                new Color() { ColorId = 1,ColorName = "Red"},
                new Color() { ColorId = 2, ColorName = "Blue"},
                new Color() { ColorId = 3, ColorName = "Green"}
            };
            modelBuilder.Entity<Color>().HasData(colorList);

            var genreList = new List<Genre>()
            {
                new Genre() { GenreId = 1, GenreName = "Masculino" },
                new Genre() { GenreId = 2, GenreName = "Femenino" },
                new Genre() { GenreId = 3, GenreName = "Unisex" }
            };
            modelBuilder.Entity<Genre>().HasData(genreList);

            var sportList = new List<Sport>()
            {
                new Sport() { SportId = 1, SportName = "Running" },
                new Sport() { SportId = 2, SportName = "Basketball" },
                new Sport() { SportId = 3, SportName = "Soccer" }
            };
            modelBuilder.Entity<Sport>().HasData(sportList);


            modelBuilder.Entity<Shoe>()
            .HasOne(s => s.Brand)
            .WithMany(c=>c.Shoes)
            .HasForeignKey(s => s.BrandId)
            .OnDelete(DeleteBehavior.ClientSetNull) 
            .HasConstraintName("FK_Shoes_Brands");


            modelBuilder.Entity<Shoe>()
            .HasOne(s => s.Color)
            .WithMany(c => c.Shoes)
            .HasForeignKey(s => s.ColorId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Shoes_Colors");

            modelBuilder.Entity<Shoe>()
            .HasOne(s => s.Genre)
            .WithMany(c => c.Shoes)
            .HasForeignKey(s => s.GenreId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Shoes_Genres");

            modelBuilder.Entity<Shoe>()
            .HasOne(s => s.Sport)
            .WithMany(c => c.Shoes)
            .HasForeignKey(s => s.SportId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Shoes_Sports");


            var sizes = new List<Size>();
            //se utiliza para proporcionar datos iniciales
            //(también conocidos como datos semilla)
            int sizeId = 1;

            for (decimal i = 28; i <= 50; i += 0.5m)
            {
                sizes.Add(new Size
                {
                    SizeId = sizeId++,
                    SizeNumber = i
                });
            }
            //llenar con los talles.

            modelBuilder.Entity<Size>(entity =>
            {
                entity.HasKey(s => s.SizeId);
                entity.HasIndex(s => s.SizeNumber).IsUnique();
                entity.Property(s => s.SizeNumber)
                      .HasColumnType("decimal(3,1)")
                      .HasPrecision(3, 1)
                      .IsRequired();
                entity.HasData(sizes); // `sizes` es una colección de datos preconfigurados
                entity.ToTable("Sizes");
            });
            //agregamos datos a la entidad shoe 
            //ojala ande:) lo hice 20 veces

            var shoeList = new List<Shoe>()
            {
                new Shoe() { ShoeId = 1, Model = "Adidas Superstar",
                Price = 99.99m, GenreId = 1, SportId = 1, Description="Estilo urbano y cultura pop",
                BrandId=1, ColorId=1},
                new Shoe() { ShoeId = 2, Model = "Nano X1",
                Price = 129.99m, GenreId = 2, SportId = 2 , Description="Diseñadas para ofrecer estabilidad y versatilidad en cada movimiento",
                BrandId=2, ColorId=2},
                new Shoe() { ShoeId = 3, Model = "Air Zoom ",
                Price = 79.99m, GenreId = 3, SportId = 3 , Description=" Opción versátil y cómoda para correr",
                BrandId=3, ColorId=3}
            };

            modelBuilder.Entity<Shoe>().HasData(shoeList);

            // Configuración para Brands
            modelBuilder.Entity<Brand>()
                .Property(b => b.Active)
                .HasDefaultValue(true);

            // Configuración para Colors
            modelBuilder.Entity<Color>()
                .Property(c => c.Active)
                .HasDefaultValue(true);

            // Configuración para Sports
            modelBuilder.Entity<Sport>()
                .Property(s => s.Active)
                .HasDefaultValue(true);

            // Configuración para Shoes
            modelBuilder.Entity<Shoe>()
                .Property(s => s.Active)
                .HasDefaultValue(true);

            modelBuilder.Entity<ShoeSize>(entity =>
            {
                entity.ToTable("ShoesSizes");
                entity.HasKey(ss => ss.ShoeSizeId);
                entity.HasIndex(ss => new { ss.ShoeId, ss.SizeId }).IsUnique();
                entity.HasOne(ss => ss.Shoe).WithMany(s => s.ShoesSizes).HasForeignKey(sc => sc.ShoeId);
                entity.HasOne(ss => ss.Size).WithMany(s => s.ShoesSizes).HasForeignKey(sc => sc.SizeId);
                entity.Property(ss => ss.QuantityInStock).IsRequired();
            });

            //modelBuilder.Entity<ShoeSize>(entity =>
            //{
            //    entity.HasKey(pp => new 
            //    {
            //        pp.ShoeId,
            //        pp.SizeId
            //    });

            //    entity.HasOne(pp => pp.Shoe)
            //        .WithMany(p => p.ShoesSizes)
            //        .HasForeignKey(pp => pp.ShoeId);

            //    entity.HasOne(pp => pp.Size)
            //        .WithMany(p => p.ShoesSizes)
            //        .HasForeignKey(pp => pp.SizeId);

            //    entity.Property(ss => ss.QuantityInStock).IsRequired();

            //});

        }
    }
}
