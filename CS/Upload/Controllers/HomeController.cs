using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Upload.Helpers;

namespace Upload.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        [HttpPost]
        public ActionResult Submit() {
            SaveFilesHelper.Save(this.HttpContext);
            return View("Index");
        }

        public ActionResult FileUpload() {
            SaveFilesHelper.Save(this.HttpContext);
            return null;
        }
    }
}