using Future.Models;
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
    public class RestaurantController : ApiController
    {
        // GET api/restaurant
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/restaurant/5
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public List<Restaurant> GetAllRestaurants()
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

            restaurants.Add(new Restaurant { Name = "Second Rsdff", Review = "fdgsdgfsdfg" });
            restaurants.Add(new Restaurant { Name = "Second Rdfg", Review = "fdgsdgfsdfg" });
            restaurants.Add(new Restaurant { Name = "Second Rfgh", Review = "fdgsdgfsdfg" });

            return restaurants;
        }

        // PUT api/restaurant/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/restaurant/5
        public void Delete(int id)
        {
        }
    }
}
