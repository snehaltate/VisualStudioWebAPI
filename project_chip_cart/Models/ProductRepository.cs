using ProductDBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_chip_cart.Models
{
    public class ProductRepository
    {

        //In that we give all tables, so we create object of that class
        chip_cartContext context = new chip_cartContext(); //here we create a method category type to get data from Categories tables
       public IEnumerable<Product> GetProducts()
            { //object.tablename
                var product = context.Products.ToList();
             //here we return all categories to controller class
                     return product;
}


}
}
