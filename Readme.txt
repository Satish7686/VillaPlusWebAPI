This is a Web Api that is intended to calculate the total price in shopping cart 

#Assumptions Made: 
1) In the product list what ever we recieve per unit price will be provided for each product
2) We are expected to return only total price for the items added into the shopping cart i.e (with discount and without discount products)
3) For each product in the list items that we recive it will have the following information Product name,ProductPerUnitPrice,Quantity and DiscountApplicable

#Solution Design:
1) Request is recived in the controller VillaPlusPriceController
2) VillaPlusPriceController invokes the Business helper class i.e. ShoppingCartHelper
3) ShoppingCartHelper segregates Discount Applicaple and No discount applicable products and calculates the total price individually for both the products using a mathematical logic and returns the total price to the controller
4) Controller then returns the total price for the items in the shopping cart
5) MsTest Unit test project is created for unit testing purpose

# Build and Test instructions in Local Machine
1) Run the soultion in Visual Studio in 2019 and above that is compatable with .net core
2) Obtain the end point from the browser and through Postnan, SOAP or any other tool to test web API hit the url "Endpoint/VillaPlusPrice"
3) Pass the inputs as below in Json format

[
        {
    "ProductName": "Apple",
    "ProductPerUnitPrice": 3.5,
    "Quantity": 9,
    "DiscountApplicable": true
    },
    {
    "ProductName": "Onion",
    "ProductPerUnitPrice": 5,
    "Quantity": 9,
    "DiscountApplicable": false
    },
    {"ProductName": "Orange",
    "ProductPerUnitPrice": 4,
    "Quantity": 9,
    "DiscountApplicable": true
    }

]












