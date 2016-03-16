using AutoMapper;
using ELMS.BLL.DataTransferObjects;
using ELMS.BLL.ServiceLayer;
using ELMS.UI.Web.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELMS.UI.Web.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private PersonService personSrv;
        private AddressService addressSrv;
        private ContactService contactSrv;
        private StandardOptionsService standardOptionsSrv;
        private Guid userId;

        public ProfileController()
        {
            this.personSrv = new PersonService();
            this.addressSrv = new AddressService();
            this.contactSrv = new ContactService();
            this.standardOptionsSrv = new StandardOptionsService();
        }

        // GET: Profile
        public ActionResult Index()

        {
            //check if user has a person object
            this.userId = Guid.Parse(HttpContext.User.Identity.GetUserId());
            var map = new MapperConfiguration(cfg => cfg.CreateMap<PersonDTO, ProfileIndex_Person>()).CreateMapper();

            var db = this.personSrv.GetPerson(userId);
            db.Wait();

            ProfileIndex_Person dto = map.Map<ProfileIndex_Person>(db.Result);
            //if not, create one
            if (dto == null)
            {
                personSrv.CreatePerson(userId).Wait();
                db = personSrv.GetPerson(userId);
                db.Wait();
                dto = map.Map<ProfileIndex_Person>(db.Result);
            }

            return View(dto);
        }

        public ActionResult Person()
        {
            this.userId = Guid.Parse(HttpContext.User.Identity.GetUserId());
            var map = new MapperConfiguration(cfg => cfg.CreateMap<PersonDTO, ProfileIndex_Person>()).CreateMapper();

            var db = this.personSrv.GetPerson(userId);
            db.Wait();

            ProfileIndex_Person dto = map.Map<ProfileIndex_Person>(db.Result);
            if (dto == null)
            {
                personSrv.CreatePerson(userId).Wait();
                db = personSrv.GetPerson(userId);
                db.Wait();
                dto = map.Map<ProfileIndex_Person>(db.Result);
            }
            return PartialView("_PersonEdit", dto);
        }

        [HttpPost]
        public ActionResult PersonUpdate(ProfileIndex_Person model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            this.userId = Guid.Parse(HttpContext.User.Identity.GetUserId());
            var map = new MapperConfiguration(cfg => cfg.CreateMap<ProfileIndex_Person, PersonDTO>()).CreateMapper();
            PersonDTO dto = new PersonDTO();
            dto = map.Map<PersonDTO>(model);
            dto = personSrv.EditPerson(userId, dto).Result;
            return RedirectToAction("Person");
        }

        public ActionResult Address()
        {
            this.userId = Guid.Parse(HttpContext.User.Identity.GetUserId());
            var map = new MapperConfiguration(cfg => cfg.CreateMap<AddressDTO, ProfileIndex_Address>()).CreateMapper();

            var db = this.addressSrv.GetAddress(userId);
            db.Wait();

            ProfileIndex_Address dto = map.Map<ProfileIndex_Address>(db.Result);
            if (dto == null)
            {
                addressSrv.CreateAddress(userId).Wait();
                db = addressSrv.GetAddress(userId);
                db.Wait();
                dto = map.Map<ProfileIndex_Address>(db.Result);
            }
            dto.Countries = standardOptionsSrv.GetCountries().Result;
            dto.States = standardOptionsSrv.GetStates().Result;
            return PartialView("_AddressEdit", dto);
        }

        [HttpPost]
        public ActionResult AddressUpdate(ProfileIndex_Address model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            this.userId = Guid.Parse(HttpContext.User.Identity.GetUserId());
            var map = new MapperConfiguration(cfg => cfg.CreateMap<ProfileIndex_Address, AddressDTO>()).CreateMapper();
            AddressDTO dto = new AddressDTO();
            dto = map.Map<AddressDTO>(model);
            dto = addressSrv.EditAddress(userId, dto).Result;
            return RedirectToAction("Address");
        }

        public ActionResult Contact()
        {
            this.userId = Guid.Parse(HttpContext.User.Identity.GetUserId());
            var map = new MapperConfiguration(cfg => cfg.CreateMap<ContactDTO, ProfileIndex_Contact>()).CreateMapper();

            var db = this.contactSrv.GetContact(userId);
            db.Wait();

            ProfileIndex_Contact dto = map.Map<ProfileIndex_Contact>(db.Result);
            if (dto == null)
            {
                contactSrv.CreateContact(userId).Wait();
                db = contactSrv.GetContact(userId);
                db.Wait();
                dto = map.Map<ProfileIndex_Contact>(db.Result);
            }
            return PartialView("_ContactEdit", dto);
        }

        [HttpPost]
        public ActionResult ContactUpdate(ProfileIndex_Contact model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            this.userId = Guid.Parse(HttpContext.User.Identity.GetUserId());
            var map = new MapperConfiguration(cfg => cfg.CreateMap<ProfileIndex_Contact, ContactDTO>()).CreateMapper();
            ContactDTO dto = new ContactDTO();
            dto = map.Map<ContactDTO>(model);
            dto = contactSrv.EditContact(userId, dto).Result;
            return RedirectToAction("Contact");
        }
    }
}