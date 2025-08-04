using ProductInventory.Interfaces;
using ProductInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new();
        private int _nextId = 1;
        

        public void Add(Product products)
        {
            products.Id = ++_nextId;
            _products.Add(products);
        }


        public List<Product> GetAll()
        {
            return _products.ToList();  
        }

        public List<Product> SearchByName(string name)
        {
            return _products.Where(p => p.Name.ToLower() == name.ToLower()).ToList();
        }
    }
}
