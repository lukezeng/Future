using Future.Models;
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
        public String UpdateProfilePic(string profilePicName)
        {
            String profilePicLocation = "/Files/Users/" + Request.Cookies["UserName"].Value + "/ProfilePic/" + profilePicName;
            //This is testing the build-in SqlClient 
            //Connection tested sucessfully on 11/6/2013
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                SqlCommand cmd = new SqlCommand("UPDATE UserProfile SET UserProfilePic = '" + profilePicLocation + "' where UserName = '" + Request.Cookies["UserName"].Value + "'", conn);

                //
                // 4. Use the connection
                //
                cmd.ExecuteNonQuery();
            }
            finally
            {
                // 5. Close the connection
                conn.Close();
            }
            return profilePicLocation;
        }

        [HttpPost]
        public String GetRestautants()
        {
            List<Restaurant> restaurants = new List<Restaurant>{
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
            restaurants.Add(new Restaurant { Name = "Second Rsdfsdf", Review = "fdgsdgfsdfg" });
            restaurants.Add(new Restaurant { Name = "Second Rasd", Review = "fdgsdgfsdfg" });
            restaurants.Add(new Restaurant { Name = "Second Rsdf", Review = "fdgsdgfsdfg" });
            restaurants.Add(new Restaurant { Name = "Second Rsdff", Review = "fdgsdgfsdfg" });
            restaurants.Add(new Restaurant { Name = "Second Rdfg", Review = "fdgsdgfsdfg" });
            restaurants.Add(new Restaurant { Name = "Second Rfgh", Review = "fdgsdgfsdfg" });

            restaurants.Add(new Restaurant { Name = "Second Rsdfsdf", Review = "fdgsdgfsdfg" });
            restaurants.Add(new Restaurant { Name = "Second Rasd", Review = "fdgsdgfsdfg" });
            restaurants.Add(new Restaurant { Name = "Second Rsdf", Review = "fdgsdgfsdfg" });
            restaurants.Add(new Restaurant { Name = "Second Rsdff", Review = "fdgsdgfsdfg" });
            restaurants.Add(new Restaurant { Name = "Second Rdfg", Review = "fdgsdgfsdfg" });
            restaurants.Add(new Restaurant { Name = "Second Rfgh", Review = "fdgsdgfsdfg" });

            var serializer = new JavaScriptSerializer();
            var serializedResult = serializer.Serialize(restaurants);

            return serializedResult;
        }


    }
}
