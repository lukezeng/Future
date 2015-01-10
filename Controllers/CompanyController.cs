using Future.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        readonly SqlConnection _conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        // GET api/company
        public IEnumerable<Company> Get()
        {
            var companies = new List<Company> { };
            //This is testing the build-in SqlClient 
            //Connection tested sucessfully on 11/6/2013
            SqlDataReader rdr = null;
            try
            {
                // 2. Open the connection
                _conn.Open();

                // 3. Pass the connection to a command object
                var cmd = new SqlCommand("SELECT * FROM Companies", _conn);

                //
                // 4. Use the connection
                //

                // get query results
                rdr = cmd.ExecuteReader();

                // print the Title of each Movie
                while (rdr.Read())
                {
                    companies.Add(new Company { Id = rdr.GetInt32(0), Name = rdr.GetString(1), Rating = rdr.GetString(2) });
                }
            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // 5. Close the connection
                _conn.Close();
            }
            return companies;
        }

        // GET api/company/5
        public IEnumerable<Company> Get(int id)
        {
            var companies = new List<Company> {};
            SqlDataReader rdr = null;
            try
            {
                _conn.Open();
                var cmd = new SqlCommand("SELECT * FROM Companies WHERE Id=" + id, _conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    companies.Add(new Company { Id = rdr.GetInt32(0), Name = rdr.GetString(1), Rating = rdr.GetString(2) });
                }
            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // 5. Close the connection
                _conn.Close();
            }
            return companies;
        }

        // PUT api/company/5
        public string Post(Company company)
        {
            //This is testing the build-in SqlClient 
            //Connection tested sucessfully on 11/6/2013
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            try
            {
                _conn.Open();
                var cmd = new SqlCommand("INSERT INTO Companies (Name, Rating) VALUES ('" +company.Name + "', '" + company.Rating + "');" , _conn);
                cmd.ExecuteNonQuery();

            }
            finally
            {
                _conn.Close();
            }
            return "INSERT INTO Companies (Name, Rating) VALUES ('" + company.Name + "', '" + company.Rating + "');";
        }

        // DELETE api/company/5
        public void Delete(int id)
        {
            try
            {
                _conn.Open();
                var cmd = new SqlCommand("DELETE FROM companies where id = " + id, _conn);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}