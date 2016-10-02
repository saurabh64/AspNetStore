using AspNetStore.Data;
using AspNetStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;

namespace AspNetStore.Services
{
    public class StoreService
    {
        private readonly StoreContext _db;

        public StoreService():this (new StoreContext())
        {

        }

         public StoreService(StoreContext context)
        {
            _db = context;
        }

        public async Task<IEnumerable<Category>> GetCategories()
         {
             return await _db.Categories.OrderBy(x => x.Name).ToArrayAsync();
         }


    }
}