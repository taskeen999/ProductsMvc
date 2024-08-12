using Azure;
using Microsoft.AspNetCore.Mvc;
using ProductsMvc.BAl;

using ProductsMvc.Models;
namespace ProductsMvc.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ProductContext _productContext;
        public CustomerController(ProductContext productContext )
        {
            _productContext= productContext;


        }
        public ActionResult Index()
        {
            return View();
        }

        
        [HttpGet()]
        public JsonResult GetAllRecords()
        {
            var records = _productContext.Customer.ToList();

            return Json( records ); 
        }

        [HttpGet()]
        public JsonResult GetById(long id)
        {
            var records = _productContext.Customer.FirstOrDefault(x=>x.id==id); 

            return Json(records);
        }


        [HttpPost()]
        public JsonResult SaveModel(Customer customer)
        {
            if (customer != null)
            {
                if (customer.id == 0)
                {
                    // Add new customer
                    _productContext.Customer.Add(customer);
                    _productContext.SaveChanges();
                     return Json(new
                    {  success = true, 
                        message = "Record Added Successfully" 
                    }
                    
                    );
                }
                else
                {
                    // Update existing customer
                    _productContext.Customer.Update(customer);
                    _productContext.SaveChanges();
                    return Json(new { success = true, message = "Record Updated Successfully" });
                }
            }
            return Json(new { success = false, message = "Please Enter Record" });
        }





    }



}
