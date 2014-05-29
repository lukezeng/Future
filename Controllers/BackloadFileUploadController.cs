using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Future.Controllers
{
    public class BackloadFileUploadController : Controller
    {
        //
        // GET: /BackupDemo/
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}
