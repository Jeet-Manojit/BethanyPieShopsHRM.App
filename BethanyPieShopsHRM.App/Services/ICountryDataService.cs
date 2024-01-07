using BethanysPieShopHRM.Shared;

namespace BethanyPieShopsHRM.App.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);

    }
}
