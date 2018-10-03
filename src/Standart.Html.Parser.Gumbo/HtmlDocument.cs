namespace Standart.Html.Parser.Gumbo
{
    using System.Collections.Generic;

    public class HtmlDocument
    {
        /**
        * An array of Nodes, containing the children of this element. This will
        * normally consist of the <html> element and any comment nodes found.
        * Pointers are owned.
        */
        public IEnumerable<HtmlNode> Nodes;

        /**
        * True if there was an explicit doctype token as opposed to it being omitted.
        */
        public bool HasDoctype;

        /**
        * Fields from the doctype token, copied verbatim. 
        */
        public string Name;
        public string PublicIdentifier;
        public string SystemIdentifier;

        /**
        * Whether or not the document is in QuirksMode, as determined by the values
        * in the TokenDocType template.
        */
        public HtmlQuirksMode DoctypeQuirksMode;

    }
}
