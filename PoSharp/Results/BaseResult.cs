using System;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PoSharp.Results;

public class BaseResult
{
    [JsonPropertyName("totalResultCount")]
    public int TotalResultCount { get; set; }
    [JsonPropertyName("next_page")]
    public string? NextPage { get; set; }
}
