using System.Text;

namespace Builder
{
    public class HtmlTextBuilder : ITextBuilder
    {
        private StringBuilder _text;

        public HtmlTextBuilder()
        {
            _text = new StringBuilder();
        }

        public ITextBuilder AddMainHeader(string text)
        {
            _text.AppendLine($"<h1>{text}</h1>");
            return this;
        }

        public ITextBuilder AddSubHeader(string text)
        {
            _text.AppendLine($"<h3>{text}</h3>");
            return this;
        }

        public ITextBuilder AddParagraph(string text)
        {
            _text.AppendLine($"<p>{text}</p>");
            return this;
        }

        public ITextBuilder AddDelimiter()
        {
            _text.AppendLine($"<br/>");
            return this;
        }

        public string Build()
        {
            return _text.ToString();
        }
    }
}
