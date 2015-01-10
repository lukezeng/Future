using System;
using System.Collections.Generic;
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
        public IEnumerable<Company> Get(int id)
        {
            var companies = new List<Company>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    var cmd = new SqlCommand("SELECT * FROM Companies WHERE Id=" + id, conn);
                    var rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        companies.Add(new Company
                        {
                            Id = rdr.GetInt32(0),
                            Name = rdr.GetString(1),
                            Rating = rdr.GetString(2)
                        });
                    }
                }
                catch (Exception)
                {
                    // ignored
                }
            }
            return companies;
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
            using (var conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    var cmd = new SqlCommand("DELETE FROM companies where id = " + id, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    // ignored
                }
            }      
        }
    }
}