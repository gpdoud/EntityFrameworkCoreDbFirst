using EntityFrameworkCoreDbFirst.Models;
using System.Linq;

using System;
using EntityFrameworkCoreDbFirst.Controllers;

namespace EntityFrameworkCoreDbFirst {
    class Program {
        static void Main(string[] args) {

            var custCtrl = new CustomersController();

            var newCust = new Customer() {
                Id = 0, Name = "Meijer", State = "MN", Sales = 100000, Active = true
            };
            //var rc = custCtrl.Add(newCust);

            var cust = custCtrl.GetById(4);
            cust.Sales = 999999;
            var rc = custCtrl.Update(cust);
            cust = custCtrl.GetById(4);
            Console.WriteLine($"{cust.Id} | {cust.Name} | {cust.Sales} | {cust.State }");
            var rmCust = custCtrl.Delete(cust.Id);
            Console.WriteLine($"DELETED: {rmCust.Id} | {rmCust.Name} | {rmCust.Sales} | {rmCust.State }");

            var customers = custCtrl.GetAll();

            foreach (var c in customers) {
                Console.WriteLine($"{c.Id} | {c.Name} | {c.Sales} | {c.State }");
            }
        }
    }
}
