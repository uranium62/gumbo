namespace Standart.Html.Parser.Gumbo
{
    /** 
    * The output struct containing the results of the parse. 
    */
    public class HtmlOutput
    {
        /**
        * Pointer to the document node.  This is a GumboNode of type NODE_DOCUMENT
        * that contains the entire document as its child.
        */
        public HtmlNode Document;

        /**
        * Pointer to the root node.  This the <html> tag that forms the root of the
        * document.
        */
        public HtmlNode Root;
    }
}
