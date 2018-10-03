namespace Standart.Html.Parser.Gumbo
{
    using System;

    public class HtmlText
    {
        /**
        * The text of this node, after entities have been parsed and decoded. For
        * comment/cdata nodes, this does not include the comment delimiters.
        */
        public string Text;

        /**
        * The original text of this node, as a pointer into the original buffer. For
        * comment/cdata nodes, this includes the comment delimiters.
        */
        public ReadOnlyMemory<char> OriginalText;

        /**
        * The starting position of this node.  This corresponds to the position of
        * original_text, before entities are decoded.
        */
        public HtmlSourcePosition StartPosition;
    }
}
