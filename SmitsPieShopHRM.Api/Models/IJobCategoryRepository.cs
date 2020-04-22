using System.Collections.Generic;
using SmitsPieShopHRM.Shared;

namespace SmitsPieShopHRM.Api.Models
{
    public interface IJobCategoryRepository
    {
        IEnumerable<JobCategory> GetAllJobCategories();
        JobCategory GetJobCategoryById(int jobCategoryId);
    }
}
