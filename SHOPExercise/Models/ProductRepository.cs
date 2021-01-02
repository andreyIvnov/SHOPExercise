using SHOPExercise.Data;
using System.Collections.Generic;
using System.Linq;

namespace SHOPExercise.Models
{
    public class ProductRepository : IProductRepository
    {
        private ProductsDBContext _context;
        public ProductRepository(ProductsDBContext context)
        {
            _context = context;
        }
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public Product GetProduct(int id)
        {
            return _context.Products.FirstOrDefault(p => p.ID == id);
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public void RemoveProduct(int id)
        {
            var prod = _context.Products.FirstOrDefault(p => p.ID == id);
            _context.Products.Remove(prod);
            _context.SaveChanges();
        }

        public void UpdateProduct(int id, Product product)
        {
            Product prodToChange = _context.Products.FirstOrDefault(p => p.ID == id);
            prodToChange.Name = product.Name;
            prodToChange.Price = product.Price;
            prodToChange.Description = product.Description;
            prodToChange.Photo = product.Photo;

            _context.SaveChanges();
        }
    }
}
