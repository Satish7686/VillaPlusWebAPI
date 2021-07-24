using System.ComponentModel.DataAnnotations;

namespace Villa_ShoppingCart.Models
{
    public class Product
    {
        [Required]
        public string ProductName { get; set; }

        [Required, Range(0.01, float.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        public float ProductPerUnitPrice { get; set; }

        [Required, Range(1, int.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        public int Quantity { get; set; }

        public bool DiscountApplicable { get; set; }

    }
}
