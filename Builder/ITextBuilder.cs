namespace Builder
{
    public interface ITextBuilder
    {
        ITextBuilder AddDelimiter();
        ITextBuilder AddMainHeader(string text);
        ITextBuilder AddParagraph(string text);
        ITextBuilder AddSubHeader(string text);
        string Build();
    }
}