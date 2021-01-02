using Microsoft.EntityFrameworkCore;
using SHOPExercise.Models;

namespace SHOPExercise.Data
{
    public class ProductsDBContext : DbContext
    {
        public ProductsDBContext(DbContextOptions<ProductsDBContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 1,
                    Name = "Scale",
                    Price=50,
                    Description = "Fish Scales :)",
                    Photo = "https://img.likeness.ru/83/62/8362/1439702784.jpg"
                },
                new Product
                {
                    ID = 2,
                    Name = "Troll ass",
                    Price = 300,
                    Description = "Fantastic Troll ass",
                    Photo = "https://www.jeremyriad.com/wp-content/uploads/2017/03/Trump_Troll_Doll4-550x698.jpeg"
                });
        }
    }
}
