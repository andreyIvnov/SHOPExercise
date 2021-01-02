using Microsoft.AspNetCore.Mvc;
using SHOPExercise.Models;

namespace SHOPExercise.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _contex;
        public ProductController(IProductRepository context)
        {
            _contex = context;
        }
       
        
        public ActionResult Index()
        {
            return View(_contex.GetProducts());
        }

        public ActionResult Details(int id)
        {
            Product prod = _contex.GetProduct(id);
            return View(prod);
        }

        
        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _contex.AddProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        
        
        
        public ActionResult Edit(int id)
        {
            return View(_contex.GetProduct(id));
        }
                
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product, int id)
        {
            if (ModelState.IsValid)
            {
                _contex.UpdateProduct(id, product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

       
        
        
        public ActionResult Delete(int id)
        {
            _contex.RemoveProduct(id);
            return RedirectToAction("Index");
        }



    }
}
