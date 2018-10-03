namespace Standart.Html.Parser.Gumbo
{
    using System;
    using System.Collections.Generic;

    /**
    * The entity representing a single attribute on an HTML tag.  This is a
    * name-value pair, but also includes information about source locations and
    * original source text.
    */
    public class HtmlAttribute
    {
        /**
        * The namespace for the attribute.  This will usually be
        * NAMESPACE_NONE, but some XLink/XMLNS/XML attributes take special
        * values, per:
        */
        public HtmlAttributeNamespace Namespace;

        /**
        * The name of the attribute. This is in a freshly-allocated buffer to deal
        * with case-normalization, and is null-terminated.
        */
        public string Name;

        /**
        * The original text of the attribute name, as a pointer into the original
        * source buffer.
        */
        public ReadOnlyMemory<char> OriginalName;

        /**
        * The value of the attribute.  This is in a freshly-allocated buffer to deal
        * with unescaping, and is null-terminated.  It does not include any quotes
        * that surround the attribute.  If the attribute has no value (for example,
        * 'selected' on a checkbox), this will be an empty string.
        */
        public string Value;

        /**
        * The original text of the value of the attribute.  This points into the
        * original source buffer.  It includes any quotes that surround the
        * attribute, and you can look at original_value.data[0] and
        * original_value.data[original_value.length - 1] to determine what the quote
        * characters were. If the attribute has no value, this will be a 0-length
        * string.
        */
        public ReadOnlyMemory<char> OriginalValue;

        /** 
        * The starting position of the attribute name. 
        */
        public HtmlSourcePosition NameStart;

        /**
        * The ending position of the attribute name.  This is not always derivable
        * from the starting position of the value because of the possibility of
        * whitespace around the = sign.
        */
        public HtmlSourcePosition NameEnd;

        /** 
        * The starting position of the attribute value. 
        */
        public HtmlSourcePosition ValueStart;

        /**
        * The ending postition of the attribute value
        */
        public HtmlSourcePosition ValueEnd;

        /**
        * Given a vector of GumboAttributes, look up the one with the specified name
        * and return it, or NULL if no such attribute exists.  This uses a
        * case-insensitive match, as HTML is case-insensitive.
        */
        public static HtmlAttribute GetAttribute(IEnumerable<HtmlAttribute> attributes, string name)
        {
            foreach (HtmlAttribute attribute in attributes)
            {
                if (string.Equals(attribute.Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    return attribute;
                }
            }
            return null;
        }
    }
}
