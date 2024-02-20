using Bogus;
using MySecondApp.Models;

namespace MySecondApp.Services
{
    public class HardCodedSampleDataRepository : IProductDataServices

    {

        static List<ProductModel> productsList = new List<ProductModel>();
        public int Delete(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()
        {
            if (productsList.Count == 0)
            {

                productsList.Add(new ProductModel { Id = 1, Name = "TV", Price = 2.9m, Description = "A Led screen flat television. " });
                productsList.Add(new ProductModel { Id = 2, Name = "Web Cam", Price = 5.9m, Description = "Enables you to attend video calls." });
                productsList.Add(new ProductModel { Id = 3, Name = "Mouse Pad", Price = 4.9m, Description = "A square piece of cloth to move the mouse. " });
                productsList.Add(new ProductModel { Id = 4, Name = "4 TB USB Drive", Price = 6.9m, Description = "Backup all your work. " });

                for (int i = 0; i < 100; i++)
                {
                    productsList.Add(new Faker<ProductModel>()
                        .RuleFor(p => p.Id, i + 5)
                        .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                        .RuleFor(p => p.Price, f => f.Random.Decimal(100))
                        .RuleFor(p => p.Description, f => f.Rant.Review())

                        );
                }

            }

            return productsList;
        }

        public ProductModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
