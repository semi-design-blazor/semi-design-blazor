namespace Semi.Design.Docs.Server.Options;

public class Navigation
{
    public string? Logo { get; set; }

    public string? Company { get; set; }

    public required string Key { get; set; }

    public required string Title { get; set; }

    public MenuTree[]? Menu { get; set; }
}

