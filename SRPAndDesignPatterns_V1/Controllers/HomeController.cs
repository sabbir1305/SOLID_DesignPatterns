using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SRPAndDesignPatterns_V1.Models;
using SRPAndDesignPatterns_V1.Repository;

namespace SRPAndDesignPatterns_V1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult ProcessOrder()
        {
            return View();
        }
        [HttpPost]
            public IActionResult ProcessOrder(string paymentmode)
        {
            Customer customer = new Customer();
            Address address = new Address();
            CardInfo cardInfo = null;
            Order order = new Order();
            order.Id = new Random().Next(1000, 9000);
            order.Customer = customer;
            order.ShippingAddress = address;
            order.CardInfo = cardInfo;
            if (paymentmode == "card")
            {
                OnlineOrderProcessor oop = new OnlineOrderProcessor();
                cardInfo = new CardInfo();
                cardInfo.CardNo = "5555555555554444";
                cardInfo.ExpiryMonth = 12;
                cardInfo.ExpiryYear = 2015;
                order.CardInfo = cardInfo;
                oop.ValidateCardInfo(cardInfo);
                oop.ValidateShippingAddress(address);
                oop.ProcessOrder(order);
            }
            else
            {
                CashOnDeliveryOrderProcessor codop = new CashOnDeliveryOrderProcessor();
                codop.ValidateShippingAddress(address);
                codop.ProcessOrder(order);
            }
            return View("Success", order);
        }

        public IActionResult Success()
        {
            return View();
        }

    }
}
