using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class OrdersController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Orders
        public ActionResult Index()
        {

            ////List<Customer> OrderAndCustomerList = db.Customers.ToList();
            IList<Order> orders = db.Orders.ToList();
            return View(orders);
        }

        // GET: Doctors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            {
            }
            Order doctor = db.Orders.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // GET: Doctors/Create
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Invoice(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}

            //OrderViewModel orderViewModel = new OrderViewModel();
            //Customer order = db.Customers.Find(id);
            //if (orderViewModel == null)
            //{
            //    return HttpNotFound();
            //}
            //List<Customer> OrderAndCustomerList = db.Customers.ToList();
            //return View(OrderAndCustomerList);
        }

        public ActionResult SaveOrder(Order order)
        {
            var newOrder = new Order
            {
                customer_id = order.customer_id,
                Date = DateTime.Now.ToString(),
            };


            //string result = "Error! Order Is Not Complete!";
            //if (name != null && address != null && order != null)
            //{
                
                //Customer model = new Customer();
                //model.CustomerID = model.CustomerID;
                //model.Name = name;
                //model.Address = address;
                //model.OrderDate = DateTime.Now.ToString();
                //db.Customers.Add(model);

                //foreach (var item in order)
                //{
                    
                    //Order O = new Order();
                    //O.OrderID = O.OrderID;
                    //O.ProductName = item.ProductName;
                    //O.Quantity = item.Quantity;
                    //O.Price = item.Price;
                    //O.Amount = item.Amount;
                    //O.CustomerID = item.CustomerID;
                    //db.Orders.Add(O);
            //    }
            //    db.SaveChanges();
            //    result = "Success! Order Is Complete!";
            //}
            //return Json(result, JsonRequestBehavior.AllowGet);
        }


    }
}