namespace Standart.Html.Parser.Gumbo
{
    using System;
    using System.Collections.Generic;

    /**
    * Additional data for duplicated attributes.
    */
    public class HtmlDuplicateAttrError
    {
        /**
        * The name of the attribute.  Owned by this struct.
        */
        public string Name;

        /*
        * The (0-based) index within the attributes vector of the original occurrence.
        */
        public uint OriginalIndex;

        /*
        * The (0-based) index where the new occurrence would be.
        */
        public uint NewIndex;
    }

    /**
    * Additional data for tokenizer errors.
    * This records the current state and codepoint encountered - this is usually
    * enough to reconstruct what went wrong and provide a friendly error message.
    */
    public class HtmlTokenError
    {
        /**
        * The bad codepoint encountered
        */
        public int CodePoint;

        /*
        * The state that the tokenizer was in at the time.
        */
        public HtmlTokenErrorType State;
    }

    /**
    * Additional data for parse errors.
    */
    public class HtmlParseError
    {
        /**
        * The type of input token that resulted in this error.
        */
        public HtmlTokenType InputType;

        /**
        * The HTML tag of the input token. TAG_UNKNOWN if this was not a tag token.
        */
        public HtmlTag InputTag;

        /**
        * The insertion mode that the parser was in at the time.
        */
        public HtmlInsertionMode ParserState;

        /**
        * The tag stack at the point of the error. Note that this is an Vector
        * of Tag's *stored by value* - cast the void* to an Tag directly to
        * get at the tag.
        */
        public IEnumerable<HtmlTag> TagStack;
    }

    /*
    * The overall error struct representing an error in decoding/tokenizing/parsing
    * the HTML.  This contains an enumerated type flag, a source position, and then
    * a union of fields containing data specific to the error.
    */
    public class HtmlError
    {
        /*
        * The type of error.
        */
        public HtmlErrorType ErrorType;

        /*
        * The position within the source file where the error occurred. 
        */
        public HtmlSourcePosition Position;

        /*
        * A pointer to the byte within the original source file text where the error
        * occurred (note that this is not the same as position.offset, as that gives
        * character-based instead of byte-based offsets).
        */
        public string OriginalText;

        /*
        * The code point we encountered, for:
        * ERR_UTF8_INVALID
        * ERR_UTF8_TRUNCATED
        * ERR_NUMERIC_CHAR_REF_WITHOUT_SEMICOLON
        * ERR_NUMERIC_CHAR_REF_INVALID 
        */
        public ulong Codepoint;

        /*
        * Token errors 
        */
        public HtmlTokenError Token;

        /**
        * Short textual data, for:
        * GUMBO_ERR_NAMED_CHAR_REF_WITHOUT_SEMICOLON
        * GUMBO_ERR_NAMED_CHAR_REF_INVALID
        */
        public ReadOnlyMemory<char> Text;

        /**
        * Duplicate attribute data, for GUMBO_ERR_DUPLICATE_ATTR
        */
        public HtmlDuplicateAttrError DuplicateAttr;

        /**
        * Parser state, for GUMBO_ERR_PARSER and
        * GUMBO_ERR_UNACKNOWLEDGE_SELF_CLOSING_TAG.
        */
        public HtmlParseError Parser;
    }
}
