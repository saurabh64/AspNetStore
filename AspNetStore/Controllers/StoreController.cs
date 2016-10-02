using AspNetStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AspNetStore.Controllers
{
    public class StoreController : Controller
    {
        public readonly StoreService _store;
        public StoreController():this(new StoreService())
        {
                
        }
        public StoreController(StoreService service)
        {
            _store = service;
        }
        // GET: Store
        public  async Task<ActionResult> Index() //for all products
        {
            var categories =  await _store.GetCategories();
            return View(categories);
        }

        public async Task<ActionResult> Browse(string id)  //for category
        {
            return View();
        }

        public async Task<ActionResult> Details(int id) //for individual product
        {
            return View();
        }
    }
}