using ELMS.BLL.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace ELMS.UI.Web.Controllers
{
    public class EducationProfileController : Controller
    {
        private Guid userId;
        private StandardOptionsService standardOptionsSrv;

        public EducationProfileController()
        {
            this.standardOptionsSrv = new StandardOptionsService();
        }

        // GET: EducationProfile
        public ActionResult Index()
        {
            this.userId = Guid.Parse(HttpContext.User.Identity.GetUserId());
            //check if user has education profile
            //check if user has education history
            return View();
        }

        public PartialViewResult EducationProfile()
        {
            this.userId = Guid.Parse(HttpContext.User.Identity.GetUserId());

            return PartialView("_EducationProfile");
        }

        public PartialViewResult EducationHistory()
        {
            this.userId = Guid.Parse(HttpContext.User.Identity.GetUserId());

            return PartialView("_EducationHistory");
        }
    }
}