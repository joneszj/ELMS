using ELMS.DAL.Standards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using ELMS.DAL.StandardOptions;
using ELMS.BLL.DataTransferObjects;
using AutoMapper;

namespace ELMS.BLL.ServiceLayer
{
    public class StandardOptionsService : Base
    {
        public async Task<List<SelectListItemDTO>> GetCountries()
        {
            var map = new MapperConfiguration(cfg => cfg.CreateMap<Country, SelectListItemDTO>()
                .ForMember(dest => dest.Text, opts => opts.MapFrom(src => src.Name))).CreateMapper();
            var db = await context.Countries.Where(e=>e.Active).ToListAsync().ConfigureAwait(false);
            List<SelectListItemDTO> dto = map.Map<List<Country>, List<SelectListItemDTO>>(db);
            return dto;
        }

        public async Task<List<SelectListItemDTO>> GetStates()
        {
            var map = new MapperConfiguration(cfg => cfg.CreateMap<State, SelectListItemDTO>()
                .ForMember(dest => dest.Text, opts => opts.MapFrom(src => src.Name))).CreateMapper();
            var db = await context.States.Where(e => e.Active).ToListAsync().ConfigureAwait(false);
            List<SelectListItemDTO> dto = map.Map<List<State>, List<SelectListItemDTO>>(db);
            return dto;
        }
    }
}
