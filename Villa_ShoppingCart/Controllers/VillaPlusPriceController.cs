using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Villa_ShoppingCart.Helpers;
using Villa_ShoppingCart.Models;

namespace Villa_ShoppingCart.Controllers
{
    [ApiController]
    [Route("[controller]")]
        public class VillaPlusPriceController : Controller
        {

        public static List<Product> Products = new List<Product>();
        ShoppingCartHelper shoppingCartHelper = new ShoppingCartHelper();

        [HttpGet]
        public float shoppingCartPriceCalculator([FromBody] List<Product> product)
        {
            float total = 0;
            try
            {
                if (ModelState.IsValid)
                {
                   
                    total = shoppingCartHelper.TotalPriceCalculator(product);
                    return total;

                }

            }
            catch (Exception ex)
            {
                throw ex;
                
            }

            return total;
          
        }

        }
}
