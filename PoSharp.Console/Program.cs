using PoSharp;
using PoSharp.Requests;
using PoSharp.Results;

string apiKey = Environment.GetEnvironmentVariable("API_KEY") ?? throw new ArgumentNullException("API_KEY", "API key cannot be null");

RapidAPI api = new RapidAPI(apiKey);

ListingsRequest request = new ListingsRequest
{
    UserName = "probablynotian",
    IncludeSold = false
};

ListingsResult result = await api.GetListingsAsync(request);

if (result?.Listings != null)
{
    foreach (var listing in result.Listings)
    {
        Console.WriteLine(listing.Brand);
    }
}
