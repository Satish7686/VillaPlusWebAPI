using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Villa_ShoppingCart.Controllers;
using Villa_ShoppingCart.Helpers;
using Villa_ShoppingCart.Models;

namespace Villa_ShoppingCart_UnitTestProject
{
    [TestClass]
    public class VillaPlusPriceControllerTest
    {
        VillaPlusPriceController _villaPlusController = new VillaPlusPriceController();
        [TestMethod]
        public void shoppingCartPriceCalculatorTest()
        {
                var testProducts = new List<Product>();
                testProducts.Add(new Product
                {
                    ProductName = "Apple",
                    ProductPerUnitPrice = 3F,
                    Quantity = 3,
                    DiscountApplicable = true
                });
            testProducts.Add(new Product
            {
                ProductName = "Onions",
                ProductPerUnitPrice = 3.5F,
                Quantity = 2,
                DiscountApplicable = false
            });

            var result = _villaPlusController.shoppingCartPriceCalculator(testProducts);


            Assert.AreEqual(13, result);



        }

             

        [TestMethod]
        public void shoppingCartPriceCalculatorTest_Fail()
        {
            var testProducts = new List<Product>();
            testProducts.Add(new Product
            {
                ProductName = "Apple",
                ProductPerUnitPrice = 3F,
                Quantity = 0,
                DiscountApplicable = true
            });
            testProducts.Add(new Product
            {
                ProductName = "Onions",
                ProductPerUnitPrice = 3.5F,
                Quantity = 2,
                DiscountApplicable = false
            });

            var result = _villaPlusController.shoppingCartPriceCalculator(testProducts);


            Assert.AreEqual(7, result);

        }
    }
    [TestClass]
    public class ShoppingCartHelperTest
    {
        ShoppingCartHelper _scHelper = new ShoppingCartHelper();
        [TestMethod]
        public void TotalPriceCalculatorTest()
        {
            var testProducts = new List<Product>();
            testProducts.Add(new Product
            {
                ProductName = "Strawberry",
                ProductPerUnitPrice = 3F,
                Quantity = 3,
                DiscountApplicable = true
            });
            testProducts.Add(new Product
            {
                ProductName = "JhonnyWalker",
                ProductPerUnitPrice = 3.5F,
                Quantity = 2,
                DiscountApplicable = false
            });

            var result = _scHelper.TotalPriceCalculator(testProducts);


            Assert.AreEqual(13, result);
        }
        public void TotalPriceCalculatorTest_Fail()
        {
            var testProducts = new List<Product>();
            testProducts.Add(new Product
            {
                ProductName = "Strawberry",
                ProductPerUnitPrice = 3F,
                Quantity = 0,
                DiscountApplicable = true
            });
            testProducts.Add(new Product
            {
                ProductName = "JohnyWalker",
                ProductPerUnitPrice = 0,
                Quantity = 2,
                DiscountApplicable = false
            });

            var result = _scHelper.TotalPriceCalculator(testProducts);


            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void DiscountApplicableTotalTest()
        {
            var testProducts = new List<Product>();
            testProducts.Add(new Product
            {
                ProductName = "Strawberry",
                ProductPerUnitPrice = 3F,
                Quantity = 3,
                DiscountApplicable = true
            });
            var result = _scHelper.TotalPriceCalculator(testProducts);


            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void DiscountApplicableTotalTest_Fail()
        {
            var testProducts = new List<Product>();
            testProducts.Add(new Product
            {
                ProductName = "Strawberry",
                ProductPerUnitPrice = 3F,
                Quantity = 0,
                DiscountApplicable = true
            });
            var result = _scHelper.TotalPriceCalculator(testProducts);


            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void NodiscountApplicableTotalTest()
        {
            var testProducts = new List<Product>();
            testProducts.Add(new Product
            {
                ProductName = "Strawberry",
                ProductPerUnitPrice = 3F,
                Quantity = 9,
                DiscountApplicable = false
            });
            var result = _scHelper.TotalPriceCalculator(testProducts);


            Assert.AreEqual(27, result);
        }
        [TestMethod]
        public void NodiscountApplicableTotalTest_Fail()
        {
            var testProducts = new List<Product>();
            testProducts.Add(new Product
            {
                ProductName = "Strawberry",
                ProductPerUnitPrice = 0,
                Quantity = 9,
                DiscountApplicable = false
            });
            var result = _scHelper.TotalPriceCalculator(testProducts);


            Assert.AreEqual(0, result);
        }
    }
}
