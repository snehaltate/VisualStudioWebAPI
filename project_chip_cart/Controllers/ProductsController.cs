using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project_chip_cart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_chip_cart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //here we create a object of cr class to get tables data into controller
        ProductRepository repository = new ProductRepository(); //we create method to get category tables and we return to view
        public IEnumerable<Product> get()
        {
            return repository.GetProducts().ToList();
        }
    }
}



