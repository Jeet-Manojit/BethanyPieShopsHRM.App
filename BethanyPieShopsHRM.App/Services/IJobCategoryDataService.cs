using BethanysPieShopHRM.Shared;

namespace BethanyPieShopsHRM.App.Services
{
    public interface IJobCategoryDataService
    {

        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);
    }
}
