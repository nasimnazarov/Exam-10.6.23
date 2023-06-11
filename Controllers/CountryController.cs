using Domain.Entity;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class CountryController
{
    private readonly CountryService _countryService;

    public CountryController(CountryService countryService)
    {
        _countryService = countryService;
    }

    [HttpGet("GetCountry")]
    public async Task<List<Country>> GetCountryListAsync()
    {
        return await _countryService.GetCountryListAsync();
    }
    [HttpPost("AddCountry")]
    public async Task<Country> AddCountryAsync([FromForm] Country country)
    {
        return await _countryService.AddCountryAsync(country);
        
    }

    [HttpPut("UpdateCountry")]
    public async Task<Country> UpdateCountryAsync([FromForm] Country country)
    {
        return await _countryService.UpdateCountryAsync(country);
    }

    [HttpDelete("DeleteCountry")]
    public async Task<bool> DeleteCountryAsync(int id)
    {
        return await _countryService.DeleteCountryAsync(id);
    }

}