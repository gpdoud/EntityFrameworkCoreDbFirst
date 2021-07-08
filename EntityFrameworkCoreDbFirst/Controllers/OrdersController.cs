using EntityFrameworkCoreDbFirst.Models;

using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCoreDbFirst.Controllers {
    
    public class OrdersController {

        readonly AppDbContext _context;



        public OrdersController() {
            _context = new AppDbContext();
        }
    }
}
