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
        private Guid userId;

        public ProfileController()
        {
            this.personSrv = new PersonService();
            this.addressSrv = new AddressService();
            this.contactSrv = new ContactService();
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
            return PartialView("AddressEdit",dto);
        }

        [HttpPost]
        public ActionResult AddressUpdate()
        {
            ProfileIndex_Address dto = new ProfileIndex_Address();

            return PartialView("AddressEdit", dto);
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
            return PartialView("ContactEdit", dto);
        }
    }
}