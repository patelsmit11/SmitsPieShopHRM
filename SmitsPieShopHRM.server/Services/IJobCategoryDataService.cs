using SmitsPieShopHRM.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmitsPieShopHRM.server.Services
{
    public interface IJobCategoryDataService
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);
    }
}