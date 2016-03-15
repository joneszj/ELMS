﻿using ELMS.DAL.Standards;
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
    public class AddressService : Base
    {
        public async Task<int> CreateAddress(Guid userId)
        {
            Address p = new Address();
            var person = await context.People.Where(e => e.Active && e.UserId == userId).FirstOrDefaultAsync().ConfigureAwait(false);
            p.PersonId = person.Id;
            p.CreatedBy = userId;
            person.Addess.Add(p);
            var task = await context.SaveChangesAsync().ConfigureAwait(false);
            return task;
        }

        public async Task<AddressDTO> GetAddress(Guid userId)
        {
            var map = new MapperConfiguration(cfg => cfg.CreateMap<Address, AddressDTO>()).CreateMapper();
            var db = await context.Addresses.Where(e => e.Active && e.Person.UserId == userId).FirstOrDefaultAsync().ConfigureAwait(false);
            AddressDTO dto = map.Map<AddressDTO>(db);
            return dto;
        }
    }
}