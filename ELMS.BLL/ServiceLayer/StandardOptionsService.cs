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
            var db = await context.Countries.Where(e => e.Active).ToListAsync().ConfigureAwait(false);
            List<SelectListItemDTO> dto = map.Map<List<Country>, List<SelectListItemDTO>>(db);
            return dto;
        }

        public async Task<List<SelectListItemDTO>> GetStates(int? CountryID = 236)
        {
            var map = new MapperConfiguration(cfg => cfg.CreateMap<State, SelectListItemDTO>()
                .ForMember(dest => dest.Text, opts => opts.MapFrom(src => src.Name))).CreateMapper();
            var db = await context.States.Where(e => e.Active && e.CountryId == CountryID).ToListAsync().ConfigureAwait(false);
            List<SelectListItemDTO> dto = map.Map<List<State>, List<SelectListItemDTO>>(db);
            return dto;
        }

        public async Task<List<SelectListItemDTO>> GetEducationLevels(int? CountryID = 236)
        {
            var map = new MapperConfiguration(cfg => cfg.CreateMap<EducationLevel, SelectListItemDTO>()
                .ForMember(dest => dest.Text, opts => opts.MapFrom(src => src.Name))).CreateMapper();
            var db = await context.EducationLevels
                .Where(e => e.Active)
                .OrderBy(e => e.DisplayOrder)
                .ToListAsync().ConfigureAwait(false);
            List<SelectListItemDTO> dto = map.Map<List<EducationLevel>, List<SelectListItemDTO>>(db);
            return dto;
        }

        public async Task<List<SelectListItemDTO>> GetCounties(int? StateID = 0, string filter = "")
        {
            var map = new MapperConfiguration(cfg => cfg.CreateMap<County, SelectListItemDTO>()
                .ForMember(dest => dest.Text, opts => opts.MapFrom(src => src.Name))).CreateMapper();
            var db = context.Counties.Where(e => e.Active);
            if (StateID != null && StateID != 0)
            {
                db = db.Where(e => e.StateId == StateID);
            }
            if (!string.IsNullOrEmpty(filter))
            {
                db = db.Where(e => e.Name.Contains(filter) || e.State.Name.Contains(filter));
            }
            var dto = await db
                .Take(20)
                .Select(e => new SelectListItemDTO { Id = e.Id, Text = e.Name + " - " + e.State.Name })
                .ToListAsync().ConfigureAwait(false);
            return dto;
        }

        public async Task<SelectListItemDTO> GetCountyBiId(int CountyID = 0)
        {
            var map = new MapperConfiguration(cfg => cfg.CreateMap<County, SelectListItemDTO>()
                .ForMember(dest => dest.Text, opts => opts.MapFrom(src => src.Name))).CreateMapper();
            var db = await context.Counties.Where(e => e.Active)
                .Where(e => e.Id == CountyID)
                .Select(e => new SelectListItemDTO { Id = e.Id, Text = e.Name + " - " + e.State.Name })
                .FirstOrDefaultAsync().ConfigureAwait(false); ;
            return db;
        }

        public List<SelectListItemDTO> GetGraduationYears()
        {
            var map = new MapperConfiguration(cfg => cfg.CreateMap<int, SelectListItemDTO>()
                .ForMember(dest => dest.Text, opts => opts.MapFrom(src => src))
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src))).CreateMapper();
            var graduationYears = Enumerable.Range(DateTime.Now.Year - 100, 101).OrderByDescending(e => e).ToList();
            List<SelectListItemDTO> dto = map.Map<List<int>, List<SelectListItemDTO>>(graduationYears);
            return dto;
        }
    }
}
