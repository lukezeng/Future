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
        // GET api/company
        public IEnumerable<Company> Get()
        {
            List<Company> companies = new List<Company> { };
            //This is testing the build-in SqlClient 
            //Connection tested sucessfully on 11/6/2013
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlDataReader rdr = null;
            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                SqlCommand cmd = new SqlCommand("SELECT * FROM Companies", conn);

                //
                // 4. Use the connection
                //

                // get query results
                rdr = cmd.ExecuteReader();

                // print the Title of each Movie
                while (rdr.Read())
                {
                    companies.Add(new Company { Name = rdr.GetString(1), Rating = rdr.GetString(2) });
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
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return companies;
        }

        // GET api/company/5
        public IEnumerable<Company> Get(int id)
        {
            List<Company> companies = new List<Company> { };
            //This is testing the build-in SqlClient 
            //Connection tested sucessfully on 11/6/2013
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlDataReader rdr = null;
            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                SqlCommand cmd = new SqlCommand("SELECT * FROM Companies WHERE Id=" + id, conn);

                //
                // 4. Use the connection
                //

                // get query results
                rdr = cmd.ExecuteReader();

                // print the Title of each Movie
                while (rdr.Read())
                {
                    companies.Add(new Company { Name = rdr.GetString(1), Rating = rdr.GetString(2) });
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
                if (conn != null)
                {
                    conn.Close();
                }
            }
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