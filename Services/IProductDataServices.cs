using MySecondApp.Models;

namespace MySecondApp.Services
{
    public interface IProductDataServices
    {
        List<ProductModel> GetAllProducts();

        List<ProductModel> SearchProducts(String searchTerm);

        ProductModel GetProductById(int id);

        int Insert(ProductModel product);

        int Update(ProductModel product); 

        int Delete(ProductModel product);

    }
}
