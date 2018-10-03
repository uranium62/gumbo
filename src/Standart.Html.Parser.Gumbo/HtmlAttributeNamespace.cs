namespace Standart.Html.Parser.Gumbo
{
    /**
     * Attribute namespaces.
     * HTML includes special handling for XLink, XML, and XMLNS namespaces on
     * attributes.  Everything else goes in the generic "NONE" namespace.
     */
    public enum HtmlAttributeNamespace
    {
        NONE,
        XLINK,
        XML,
        XMLNS,
    }
}
