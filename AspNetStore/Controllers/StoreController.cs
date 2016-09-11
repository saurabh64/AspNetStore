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
        // GET: Store
        public  async Task<ActionResult> Index() //for all products
        {
            return View();
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