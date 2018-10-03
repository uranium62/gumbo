namespace Standart.Html.Parser.Gumbo
{
    public enum HtmlNodeType
    {
        DOCUMENT,
        ELEMENT,
        TEXT,
        CDATA,
        COMMENT,
        WHITESPACE,
        /* Template node.  This is separate from ELEMENT because many
        * client libraries will want to ignore the contents of template nodes, as
        * the spec suggests.  Recursing on ELEMENT will do the right thing
        * here, while clients that want to include template contents should also
        * check for TEMPLATE.  v will be a GumboElement. 
        **/
        TEMPLATE
    }
}
