using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Http;
using Future.Models;

namespace Future.Controllers.api
{
    public class CompanyController : ApiController
    {
        static readonly string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        // GET api/company
        public IEnumerable<Company> Get()
        {
            var vifuturedbEntities = new vifuturedbEntities();
            var companies = vifuturedbEntities.Companies.ToList();
            return companies;
        }

        // GET api/company/5
        public Company Get(int id)
        {
            var vifuturedbEntities = new vifuturedbEntities();
            var company = vifuturedbEntities.Companies.Single(x => x.Id == id);
            return company;
        }

        // PUT api/company/5
        public string Post(Company company)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    var cmd =
                        new SqlCommand(
                            "INSERT INTO Companies (Name, Rating) VALUES ('" + company.Name + "', '" + company.Rating +
                            "');", conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    // ignored
                }
            }
            return "INSERT INTO Companies (Name, Rating) VALUES ('" + company.Name + "', '" + company.Rating + "');";
        }

        // DELETE api/company/5
        public void Delete(int id)
        {
            var vifuturedbEntities = new vifuturedbEntities();
            var companyToDelete = vifuturedbEntities.Companies.SingleOrDefault(x=>x.Id == id);
            vifuturedbEntities.Companies.Remove(companyToDelete);
            vifuturedbEntities.SaveChanges();
        }
    }
}