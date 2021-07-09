using EntityFrameworkCoreDbFirst.Models;
using System.Linq;

using System;
using EntityFrameworkCoreDbFirst.Controllers;

namespace EntityFrameworkCoreDbFirst {
    class Program {
        static void Main(string[] args) {

            var ordCtrl = new OrdersController();

            var order = new Order() {
                Id = 0, CustomerId = 1, Date = new DateTime(2021, 7, 9), Description = "Order 1"
            };
            var rc = ordCtrl.Add(order);
            rc.Description = "Order 1a";
            var rc1 = ordCtrl.Update(order);
            var rc2 = ordCtrl.GetAll();
            var rc3 = ordCtrl.GetById(1);
            var rc4 = ordCtrl.Delete(rc3.Id);
        }
        static void TestCustomer() { 

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
