using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SRPAndDesignPatterns_V1.Data;
using SRPAndDesignPatterns_V1.Models;
using SRPAndDesignPatterns_V1.Models.Interface;
using SRPAndDesignPatterns_V1.Repository;
using SRPAndDesignPatterns_V1.Repository.TaxCalculator;

namespace SRPAndDesignPatterns_V1.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext db;
        public CustomerController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View();
        }

        //SRP
        [HttpPost]
        public IActionResult Search(string criteria, string searchby)
        {
            CustomerSearch search = new CustomerSearch(db);

            List<Customer> model = search.GetData(criteria, searchby);
            ViewBag.Criteria = criteria;
            ViewBag.SearchBy = searchby;
            return View(model);
        }
        [HttpPost]
        public FileResult Export(string criteria, string searchby)
        {
            CustomerSearch search = new CustomerSearch(db);
            List<Customer> data = search.GetData(criteria, searchby);
            string exportData = CustomerDataExporter.ExportToCSV(data);
            return File(System.Text.ASCIIEncoding.ASCII.GetBytes(exportData),
            "application/Excel");
        }

        #region OCP
        public IActionResult Tax()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Tax(IncomeDetails obj)
        {
            ICountryTaxCalculator t = null;
            switch (obj.Country)
            {
                case "USA":
                    t = new TaxCalculatorForUS();
                    break;

                case "UK":
                    t = new TaxCalculatorForUK();
                    break;

                case "IN":
                    t = new TaxCalculatorForIN();
                    break;
            }
            t.TotalIncome = obj.TotalIncome;
            t.TotalDeduction = obj.TotalDeduction;
            TaxCalculator calculator = new TaxCalculator();
            ViewBag.TotalTax = calculator.Calculate(t);

            return View(obj);
        }

        #endregion
    }
}