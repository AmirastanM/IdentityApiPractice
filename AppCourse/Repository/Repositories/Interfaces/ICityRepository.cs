﻿using Domain.Entities;

namespace Repository.Repositories.Interfaces
{
    public interface ICityRepository : IBaseRepository<City>
    {
        Task<IEnumerable<City>> GetAllWithCountryAsync();
        Task<IEnumerable<City>> FilterAsync(string name, string countryName);
        Task<IEnumerable<City>> GetPaginateDataAsync(int page, int take);
    }
}