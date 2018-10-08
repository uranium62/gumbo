namespace Standart.Html.Parser.Gumbo
{
    using System.Collections.Generic;

    /**
    * The class containing all information pertaining to start tag tokens. 
    */
    public class HtmlTokenStartTag
    {
        public HtmlTag Tag;
        public IEnumerable<HtmlAttribute> Attributes;
        public bool IsSelfClosing;
    }
}