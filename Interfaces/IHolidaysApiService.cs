using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_api_consumer.Models;

namespace dotnet_api_consumer.Interfaces
{
    public interface IHolidaysApiService
    {
        Task<List<HolidayModel>> GetHolidays(int year, string countryCode);
    }
}