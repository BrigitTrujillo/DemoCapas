using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buiness
{
    public class BProduct
    {
        private DProduct dProduct;
        public BProduct()
        {
            dProduct = new DProduct();
        }

        public List<Product> ListarProduct(string name)
        {
            var products = dProduct.ListarProduct();
            var result = products.Where(x => x.name.Contains(name)).ToList();

            return result;
        }

    }
}
