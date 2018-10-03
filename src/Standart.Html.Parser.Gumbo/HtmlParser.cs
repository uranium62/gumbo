namespace Standart.Html.Parser.Gumbo
{
    using System;
    using System.Collections.Generic;

    public class HtmlParser
    {
        private HtmlParserOptions _options;
        private HtmlOutput        _output;

        public HtmlParser(HtmlParserOptions options)
        {
            _options = options;
        }

        public HtmlOutput Parse(string html)
        {
            _output = new HtmlOutput
            {
                Root = null, 
                Document = new HtmlNode
                {
                    Parent = null,
                    Type = HtmlNodeType.DOCUMENT,
                    ParseFlag = HtmlParserFlags.INSERTION_BY_PARSER,

                    Document = new HtmlDocument
                    {
                        HasDoctype = false,
                        Name = null,
                        PublicIdentifier = null,
                        SystemIdentifier = null,
                        Children = new List<HtmlNode>()
                    }
                }
            };

            return _output;
        }

        public HtmlOutput Parse(char[] html)
        {
            throw new NotImplementedException();
        }
    }
}
