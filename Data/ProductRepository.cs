using Domain;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Data
{
    public class ProductRepository
    {
        private readonly MyDbContext _context;

        public ProductRepository(MyDbContext context)
        {
            _context = context;
        }

        // métodos CRUD
        public bool Create(Product product)
        {
            _context.Products.Add(product);

            try
            {
                _context.SaveChanges();

                return true;

            }catch(DbUpdateException ex)
            {
                return false;
            }
        }

        public List<Product> Read() 
        {
            try{
                var products = _context.Products.ToList();

                return products;
            }
            catch(DbException ex)
            {
                return null;
            }
        }

        public bool Update(Product product, int _idProduct)
        {
            var productToUpdate = _context.Products.Find(_idProduct);
            if(productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.Description = product.Description;
                productToUpdate.Price = product.Price;
                productToUpdate.Quantity = product.Quantity;
                productToUpdate.IdSupplier = product.IdSupplier;
                productToUpdate.Supplier = product.Supplier;

                try
                {
                    _context.SaveChanges();

                    return true;
                }
                catch (DbUpdateException ex)
                {
                    return false;
                }

            }
            return false;
        }

        public bool Delete(int _idProduct)
        {
            var productToDelete = _context.Products.Find(_idProduct);

            _context.Products.Remove(productToDelete);

            try
            {
                _context.SaveChanges();

                return true;

            }catch(DbUpdateException ex)
            {
                return false;
            }
        }
    }
}
