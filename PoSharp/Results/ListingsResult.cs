using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using PoSharp.Models;

namespace PoSharp.Results;

public class ListingsResult : BaseResult
{
    [JsonPropertyName("data")]
    public List<Listing> Listings { get; set; } = new List<Listing>();
}
