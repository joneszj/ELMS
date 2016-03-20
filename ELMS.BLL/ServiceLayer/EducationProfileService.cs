using AutoMapper;
using ELMS.BLL.DataTransferObjects;
using ELMS.DAL.Standards;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.BLL.ServiceLayer
{
    public class EducationProfileService : Base
    {
        public async Task<EducationProfileDTO> EditEducationProfile(Guid userId, EducationProfileDTO dto)
        {
            EducationProfile a = await context.EducationProfiles.Where(e => e.Active && e.Person.UserId == userId).FirstOrDefaultAsync().ConfigureAwait(false);
            var map = new MapperConfiguration(cfg => cfg.CreateMap<EducationProfileDTO, EducationProfile>()).CreateMapper();
            a = map.Map<EducationProfileDTO, EducationProfile>(dto, a);
            a.ModifiedBy = userId;
            int x = await context.SaveChangesAsync().ConfigureAwait(false);
            var task = await GetEducationProfile(userId);
            return task;
        }

        public async Task<int> CreateEducationProfile(Guid userId)
        {
            EducationProfile a = new EducationProfile();
            var person = await context.People.Where(e => e.Active && e.UserId == userId).FirstOrDefaultAsync().ConfigureAwait(false);
            a.PersonId = person.Id;
            a.CreatedBy = userId;
            a.HighSchoolGraduationYear = null;
            person.EducationProfile.Add(a);
            var task = await context.SaveChangesAsync().ConfigureAwait(false);
            return task;
        }

        public async Task<EducationProfileDTO> GetEducationProfile(Guid userId)
        {
            var map = new MapperConfiguration(cfg => cfg.CreateMap<EducationProfile, EducationProfileDTO>()).CreateMapper();
            var db = await context.EducationProfiles.Where(e => e.Active && e.Person.UserId == userId).FirstOrDefaultAsync().ConfigureAwait(false);
            EducationProfileDTO dto = map.Map<EducationProfileDTO>(db);
            return dto;
        }
    }
}
