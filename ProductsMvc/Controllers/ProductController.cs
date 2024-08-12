using Azure;
using Microsoft.AspNetCore.Mvc;
using ProductsMvc.BAl;
using ProductsMvc.Models;

namespace ProductsMvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductContext _productContext;
        public ProductController(ProductContext productContext)
        {
            _productContext = productContext;


        }
        public IActionResult Index()
        {
            var product = _productContext.Product.ToList();


            return View(product);
        }


        public IActionResult Save(Product model)
        {
            return View();
        }
        //addnewProduct..

        [HttpPost]
        public IActionResult SaveProduct(Product model)
        {
            //if (ModelState.IsValid)
            //{

            if (model.ProductName == null)
                return View();
                
                if (model.ProductId <= 0)
                {
                    _productContext.Product.Add(model);
                    _productContext.SaveChanges();
                    TempData["Message"] = "Product added successfully!";
                }
                else
                {
                    _productContext.Product.Update(model);
                    _productContext.SaveChanges();
                    TempData["Message"] = "Product updated successfully!";
                }

                return RedirectToAction("Index"); // Redirect to a list or index view
            //}

            // If model state is not valid, return to the same view with validation errors
           // return View(model);
        }


    }




}

