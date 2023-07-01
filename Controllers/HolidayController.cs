using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_api_consumer.Interfaces;
using dotnet_api_consumer.Models;
using dotnet_api_consumer.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_api_consumer.Controllers
{
    public class HolidayController : Controller
    {
        private readonly IHolidaysApiService _holidaysApiService;

        public HolidayController(IHolidaysApiService holidaysApiService)
        {
            _holidaysApiService = holidaysApiService;
        }

        [HttpGet("nager-date/get-holidays")]
        public async Task<List<HolidayModel>> Main(int year,string countryCode)
        {
            List<HolidayModel> holidays = new List<HolidayModel>();
            holidays = await _holidaysApiService.GetHolidays(year, countryCode);

            return holidays;
        }
    }
}