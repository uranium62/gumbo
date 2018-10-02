using System;
using System.Collections.Generic;
using System.Text;

namespace Standart.Html.Gumbo
{
    public enum HtmlStateResult
    {
        RETURN_ERROR,    // Return false (error) from the tokenizer.
        RETURN_SUCCESS,  // Return true (success) from the tokenizer.
        NEXT_CHAR        // Proceed to the next character and continue lexing.
    }
}
