using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesTracker.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SalesTracker.Controllers
{
    public class InventoryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(db.Items.ToList());
        }

        [HttpPost]
        public IActionResult NewItem(int Id, string newName, string newDescription, decimal newCost, int newQuantity)
        {
            Item newItem = new Item(newName, newDescription, newCost, newQuantity, Id);
            db.Items.Add(newItem);
            db.SaveChanges();
            return Json(newItem);
        }
    }
}