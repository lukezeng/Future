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
        public IEnumerable<Company> Get()
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

            return companies;
        }

        // GET api/company/5
        public IEnumerable<Company> Get(int id)
        {
            List<Company> companies = new List<Company> { new Company { Name = "Google", Rating = "This is asdadasdasda" }  };
            return companies;
        }

        // PUT api/company/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/company/5
        public void Delete(int id)
        {
        }
    }
}