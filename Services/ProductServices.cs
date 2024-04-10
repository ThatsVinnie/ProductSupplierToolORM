using System.Data;
using Domain;

namespace Services
{
    public class ProductServices
    {
        // Serviços para recuperar o sucesso ou falha nos métodos CRUD
        public static bool AddProduct(string _name, string _description, string _price, string _qtde, int _idSupplier)
        {

            var product = new Product()
            {
                Name = _name,
                Description = _description,
                Price = Convert.ToDecimal(_price),
                Quantity = Convert.ToInt32(_qtde),
                IdSupplier = _idSupplier
            };

            if (Data.ProductRepository.Create(product))
            {
                return true;
            }
            return false;
        }

        public static DataTable DisplayProducts() 
        {
            return Data.ProductRepository.Read();
        }

        public static bool UpdateProduct(string _name, string _description, string _price, string _qtde, int _idSupplier, int _idProduct)
        {
            var product = new Product
            {
                Name = _name,
                Description = _description,
                Price = Convert.ToDecimal(_price),
                Quantity = Convert.ToInt32(_qtde),
                IdSupplier = _idSupplier
            };

            if (Data.ProductRepository.Update(product, _idProduct))
            {
                return true;
            }
            return false;
        }

        public static bool DeleteProduct(int _idProduct)
        {
            if (Data.ProductRepository.Delete(_idProduct))
            {
                return true;
            }
            return false;
        }
    }
}
