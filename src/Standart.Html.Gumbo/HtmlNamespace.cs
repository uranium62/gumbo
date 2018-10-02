namespace Standart.Html.Gumbo
{
    /**
     * Namespaces.
     * Unlike in X(HT)ML, namespaces in HTML5 are not denoted by a prefix.  Rather,
     * anything inside an <svg> tag is in the SVG namespace, anything inside the
     * <math> tag is in the MathML namespace, and anything else is inside the HTML
     * namespace.  No other namespaces are supported, so this can be an enum only.
     */
    public enum HtmlNamespace 
    {
        HTML,
        SVG,
        MATHML
    }
}
