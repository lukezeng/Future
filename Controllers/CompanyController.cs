using Future.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace Future.Controllers
{
    public class CompanyController : ApiController
    {
        // GET api/company
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [ActionName("GetAllCompanies")]
        public List<Company> GetAllCompanies()
        {

            List<Company> companies = new List<Company>{
                   new Company{Name = "Google", Rating = "This is asdadasdasda"},
                   new Company{Name = "Amazon", Rating = "fdgsdgfsdfg"},
                   new Company{Name = "Goldman Sachs & Co", Rating = "This is asdadasdasda"},
                   new Company{Name = "J.P Morgen", Rating = "fdgsdgfsdfg"},
                   new Company{Name = "salesforce.com", Rating = "This is asdadasdasda"},
                   new Company{Name = "Intuit", Rating = "fdgsdgfsdfg"},
                   new Company{Name = "Wegmans Food Markets", Rating = "This is asdadasdasda"},
                   new Company{Name = "Cisco", Rating = "fdgsdgfsdfg"},
                   new Company{Name = "Marriott International", Rating = "This is asdadasdasda"},
                   new Company{Name = "Deloitte", Rating = "fdgsdgfsdfg"},
                   new Company{Name = "PricewaterhouseCoopers", Rating = "This is asdadasdasda"},
                   new Company{Name = "Ernst & Young", Rating = "fdgsdgfsdfg"},
                   new Company{Name = "KPMG", Rating = "This is asdadasdasda"},
                   new Company{Name = "Adobe Systems", Rating = "fdgsdgfsdfg"}
                   };
            companies.Add(new Company { Name = "Intel", Rating = "fdgsdgfsdfg" });
            companies.Add(new Company { Name = "Microsoft", Rating = "fdgsdgfsdfg" });
            companies.Add(new Company { Name = "Accenture", Rating = "fdgsdgfsdfg" });
            companies.Add(new Company { Name = "Four Seasons Hotels", Rating = "fdgsdgfsdfg" });
            companies.Add(new Company { Name = "Hyatt Hotels", Rating = "fdgsdgfsdfg" });
            companies.Add(new Company { Name = "HSBC", Rating = "fdgsdgfsdfg" });

            companies.Add(new Company { Name = "Swire", Rating = "fdgsdgfsdfg" });
            companies.Add(new Company { Name = "Bank of America Corp", Rating = "fdgsdgfsdfg" });
            companies.Add(new Company { Name = "Barclays", Rating = "fdgsdgfsdfg" });
            companies.Add(new Company { Name = "Credit Suisse", Rating = "fdgsdgfsdfg" });
            companies.Add(new Company { Name = "Morgan Stanley", Rating = "fdgsdgfsdfg" });
            companies.Add(new Company { Name = "The Blackstone Group", Rating = "fdgsdgfsdfg" });


            //Restaurants.Add(new Restaurant { Name = "Second Rfgh", Review = "fdgsdgfsdfg" });
            //var serializer = new JavaScriptSerializer();
            //var serializedResult = serializer.Serialize(companies);

            return companies;
        }

        [HttpPost]
        [ActionName("GetAllCompanyCEOs")]
        public List<CompanyCEO> GetAllCompanyCEOs()
        {

            List<CompanyCEO> companyCEOs = new List<CompanyCEO>{
                   new CompanyCEO{Name = "Google CEO", Age=50},
                   new CompanyCEO{Name = "Amazon CEO", Age=50},
                   new CompanyCEO{Name = "Goldman Sachs & Co CEO", Age=50},
                   new CompanyCEO{Name = "J.P Morgen CEO", Age=50},
                   new CompanyCEO{Name = "salesforce.com CEO", Age=50},
                   new CompanyCEO{Name = "Intuit CEO", Age=50},
                   new CompanyCEO{Name = "Wegmans Food Markets CEO", Age=50},
                   new CompanyCEO{Name = "Cisco CEO", Age=50},
                   new CompanyCEO{Name = "Marriott International CEO", Age=50},
                   new CompanyCEO{Name = "Deloitte CEO", Age=50},
                   new CompanyCEO{Name = "PricewaterhouseCoopers CEO", Age=50},
                   new CompanyCEO{Name = "Ernst & Young CEO", Age=50},
                   new CompanyCEO{Name = "KPMG CEO", Age=50},
                   new CompanyCEO{Name = "Adobe Systems CEO", Age=50}
                   };
            companyCEOs.Add(new CompanyCEO { Name = "Intel CEO", Age=50 });
            companyCEOs.Add(new CompanyCEO { Name = "Microsoft CEO", Age=50 });
            companyCEOs.Add(new CompanyCEO { Name = "Accenture CEO", Age=50 });
            companyCEOs.Add(new CompanyCEO { Name = "Four Seasons Hotels CEO", Age=50 });
            companyCEOs.Add(new CompanyCEO { Name = "Hyatt Hotels CEO", Age=50 });
            companyCEOs.Add(new CompanyCEO { Name = "HSBC CEO", Age=50 });

            companyCEOs.Add(new CompanyCEO { Name = "Swire CEO", Age=50 });
            companyCEOs.Add(new CompanyCEO { Name = "Bank of America Corp CEO", Age=50 });
            companyCEOs.Add(new CompanyCEO { Name = "Barclays CEO", Age=50 });
            companyCEOs.Add(new CompanyCEO { Name = "Credit Suisse CEO", Age=50 });
            companyCEOs.Add(new CompanyCEO { Name = "Morgan Stanley CEO", Age=50 });
            companyCEOs.Add(new CompanyCEO { Name = "The Blackstone Group CEO", Age=50 });


            //Restaurants.Add(new Restaurant { Name = "Second Rfgh", Review = "fdgsdgfsdfg" });
            //var serializer = new JavaScriptSerializer();
            //var serializedResult = serializer.Serialize(companies);

            return companyCEOs;
        }
    }
}