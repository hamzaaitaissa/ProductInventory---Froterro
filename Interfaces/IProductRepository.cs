using ProductInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory.Interfaces
{
    public interface IProductRepository
    {
        void Add(Product products);
        List<Product> GetAll();
        List<Product> SearchByName(string name);
    }
}
