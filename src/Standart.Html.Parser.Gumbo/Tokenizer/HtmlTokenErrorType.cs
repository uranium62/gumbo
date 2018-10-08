namespace Standart.Html.Parser.Gumbo
{
    /**
    * The basic token errors during tokenization
    */
    public enum HtmlTokenErrorType
    {
        DATA,
        CHAR_REF,
        RCDATA,
        RAWTEXT,
        PLAINTEXT,
        SCRIPT,
        TAG,
        SELF_CLOSING_TAG,
        ATTR_NAME,
        ATTR_VALUE,
        MARKUP_DECLARATION,
        COMMENT,
        DOCTYPE,
        CDATA,
    }
}
