using System;
using System.Text.Json.Serialization;

namespace PoSharp.Models;

public class Inventory
{
    [JsonPropertyName("multi_item")]
    public bool IsMultiItem { get; set; }

    public bool IsSold
    {
        get
        {
            return Status == Status.Sold;
        }
    }

    [JsonPropertyName("status_changed_at")]
    public DateTime StatusChangedAt { get; set; }

    [JsonPropertyName("status")]
    public string? StatusString { get; set; }

    public Status Status
    {
        get
        {
            if (StatusString == null)
            {
                throw new InvalidOperationException("StatusString is null.");
            }

            return StringToStatus(StatusString);
        }
    }


    private Status StringToStatus(string status)
    {
        switch (status)
        {
            case "available":
                return Status.Available;
            case "reserved":
                return Status.Reserved;
            case "sold_out":
                return Status.Sold;
            default:
                throw new InvalidOperationException("Invalid status.");
        }
    }
}

public enum Status
{
    Available,
    Reserved,
    Sold
}


