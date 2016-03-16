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
    public class PersonService : Base
    {
        public async Task<PersonDTO> EditPerson(Guid userId, PersonDTO dto)
        {
            Person p = await context.People.Where(e => e.Active && e.UserId == userId).FirstOrDefaultAsync().ConfigureAwait(false);
            var map = new MapperConfiguration(cfg => cfg.CreateMap<PersonDTO, Person>()).CreateMapper();
            p = map.Map<PersonDTO, Person>(dto, p);
            p.ModifiedBy = userId;
            int x = await context.SaveChangesAsync().ConfigureAwait(false);
            var task = await GetPerson(userId);
            return task;
        }

        public async Task<int> CreatePerson(Guid userId)
        {
            Person p = new Person();
            p.UserId = userId;
            p.CreatedBy = userId;
            context.People.Add(p);
            var task = await context.SaveChangesAsync().ConfigureAwait(false);
            return task;
        }

        public async Task<PersonDTO> GetPerson(Guid userId)
        {
            var map = new MapperConfiguration(cfg => cfg.CreateMap<Person, PersonDTO> ()).CreateMapper();
            var db = await context.People.Where(e => e.Active && e.UserId == userId).FirstOrDefaultAsync().ConfigureAwait(false);
            PersonDTO dto = map.Map<PersonDTO>(db);
            return dto;
        }
    }
}
