using SRPAndDesignPatterns_V1.Data;
using SRPAndDesignPatterns_V1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRPAndDesignPatterns_V1.Repository
{
    public class CustomerSearch
    {
        private  ApplicationDbContext db;

        public CustomerSearch(ApplicationDbContext _db)
        {
            db = _db;
        }

        public List<Customer> GetData(string criteria, string searchby)
        {
            List<Customer> data = null;
            switch (searchby)
            {
                case "companyname":
                    data = SearchByCompanyName(criteria);
                    break;
                case "contactname":
                    data = SearchByContactName(criteria);
                    break;
                case "country":
                    data = SearchByCountry(criteria);
                    break;
            }
            return data;
        }



        public  List<Customer> SearchByCountry(string country)
        {
           
                var query = from c in db.Customers
                            where c.Country.Contains(country)
                            orderby c.CustomerID ascending
                            select c;
                return query.ToList();
           
        }

        public  List<Customer> SearchByCompanyName(string company)
        {
            
                var query = from c in db.Customers
                            where c.CompanyName.Contains(company)
                            orderby c.CustomerID ascending
                            select c;
                return query.ToList();
           
        }
        public  List<Customer> SearchByContactName(string contact)
        {
            
                var query = from c in db.Customers
                            where c.ContactName.Contains(contact)
                            orderby c.CustomerID ascending
                            select c;
                return query.ToList();
          
        }

    }
}
