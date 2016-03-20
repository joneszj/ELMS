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
    public class AddressService : Base
    {
        public async Task<AddressDTO> EditAddress(Guid userId, AddressDTO dto)
        {
            Address a = await context.Addresses.Where(e => e.Active && e.Person.UserId == userId).FirstOrDefaultAsync().ConfigureAwait(false);
            var map = new MapperConfiguration(cfg => cfg.CreateMap<AddressDTO, Address>()).CreateMapper();
            a = map.Map<AddressDTO, Address>(dto, a);
            a.ModifiedBy = userId;
            int x = await context.SaveChangesAsync().ConfigureAwait(false);
            var task = await GetAddress(userId);
            return task;
        }

        public async Task<int> UpdateLatLng(Guid userId, double x, double y, string formattedAddress)
        {
            Address a = await context.Addresses.Where(e => e.Active && e.Person.UserId == userId).FirstOrDefaultAsync().ConfigureAwait(false);
            a.ModifiedBy = userId;
            a.Latitude = x;
            a.Longitude = y;
            a.GoogleMapFormattedAddress = formattedAddress;
            return await context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<int> CreateAddress(Guid userId)
        {
            Address a = new Address();
            var person = await context.People.Where(e => e.Active && e.UserId == userId).FirstOrDefaultAsync().ConfigureAwait(false);
            a.PersonId = person.Id;
            a.CreatedBy = userId;
            person.Address.Add(a);
            var task = await context.SaveChangesAsync().ConfigureAwait(false);
            return task;
        }

        public async Task<AddressDTO> GetAddress(Guid userId)
        {
            var map = new MapperConfiguration(cfg => cfg.CreateMap<Address, AddressDTO>()).CreateMapper();
            var db = await context.Addresses.Where(e => e.Active && e.Person.UserId == userId).FirstOrDefaultAsync().ConfigureAwait(false);
            AddressDTO dto = map.Map<AddressDTO>(db);
            dto.CountryId = dto.CountryId == null ? 236 : dto.CountryId;
            return dto;
        }
    }
}
