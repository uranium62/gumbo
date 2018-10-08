namespace Standart.Html.Parser.Gumbo
{
    /**
    * The enum representing the type of token
    */
    public enum HtmlTokenType
    {
        DOCTYPE,
        START_TAG,
        END_TAG,
        COMMENT,
        WHITESPACE,
        CHARACTER,
        CDATA,
        GNULL,
        EOF
    }
}
