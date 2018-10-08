namespace Standart.Html.Parser.Gumbo
{
    /**
    * An enum for the return value of each individual state. 
    */
    public enum HtmlStateResult
    {
        RETURN_ERROR,    // Return false (error) from the tokenizer.
        RETURN_SUCCESS,  // Return true (success) from the tokenizer.
        NEXT_CHAR        // Proceed to the next character and continue lexing.
    }
}