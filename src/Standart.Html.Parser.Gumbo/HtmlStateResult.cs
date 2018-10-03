namespace Standart.Html.Parser.Gumbo
{
    public enum HtmlStateResult
    {
        RETURN_ERROR,    // Return false (error) from the tokenizer.
        RETURN_SUCCESS,  // Return true (success) from the tokenizer.
        NEXT_CHAR        // Proceed to the next character and continue lexing.
    }
}
