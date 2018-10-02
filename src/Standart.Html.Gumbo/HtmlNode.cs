namespace Standart.Html.Gumbo
{
    public class HtmlNode
    {
        /**
        * The type of node that this is.
        */
        public HtmlNodeType Type;

        /**
        * Pointer back to parent node.  Not owned.
        */
        public HtmlNode Parent;

        /** 
        * The index within the parent's children vector of this node. 
        */
        public uint IndexWithinParent;

        /**
        * A bitvector of flags containing information about why this element was
        * inserted into the parse tree, including a variety of special parse
        * situations.
        */
        public HtmlParserFlags ParseFlag;

        /**
        * The actual node document data
        */
        public HtmlDocument Document;

        /**
        * The actual node element data
        */
        public HtmlElement Element;

        /**
        * The actual node text data
        */
        public HtmlText Text;
    }
}
