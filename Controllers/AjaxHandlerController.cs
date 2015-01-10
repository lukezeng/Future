using System;
using System.Data.SqlClient;
using System.Web.Mvc;
namespace Future.Controllers
{
    public class AjaxHandlerController : Controller
    {
        [HttpPost]
        public String UpdateProfilePic(string profilePicName)
        {
            var profilePicLocation = "/Files/Users/" + Request.Cookies["UserName"].Value + "/ProfilePic/" + profilePicName;
            var conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            try
            {
                conn.Open();
                var cmd = new SqlCommand("UPDATE UserProfile SET UserProfilePic = '" + profilePicLocation + "' where UserName = '" + Request.Cookies["UserName"].Value + "'", conn);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
            return profilePicLocation;
        }
    }
}
