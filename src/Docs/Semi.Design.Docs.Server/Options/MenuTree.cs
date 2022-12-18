using System.Text.Json.Serialization;

namespace Semi.Design.Docs.Server.Options;

public class MenuTree
{
    public required string Key { get; set; }

    public required string Title { get; set; }

    public MenuTree[]? Children { get; set; }

    [JsonIgnore]
    public bool Show { get; set; }

    public string? Component { get; set; }
}