namespace Standart.Html.Gumbo
{
    public struct HtmlParserOptions
    {
        /**
        * The tab-stop size, for computing positions in source code that uses tabs.
        * Default: 8.
        */
        public int TabStop;

        /**
        * Whether or not to stop parsing when the first error is encountered.
        * Default: false.
        */
        public bool StopOnFirstError;

        /**
        * The maximum number of errors before the parser stops recording them.  This
   *    * is provided so that if the page is totally borked, we don't completely fill
   *    * up the errors vector and exhaust memory with useless redundant errors.  Set
   *    * to -1 to disable the limit.
   *    * Default: -1
        */
        public int MaxErrors;

        /**
        * The fragment context for parsing:
        * https://html.spec.whatwg.org/multipage/syntax.html#parsing-html-fragments
        *
        * If TAG_LAST is passed here, it is assumed to be "no fragment", i.e.
        * the regular parsing algorithm.  Otherwise, pass the tag enum for the
        * intended parent of the parsed fragment.  We use just the tag enum rather
        * than a full node because that's enough to set all the parsing context we
        * need, and it provides some additional flexibility for client code to act as
        * if parsing a fragment even when a full HTML tree isn't available.
        *
        * Default: TAG_LAST
        */
        public HtmlTag FragmentContext;

        /**
        * The namespace for the fragment context.  This lets client code
        * differentiate between, say, parsing a <title> tag in SVG vs. parsing it in
        * HTML.
        * Default: NAMESPACE_HTML
        */
        public HtmlNamespace FragmentNamespace;

        /**
        * The default options for the parser. 
        */
        public static HtmlParserOptions Default() => new HtmlParserOptions
        {
            TabStop = 8,
            StopOnFirstError = false,
            MaxErrors = -1,
            FragmentContext = HtmlTag.LAST,
            FragmentNamespace = HtmlNamespace.HTML
        };
    }
}
