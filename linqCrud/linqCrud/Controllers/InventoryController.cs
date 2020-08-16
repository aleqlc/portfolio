using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using linqCrud.Models;

namespace linqCrud.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct()
        {
            InventoryDataDataContext inventory = new InventoryDataDataContext();
            string productName = Request["name"];
            decimal amount = Convert.ToDecimal(Request["amount"]);

            inventory.Products.InsertOnSubmit(new Products
            {
                ProductName = productName,
                ProductAmount = amount
            });
            inventory.SubmitChanges();
            return RedirectToAction("Display");
        }

        public ActionResult Display()
        {
            InventoryDataDataContext inventory = new InventoryDataDataContext();
            var products = (from data in inventory.Products select data).ToList();
            ViewBag.productsList = products;
            return View();
        }

        public ActionResult UpdateProduct()
        {
            InventoryDataDataContext inventory = new InventoryDataDataContext();

            string name = Request["name"];
            decimal amount = Convert.ToDecimal(Request["amount"]);
            int pId = Convert.ToInt32(Request["pId"]);

            var product = (from data in inventory.Products where data.ProductId == pId select data).FirstOrDefault();
            product.ProductName = name;
            product.ProductAmount = amount;
            inventory.SubmitChanges();

            return RedirectToAction("Display");
        }

        public ActionResult DeleteProduct()
        {
            InventoryDataDataContext inventory = new InventoryDataDataContext();
            object pId = Url.RequestContext.RouteData.Values["id"];

            var product = (from data in inventory.Products where data.ProductId == Convert.ToInt32(pId) select data);
            inventory.Products.DeleteAllOnSubmit(product);
            inventory.SubmitChanges();

            return RedirectToAction("Display");
        }
    }
}