using System.Collections.Generic;

namespace SHOPExercise.Models
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        void AddProduct(Product product);
        void RemoveProduct(int id);
        void UpdateProduct(int id, Product product);
    }
}
