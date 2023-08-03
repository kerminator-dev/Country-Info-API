﻿using CountryInfo.ClientApiLibrary.Models;
using CountryInfo.ClientApiLibrary.Services.Abstractions;

namespace CountryInfo.ClientApiLibrary.Services.Implementation
{
    internal class CountryApiService : BaseApiService<Country>, IGetAllApiServiceRequest<Country>
    {
        private const string CONTROLLER_NAME = "Countries";

        public CountryApiService(string baseServerAddress) : base(baseServerAddress, CONTROLLER_NAME)
        {

        }

        public async Task<IEnumerable<Country>> GetAllAsync()
        {
            try
            {
                var address = new Uri($"{_baseServerAddress}api/{_controllerName}");

                return await MakeGETRequest<IEnumerable<Country>>(address);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}