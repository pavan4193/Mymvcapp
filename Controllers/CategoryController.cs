using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyMvcApp.Models;

namespace MyMvcApp.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
                _db = db;
        }

    public IActionResult Index()
    {
        List<Category> objCategoryList= _db.Categories.ToList();
        return View(objCategoryList);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Category obj)
    {   

        if(obj.Name == obj.DisplayOrder.ToString())
        {
            ModelState.AddModelError("name", "The Display order Cannot match the  name");
        }
        if (ModelState.IsValid)
        {
        _db.Categories.Add(obj);
        _db.SaveChanges();
        return RedirectToAction("Index");
        }
        return View();
        
    }
    
    }
}