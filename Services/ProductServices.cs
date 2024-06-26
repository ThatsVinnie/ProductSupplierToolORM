﻿using System.Data;
using Data;
using Domain;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Services
{
    public class ProductServices
    {
        private readonly ProductRepository _productRepository;
        private readonly SupplierRepository _supplierRepository;

        public ProductServices(ProductRepository productRepository, SupplierRepository supplierRepository)
        {
            _productRepository = productRepository;
            _supplierRepository = supplierRepository;
        }

        // Serviços para recuperar o sucesso ou falha nos métodos CRUD
        public bool AddProduct(string _name, string _description, string _price, string _qtde, int _idSupplier)
        {

            var product = new Product()
            {
                Name = _name,
                Description = _description,
                Price = Convert.ToDecimal(_price),
                Quantity = Convert.ToInt32(_qtde),
                IdSupplier = _idSupplier,
                Supplier = _supplierRepository.GetSupplier(_idSupplier)
            };

            if (_productRepository.Create(product))
            {
                return true;
            }
            return false;
        }

        public List<Product> DisplayProducts() 
        {
            return _productRepository.Read();
        }

        public bool UpdateProduct(string _name, string _description, string _price, string _qtde, int _idSupplier, int _idProduct)
        {
            var product = new Product
            {
                Name = _name,
                Description = _description,
                Price = Convert.ToDecimal(_price),
                Quantity = Convert.ToInt32(_qtde),
                IdSupplier = _idSupplier,
                Supplier = _supplierRepository.GetSupplier(_idSupplier)
            };

            if (_productRepository.Update(product, _idProduct))
            {
                return true;
            }
            return false;
        }

        public bool DeleteProduct(int _idProduct)
        {
            if (_productRepository.Delete(_idProduct))
            {
                return true;
            }
            return false;
        }
    }
}
