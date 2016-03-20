using AutoMapper;
using ELMS.BLL.DataTransferObjects;
using ELMS.DAL.Common;
using ELMS.DAL.Standards;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.BLL.ServiceLayer
{
    public class EducationHistoryService : Base
    {
        public async Task<EducationHistoryDTO> EditEducationHistory(Guid userId, EducationHistoryDTO dto)
        {
            EducationHistory a = await context.EducationHistories.Where(e => e.Active && e.EducationProfile.Person.UserId == userId).FirstOrDefaultAsync().ConfigureAwait(false);
            var map = new MapperConfiguration(cfg => cfg.CreateMap<EducationHistoryDTO, EducationHistory>()).CreateMapper();
            a = map.Map<EducationHistoryDTO, EducationHistory>(dto, a);
            a.ModifiedBy = userId;
            int x = await context.SaveChangesAsync().ConfigureAwait(false);
            var task = await GetEducationHistory(userId);
            return task;
        }

        public async Task<int> CreateEducationHistory(Guid userId)
        {
            EducationHistory a = new EducationHistory();
            var history = await context.EducationHistories.Where(e => e.Active && e.EducationProfile.Person.UserId == userId).FirstOrDefaultAsync().ConfigureAwait(false);
            a.CreatedBy = userId;
            
            var task = await context.SaveChangesAsync().ConfigureAwait(false);
            return task;
        }

        public async Task<EducationHistoryDTO> GetEducationHistory(Guid userId)
        {
            var map = new MapperConfiguration(cfg => cfg.CreateMap<EducationHistory, EducationHistoryDTO>()).CreateMapper();
            var db = await context.EducationHistories.Where(e => e.Active && e.EducationProfile.Person.UserId == userId).FirstOrDefaultAsync().ConfigureAwait(false);
            EducationHistoryDTO dto = map.Map<EducationHistoryDTO>(db);
            return dto;
        }
    }
}
