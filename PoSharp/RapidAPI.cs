using System;
using System.Runtime.Serialization;
using System.Text.Json;
using PoSharp.Models;
using PoSharp.Requests;
using PoSharp.Results;

namespace PoSharp;

public class RapidAPI
{
    private readonly string _apiKey;

    public RapidAPI(string apiKey)
    {
        _apiKey = apiKey;
    }

    public async Task<ListingsResult> GetListingsAsync(ListingsRequest request)
    {
        var url = $"https://poshmark.p.rapidapi.com/closet?username={request.UserName}&domain=com";
        var client = new HttpClient();

        client.DefaultRequestHeaders.Add("x-rapidapi-key", _apiKey);
        client.DefaultRequestHeaders.Add("x-rapidapi-host", "poshmark.p.rapidapi.com");

        var response = await client.GetAsync(url);

        var json = await response.Content.ReadAsStringAsync();

        var result = JsonSerializer.Deserialize<ListingsResult>(json);

        if (result == null)
        {
            throw new InvalidOperationException("Failed to deserialize ListingsResult.");
        }

        if (!request.IncludeSold)
        {
            result.Listings = result.Listings.Where(x => !x.Inventory.IsSold).ToList();
        }

        return result;
    }
}
