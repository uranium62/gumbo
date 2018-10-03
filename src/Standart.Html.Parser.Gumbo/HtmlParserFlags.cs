namespace Standart.Html.Parser.Gumbo
{
 using System;

 [Flags]
    public enum HtmlParserFlags
    {
        /**
        * A normal node - both start and end tags appear in the source, nothing has
        * been reparented.
        */
        INSERTION_NORMAL = 0,
        
        /**
        * A node inserted by the parser to fulfill some implicit insertion rule.
        * This is usually set in addition to some other flag giving a more specific
        * insertion reason; it's a generic catch-all term meaning "The start tag for
        * this node did not appear in the document source".
        */
        INSERTION_BY_PARSER = 1 << 0,

        /**
        * A flag indicating that the end tag for this node did not appear in the
        * document source.  Note that in some cases, you can still have
        * parser-inserted nodes with an explicit end tag: for example, "Text</html>"
        * has INSERTED_BY_PARSER set on the <html> node, but
        * INSERTED_END_TAG_IMPLICITLY is unset, as the </html> tag actually
        * exists.  This flag will be set only if the end tag is completely missing;
        * in some cases, the end tag may be misplaced (eg. a </body> tag with text
        * afterwards), which will leave this flag unset and require clients to
        * inspect the parse errors for that case.
        */
        INSERTION_IMPLICIT_END_TAG = 1 << 1,

        // Value 1 << 2 was for a flag that has since been removed.

        /**
        * A flag for nodes that are inserted because their presence is implied by
        * other tags, eg. <html>, <head>, <body>, <tbody>, etc.
        */
        INSERTION_IMPLIED = 1 << 3,

        /**
         * A flag for nodes that are converted from their end tag equivalents.  For
         * example, </p> when no paragraph is open implies that the parser should
         * create a <p> tag and immediately close it, while </br> means the same thing
         * as <br>.
         */
        INSERTION_CONVERTED_FROM_END_TAG = 1 << 4,

        /** 
         * A flag for nodes that are converted from the parse of an <isindex> tag. 
         */
        INSERTION_FROM_ISINDEX = 1 << 5,

        /** 
         * A flag for <image> tags that are rewritten as <img>. 
         */
        INSERTION_FROM_IMAGE = 1 << 6,

        /**
         * A flag for nodes that are cloned as a result of the reconstruction of
         * active formatting elements.  This is set only on the clone; the initial
         * portion of the formatting run is a NORMAL node with an IMPLICIT_END_TAG.
         */
        INSERTION_RECONSTRUCTED_FORMATTING_ELEMENT = 1 << 7,

        /** 
         * A flag for nodes that are cloned by the adoption agency algorithm. 
         */
        INSERTION_ADOPTION_AGENCY_CLONED = 1 << 8,

        /** 
         * A flag for nodes that are moved by the adoption agency algorithm. 
         */
        INSERTION_ADOPTION_AGENCY_MOVED = 1 << 9,

        /**
         * A flag for nodes that have been foster-parented out of a table (or
         * should've been foster-parented, if verbatim mode is set).
         */
        INSERTION_FOSTER_PARENTED = 1 << 10,
    }
}
