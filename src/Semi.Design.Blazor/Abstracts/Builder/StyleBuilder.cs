namespace Semi.Design.Blazor;


public class StyleBuilder : BuilderBase
{
    public string Style => _mapper.GetStyle();
}