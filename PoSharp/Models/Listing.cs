using System;
using System.Text.Json.Serialization;

namespace PoSharp.Models;

public class Listing
{
    [JsonPropertyName("brand")]
    public string? Brand { get; set; }

    [JsonPropertyName("brand_id")]
    public string? BrandId { get; set; }

    [JsonPropertyName("brand_object")]
    public BrandObject BrandObject { get; set; } = new BrandObject();

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("inventory")]
    public Inventory Inventory { get; set; } = new Inventory();
}
