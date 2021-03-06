﻿using ELMS.BLL.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using AutoMapper;
using ELMS.BLL.DataTransferObjects;
using ELMS.UI.Web.Models;

namespace ELMS.UI.Web.Controllers
{
    public class EducationProfileController : Controller
    {
        private Guid userId;
        private StandardOptionsService standardOptionsSrv;
        private EducationProfileService educationProfileService;
        private EducationHistoryService educationHistoryService;

        public EducationProfileController()
        {
            this.standardOptionsSrv = new StandardOptionsService();
            this.educationProfileService = new EducationProfileService();
            this.educationHistoryService = new EducationHistoryService();
        }

        // GET: EducationProfile
        public ActionResult Index()
        {
            this.userId = Guid.Parse(HttpContext.User.Identity.GetUserId());
            return View();
        }

        public PartialViewResult EducationProfile()
        {
            //check if user has education profile
            this.userId = Guid.Parse(HttpContext.User.Identity.GetUserId());
            var map = new MapperConfiguration(cfg => cfg.CreateMap<EducationProfileDTO, EducationProfileIndex_EducationProfile>()).CreateMapper();

            var db = this.educationProfileService.GetEducationProfile(userId);
            db.Wait();

            EducationProfileIndex_EducationProfile dto = map.Map<EducationProfileIndex_EducationProfile>(db.Result);
            if (dto == null)
            {
                educationProfileService.CreateEducationProfile(userId).Wait();
                db = educationProfileService.GetEducationProfile(userId);
                db.Wait();
                dto = map.Map<EducationProfileIndex_EducationProfile>(db.Result);
            }
            if (dto.CountyId.HasValue)
            {
                dto.Counties = new List<SelectListItemDTO>();
                dto.Counties.Add(standardOptionsSrv.GetCountyBiId(dto.CountyId.Value).Result);
            }
            else
            {
                dto.Counties = standardOptionsSrv.GetCounties(null).Result;
            }
            dto.EducationLevels = standardOptionsSrv.GetEducationLevels().Result;
            dto.GraduationYears = standardOptionsSrv.GetGraduationYears();
            dto.partialFormName = "educationProfile";
            return PartialView("_EducationProfile", dto);
        }

        [HttpPost]
        public ActionResult EducationProfileUpdate(EducationProfileIndex_EducationProfile model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            this.userId = Guid.Parse(HttpContext.User.Identity.GetUserId());
            var map = new MapperConfiguration(cfg => cfg.CreateMap<EducationProfileIndex_EducationProfile, EducationProfileDTO>()).CreateMapper();
            EducationProfileDTO dto = new EducationProfileDTO();
            dto = map.Map<EducationProfileDTO>(model);
            dto = educationProfileService.EditEducationProfile(userId, dto).Result;
            return RedirectToAction("EducationProfile");
        }

        [HttpGet]
        public JsonResult GetFilteredCounties(string filter)
        {
            return new JsonResult {
                Data = standardOptionsSrv.GetCounties(filter: filter).Result,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        public PartialViewResult EducationHistory()
        {
            //check if user has education history
            this.userId = Guid.Parse(HttpContext.User.Identity.GetUserId());

            return PartialView("_EducationHistory");
        }
    }
}