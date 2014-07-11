using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Future.Controllers
{
    public class AjaxHandlerController : Controller
    {
        //
        // GET: /AjaxTest/
        [HttpGet]
        public String FirstAjax()
        {
            return "abcget";
        }

        [HttpPost]
        public String UpdateProfilePic(string ProfilePicName)
        {
            String ProfilePicLocation = "/Files/Users/" + Request.Cookies["UserName"].Value + "/ProfilePic/" + ProfilePicName;
            //This is testing the build-in SqlClient 
            //Connection tested sucessfully on 11/6/2013
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlDataReader rdr = null;
            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                SqlCommand cmd = new SqlCommand("UPDATE UserProfile SET UserProfilePic = '" + ProfilePicLocation + "' where UserName = '" + Request.Cookies["UserName"].Value + "'", conn);

                //
                // 4. Use the connection
                //
                cmd.ExecuteNonQuery();
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
            return ProfilePicLocation;
        }

        [HttpPost]
        public String GetRestautants(string ProfilePicName)
        {
            List<Restaurant> Restaurants = new List<Restaurant>{
                   new Restaurant{Name = "First R", Review = "This is asdadasdasda"},
                   new Restaurant{Name = "Second R", Review = "fdgsdgfsdfg"},
                   new Restaurant{Name = "First R", Review = "This is asdadasdasda"},
                   new Restaurant{Name = "Second R", Review = "fdgsdgfsdfg"},
                   new Restaurant{Name = "First R", Review = "This is asdadasdasda"},
                   new Restaurant{Name = "Second R", Review = "fdgsdgfsdfg"},
                   new Restaurant{Name = "First R", Review = "This is asdadasdasda"},
                   new Restaurant{Name = "Second R", Review = "fdgsdgfsdfg"},
                   new Restaurant{Name = "First R", Review = "This is asdadasdasda"},
                   new Restaurant{Name = "Second R", Review = "fdgsdgfsdfg"},
                   new Restaurant{Name = "First R", Review = "This is asdadasdasda"},
                   new Restaurant{Name = "Second R", Review = "fdgsdgfsdfg"},
                   new Restaurant{Name = "First R", Review = "This is asdadasdasda"},
                   new Restaurant{Name = "Second R", Review = "fdgsdgfsdfg"}
                   };
            Restaurants.Add(new Restaurant { Name = "Second Rsdfsdf", Review = "fdgsdgfsdfg" });
            Restaurants.Add(new Restaurant { Name = "Second Rasd", Review = "fdgsdgfsdfg" });
            Restaurants.Add(new Restaurant { Name = "Second Rsdf", Review = "fdgsdgfsdfg" });
            Restaurants.Add(new Restaurant { Name = "Second Rsdff", Review = "fdgsdgfsdfg" });
            Restaurants.Add(new Restaurant { Name = "Second Rdfg", Review = "fdgsdgfsdfg" });
            Restaurants.Add(new Restaurant { Name = "Second Rfgh", Review = "fdgsdgfsdfg" });

            Restaurants.Add(new Restaurant { Name = "Second Rsdfsdf", Review = "fdgsdgfsdfg" });
            Restaurants.Add(new Restaurant { Name = "Second Rasd", Review = "fdgsdgfsdfg" });
            Restaurants.Add(new Restaurant { Name = "Second Rsdf", Review = "fdgsdgfsdfg" });
            Restaurants.Add(new Restaurant { Name = "Second Rsdff", Review = "fdgsdgfsdfg" });
            Restaurants.Add(new Restaurant { Name = "Second Rdfg", Review = "fdgsdgfsdfg" });
            Restaurants.Add(new Restaurant { Name = "Second Rfgh", Review = "fdgsdgfsdfg" });

            //Restaurants.Add(new Restaurant { Name = "Second Rfgh", Review = "fdgsdgfsdfg" });
            var serializer = new JavaScriptSerializer();
            var serializedResult = serializer.Serialize(Restaurants);

            return serializedResult;
        }


    }
}
