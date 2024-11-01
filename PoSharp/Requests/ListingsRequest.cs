using System;

namespace PoSharp.Requests;

public class ListingsRequest
{
    public string? UserName { get; set; }
    public bool IncludeSold { get; set; }
}
