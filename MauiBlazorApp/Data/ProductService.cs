using ProductAPIClientLibrary;
using ProductModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazorApp.Data
{
    public class ProductService
    {
        CultureInfo Cirl = new CultureInfo("ie-IE");
        Encoding OutputEncoding = System.Text.Encoding.UTF8;

        public ProductService() {
            ProductClient.login("paul@itsligo.ie", "P@ssw0rd!");
        }
       
        public List<Product> GetProducts()
        {
            if (!String.IsNullOrEmpty(ProductClient.UserToken))
                return ProductClient.getProducts();
            else return null;
        }
    }
}
