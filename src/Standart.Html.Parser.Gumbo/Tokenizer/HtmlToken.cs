namespace Standart.Html.Parser.Gumbo
{
    using System;
    
    /**
    * A data structure representing a single token in the input stream.
    * This contains an enum for the type, the source position, a pointing
    * to the original text, and then a union for any parsed data.
    */
    public class HtmlToken
    {
        public HtmlTokenType Type;
        public HtmlSourcePosition Position;
        public ReadOnlyMemory<char> OriginalText;
        public HtmlTokenDocType DocType;
        public HtmlTokenStartTag StartTag;
        public HtmlTag EndTag;
        
        /**
        * For comments.
        */
        public ReadOnlyMemory<char> Text;
        /**
        * For character, whitespace, null, and EOF tokens.
        */
        public int Character;
    }
}