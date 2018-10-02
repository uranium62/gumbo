namespace Standart.Html.Gumbo
{
    using System;
    using System.Collections.Generic;

    public class HtmlElement
    {
        /**
        * An array of Nodes, containing the children of this element.  
        * Pointers are owned.
        */
        public IEnumerable<HtmlNode> Children;

        /** 
        * The Tag enum for this element. 
        */
        public HtmlTag Tag;

        /**
        * The Namespace for this element.
        */
        public HtmlNamespace TagNamespace;

        /**
        * A pointer to the original tag text for this element,
        * pointing directly into the source buffer.  If the tag was inserted
        * algorithmically (for example, <head> or <tbody> insertion), this will be a
        * zero-length string.
        */
        public ReadOnlyMemory<char> OriginalTag;

        /**
        * A pointer to the original end tag text for this element.
        * If the end tag was inserted algorithmically, (for example, closing a
        * self-closing tag), this will be a zero-length string.
        */
        public ReadOnlyMemory<char> OriginalEndTag;

        /** 
        * The source position for the start of the start tag. 
        */
        public HtmlSourcePosition StartPosition;

        /**
        * The source position for the start of the end tag.
        */
        public HtmlSourcePosition EndPosition;

        /**
        * An array of GumboAttributes, containing the attributes for this tag in the
        * order that they were parsed.  Pointers are owned.
        */
        public IEnumerable<HtmlAttribute> Attributes;
    }
}
