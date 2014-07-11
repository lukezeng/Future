using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Future.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "This is the ViewBag.Message of the Index Page.";

            return View();
        }

        public ActionResult TestingRWD()
        {
            ViewBag.Message = "This is the ViewBag.Message of the Index Page.";

            return View();
        }

        public ActionResult TestingAngularJS()
        {
            ViewBag.Message = "This is the ViewBag.Message of the Index Page.";

            return View();
        }

        public ActionResult About()
        {
            //This is testing the build-in SqlClient 
            //Connection tested sucessfully on 11/6/2013
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlDataReader rdr = null;
            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                SqlCommand cmd = new SqlCommand("SELECT AboutInfo FROM ViFutureInfo", conn);

                //
                // 4. Use the connection
                //

                // get query results
                rdr = cmd.ExecuteReader();

                // print the Title of each Movie
                while (rdr.Read())
                {
                    ViewBag.AboutInfo = rdr.GetString(0);
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
            ViewBag.Message = "This is the ViewBag.Message of the Index Page.";

            return View();
        }

        public ActionResult Contact()
        {
            //This is testing the build-in SqlClient 
            //Connection tested sucessfully on 11/6/2013
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlDataReader rdr = null;
            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                SqlCommand cmd = new SqlCommand("SELECT * FROM ViFutureInfo", conn);

                //
                // 4. Use the connection
                //

                // get query results
                rdr = cmd.ExecuteReader();

                // print the Title of each Movie
                while (rdr.Read())
                {
                    ViewBag.MainPhone = rdr.GetString(1);
                    ViewBag.AfterHourPhone = rdr.GetString(2);
                    ViewBag.SupportEmail = rdr.GetString(3);
                    ViewBag.MarketingEmail = rdr.GetString(4);
                    ViewBag.GeneralEmail = rdr.GetString(5);
                    ViewBag.AddressSt = rdr.GetString(6);
                    ViewBag.AddressCity = rdr.GetString(7);
                    ViewBag.AddressState = rdr.GetString(8);
                    ViewBag.AddressZipCode = rdr.GetString(9);
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
            ViewBag.Message = "This is the ViewBag.Message of the Index Page.";

            return View();
        }

        [Authorize]
        public ActionResult MyProfile()
        {
            //This is testing the build-in SqlClient 
            //Connection tested sucessfully on 11/6/2013
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlDataReader rdr = null;
            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                SqlCommand cmd = new SqlCommand("SELECT UserProfilePic FROM UserProfile where UserName = '" + Request.Cookies["UserName"].Value + "'", conn);

                //
                // 4. Use the connection
                //

                // get query results
                rdr = cmd.ExecuteReader();

                // print the Title of each Movie
                while (rdr.Read())
                {
                    if (!rdr.IsDBNull(0))
                    {
                        ViewBag.UserProfilePic = rdr.GetString(0);
                    } else {
                        ViewBag.UserProfilePic = "/Files/Users/_DefaultUser/_DefaultProfilePic/DefaultProfilePic.jpg";
                    }

                    
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
            ViewBag.Message = "This is the ViewBag.Message of the Index Page.";
            


            return View();
        }
    }
}
