using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetStore.Data
{
    public class StoreContext: DbContext
    {
        public StoreContext():base("Default")
        {

        }
    }
}