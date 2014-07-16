using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Future.Models
{
    public class Company  
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rating { get; set; }
        public string ImageUrl { get; set; }
        public int GDP { get; set; }
    }
}