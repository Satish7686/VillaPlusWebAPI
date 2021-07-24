using System;
using System.Collections.Generic;
using Villa_ShoppingCart.Models;

namespace Villa_ShoppingCart.Helpers
{
    public class ShoppingCartHelper
    {
       

        List<Product> DiscountApplicableProducts = new List<Product>();
        List<Product> NodiscountApplicableProducts = new List<Product>();

        int productQuantity = 0;
        float productPrice;
        float totalPrice = 0;
       public float TotalPriceCalculator(List<Product> products)
        {
            foreach (Product product in products)
            {
                if (product.DiscountApplicable == true)
                {
                    DiscountApplicableProducts.Add(product);
                }
                else
                {
                    NodiscountApplicableProducts.Add(product);
                }
                float DiscountTotal = DiscountApplicableTotal(DiscountApplicableProducts);
                float NoDiscountTotal = NoDiscountApplicableTotal(NodiscountApplicableProducts);
                totalPrice = DiscountTotal + NoDiscountTotal;
            }

            return totalPrice;
        }

        /// <summary>
        /// Calculates total discount price by making use of a mathematical formula
        /// </summary>
        /// <param name="DiscountApplicableProducts"></param>
        /// <returns></returns>

        private float DiscountApplicableTotal(List<Product> DiscountApplicableProducts)
        {
            totalPrice = 0;

            foreach (var discountApplicableProduct in DiscountApplicableProducts)
            {   
                productPrice = discountApplicableProduct.ProductPerUnitPrice;
                productQuantity = discountApplicableProduct.Quantity;
                
                if (productQuantity % 3 == 0)
                {
                    try
                    {
                        var price = (productQuantity / 3 * 2) * productPrice;
                        totalPrice = totalPrice + price;
                   
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    try
                    {
                        var price = ((productQuantity / 3 * 2) + 1) * productPrice;
                        totalPrice = totalPrice + price;
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                   
                }

            }

            return totalPrice;
        }

        /// <summary>
        /// Calcultaes total No discount price
        /// </summary>
        /// <param name="NoDiscountableproducts"></param>
        /// <returns></returns>

        private float NoDiscountApplicableTotal(List<Product> NoDiscountableproducts)
        {
            totalPrice = 0;
            foreach (var noDiscountableproduct in NoDiscountableproducts)
            {
                try
                {
                    productQuantity = noDiscountableproduct.Quantity;
                    productPrice = noDiscountableproduct.ProductPerUnitPrice;

                    var price = productQuantity * productPrice;

                    totalPrice = totalPrice + price;
                }
                catch (Exception ex)
                {
                    throw ex;

                }
            }
            return totalPrice;
        }
    }
}

