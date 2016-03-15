using ELMS.DAL.Standards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ELMS.BLL.DataTransferObjects;
using AutoMapper;

namespace ELMS.BLL.ServiceLayer
{
    public class ContactService : Base
    {
        public async Task<int> CreateContact(Guid userId)
        {
            Contact p = new Contact();
            var person = await context.People.Where(e => e.Active && e.UserId == userId).FirstOrDefaultAsync().ConfigureAwait(false);
            p.PersonId = person.Id;
            p.CreatedBy = userId;
            person.Contact.Add(p);
            var task = await context.SaveChangesAsync().ConfigureAwait(false);
            return task;
        }

        public async Task<ContactDTO> GetContact(Guid userId)
        {
            var map = new MapperConfiguration(cfg => cfg.CreateMap<Contact, ContactDTO> ()).CreateMapper();
            var db = await context.Contacts.Where(e => e.Active && e.Person.UserId == userId).FirstOrDefaultAsync().ConfigureAwait(false);
            ContactDTO dto = map.Map<ContactDTO>(db);
            return dto;
        }
    }
}
