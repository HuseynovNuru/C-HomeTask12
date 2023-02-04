using System;
using System.Collections.Generic;
using System.Text;

namespace CHomeTask12
{
    public class Store : IStore
    {
        private Product[] _products = new Product[0];
        public Product[] Products 
        { get => _products;}

        public void AddProduct(Product product)
        {
            Array.Resize(ref _products, _products.Length+1);
            _products[_products.Length-1] = product;
        }

        public Product GetProductByNo(int no)
        {
            foreach (Product pr in _products)
            {
                if(pr.No == no)
                    return pr;
            }
            throw new Exception();
        }

        public bool HasProductByNo(int no)
        {
            foreach (Product pr in _products)
            {
                if (pr.No == no)
                    return true;
            }
            return false;
        }
    }
}
