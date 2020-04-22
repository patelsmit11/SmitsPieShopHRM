using System.Collections.Generic;
using SmitsPieShopHRM.Shared;

namespace SmitsPieShopHRM.Api.Models
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAllCountries();
        Country GetCountryById(int countryId);
    }
}
