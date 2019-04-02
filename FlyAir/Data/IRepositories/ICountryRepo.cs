using FlyAir.Models;
using FlyAir.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Data.IRepositories
{
    public interface ICountryRepo
    {
        //Task<IEnumerable<Country>> GetAll();
        Task<IEnumerable<Country>> GetByInput(string input);
        Task<IEnumerable<LocationVM>> GetLocByInput(string input);
        Task<IEnumerable<LocationVM>> GetAllLocById(IEnumerable<int> locIds);
        Task<IEnumerable<Location>> GetAllLocById2(IEnumerable<int> locIds);
        Task<IEnumerable<Location>> GetCitiesByCountryId(int countryId);
        Task<Location> GetLocById(int id);
    }
}
