using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MySecondApp.Models
{
    public class ProductModel
    {
        [DisplayName("Product Id Number ")]
        public int Id { get; set; }

        [DisplayName("Product Name ")]

        public string Name { get; set; }

        [DisplayName("Price of the Product ")]
        [DataType(DataType.Currency)]

        public decimal Price { get; set; }

        [DisplayName("Product Description ")]

        public string Description { get; set; } 


    }
}
