using System;
using System.Text.Json.Serialization;

namespace PoSharp.Models;

public class BrandObject
{
    [JsonPropertyName("canonical_name")]
    public string? CanonicalName { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("slug")]
    public string? Slug { get; set; }
}
