namespace Semi.Design.Shared;

public class KeybindingRule
{
    public int Keybinding { get; set; }
    public string Command { get; set; }
    public object CommandArgs { get; set; }

    public string When { get; set; }
}