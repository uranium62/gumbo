namespace Standart.Html.Parser.Gumbo
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /**
    * This is a struct containing state necessary to build up a tag token,
    * character by character
    */
    public class HtmlTagState
    {
        /**
        * A buffer to accumulate characters for various HtmlStringPiece fields. 
        */
        public StringBuilder Buffer;
        
        /**
        * A pointer to the start of the original text corresponding to the contents
        * of the buffer.
        */
        public ReadOnlyMemory<char> OriginalText;

        /**
        * The current tag enum, computed once the tag name state has finished so that
        * the buffer can be re-used for building up attributes.
        */
        public HtmlTag Tag;

        /**
        * The starting location of the text in the buffer.
        */
        public HtmlSourcePosition StartPosition;

        /**
        * The current list of attributes.  This is copied (and ownership of its data
        * transferred) to the GumboStartTag token upon completion of the tag.  New
        * attributes are added as soon as their attribute name state is complete, and
        * values are filled in by operating on _attributes.data[attributes.length-1].
        */
        public IEnumerable<HtmlAttribute> Attributes;

        /**
        * If true, the next attribute value to be finished should be dropped. This
        * happens if a duplicate attribute name is encountered - we want to consume
        * the attribute value, but shouldn't overwrite the existing value.
        */
        public bool DropNextAttrValue;

        /**
        * The state that caused the tokenizer to switch into a character reference in
        * attribute value state.  This is used to set the additional allowed
        * character, and is switched back to on completion.  Initialized as the
        * tokenizer enters the character reference state.
        */
        public HtmlTokenizerEnum AttrValueState;

        /**
        * The last start tag to have been emitted by the tokenizer. This is
        * necessary to check for appropriate end tags.
        */
        public HtmlTag LastStartTag;

        /**
        * If true, then this is a start tag.  If false, it's an end tag.  This is
        * necessary to generate the appropriate token type at tag-closing time.
        */
        public bool IsStartTag;

        /**
        * If true, then this tag is "self-closing" and doesn't have an end tag.
        */
        public bool IsSelfClosing;
    }
}