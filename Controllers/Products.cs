using Bogus;
using Microsoft.AspNetCore.Mvc;
using MySecondApp.Models;
using MySecondApp.Services;

namespace MySecondApp.Controllers
{
    public class Products : Controller
    {
        public IActionResult Index()
        {
            ProductsDAO productsDAO = new ProductsDAO();



            return View(productsDAO.GetAllProducts());
        }
        public IActionResult SearchResults(string searchTerm)
        {
            ProductsDAO products = new ProductsDAO();
            List<ProductModel> productList = products.SearchProducts(searchTerm);
            return View("index",productList);


        }
        public IActionResult ShowDetails(int id)
        { 
            ProductsDAO products = new ProductsDAO();
            ProductModel foundProduct = products.GetProductById(id);
            return View(foundProduct);

        }

        public IActionResult Edit(int id)
        {
            ProductsDAO products = new ProductsDAO();
            ProductModel foundProduct = products.GetProductById(id);
            return View("Edit",foundProduct);

        }

        public IActionResult ProcessEdit(ProductModel product)
        {
            ProductsDAO products = new ProductsDAO();
            products.Update(product);
            return View("Index",products.GetAllProducts());

        }

        public IActionResult Delete(int Id)
        {
            ProductsDAO products = new ProductsDAO();
            ProductModel product = products.GetProductById(Id);
            products.Delete(product);
            return View("Index", products.GetAllProducts());

        }

        public IActionResult Create(int id)
        {
            ProductsDAO products = new ProductsDAO();
            ProductModel foundProduct = products.GetProductById(id);
            return View("Create", foundProduct);


        }

        public IActionResult ProcessCreate(ProductModel product)
        {
            ProductsDAO products = new ProductsDAO();
            products.Insert(product);
            return RedirectToAction("Index");

        }


        public IActionResult SearchForm()
        {
            return View();

        }
        public IActionResult Message()
        {
            return View("message");
        }

        public IActionResult Welcome(string name, int secretNumber = 13) 
        {
            ViewBag.Name = name;
            ViewBag.SecretNumber = secretNumber;
            return View();
    
        }
    }
}
