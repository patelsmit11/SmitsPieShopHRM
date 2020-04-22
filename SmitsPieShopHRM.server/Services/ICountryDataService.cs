using SmitsPieShopHRM.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmitsPieShopHRM.server.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);
    }
}
