using ProductInventory.Interfaces;
using ProductInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void AddProduct(string name, int quantity, int unitPrice, string description)
        {
            var product = new Product { Name = name, Quantity = quantity, UnitPrice = unitPrice, Description = description };
            _productRepository.Add(product);
        }

        public List<Product> GetAll() => _productRepository.GetAll();

        public List<Product> Search(string name) => _productRepository.SearchByName(name);
    }
}
