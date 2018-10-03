namespace Standart.Html.Parser.Gumbo
{
    using System;

    /**
     * An enum for all the tags defined in the HTML5 standard.  These correspond to
     * the tag names themselves.  Enum constants exist only for tags which appear in
     * the spec itself (or for tags with special handling in the SVG and MathML
     * namespaces); any other tags appear as UNKNOWN and the actual tag
     * name can be obtained through original_tag.
     *
     * This is mostly for API convenience, so that clients of this library don't
     * need to perform a strcasecmp to find the normalized tag name.  It also has
     * efficiency benefits, by letting the parser work with enums instead of
     * strings.
     */
    public enum HtmlTag
    {
        HTML,
        HEAD,
        TITLE,
        BASE,
        LINK,
        META,
        STYLE,
        SCRIPT,
        NOSCRIPT,
        TEMPLATE,
        BODY,
        ARTICLE,
        SECTION,
        NAV,
        ASIDE,
        H1,
        H2,
        H3,
        H4,
        H5,
        H6,
        HGROUP,
        HEADER,
        FOOTER,
        ADDRESS,
        P,
        HR,
        PRE,
        BLOCKQUOTE,
        OL,
        UL,
        LI,
        DL,
        DT,
        DD,
        FIGURE,
        FIGCAPTION,
        MAIN,
        DIV,
        A,
        EM,
        STRONG,
        SMALL,
        S,
        CITE,
        Q,
        DFN,
        ABBR,
        DATA,
        TIME,
        CODE,
        VAR,
        SAMP,
        KBD,
        SUB,
        SUP,
        I,
        B,
        U,
        MARK,
        RUBY,
        RT,
        RP,
        BDI,
        BDO,
        SPAN,
        BR,
        WBR,
        INS,
        DEL,
        IMAGE,
        IMG,
        IFRAME,
        EMBED,
        OBJECT,
        PARAM,
        VIDEO,
        AUDIO,
        SOURCE,
        TRACK,
        CANVAS,
        MAP,
        AREA,
        MATH,
        MI,
        MO,
        MN,
        MS,
        MTEXT,
        MGLYPH,
        MALIGNMARK,
        ANNOTATION_XML,
        SVG,
        FOREIGNOBJECT,
        DESC,
        TABLE,
        CAPTION,
        COLGROUP,
        COL,
        TBODY,
        THEAD,
        TFOOT,
        TR,
        TD,
        TH,
        FORM,
        FIELDSET,
        LEGEND,
        LABEL,
        INPUT,
        BUTTON,
        SELECT,
        DATALIST,
        OPTGROUP,
        OPTION,
        TEXTAREA,
        KEYGEN,
        OUTPUT,
        PROGRESS,
        METER,
        DETAILS,
        SUMMARY,
        MENU,
        MENUITEM,
        APPLET,
        ACRONYM,
        BGSOUND,
        DIR,
        FRAME,
        FRAMESET,
        NOFRAMES,
        ISINDEX,
        LISTING,
        XMP,
        NEXTID,
        NOEMBED,
        PLAINTEXT,
        RB,
        STRIKE,
        BASEFONT,
        BIG,
        BLINK,
        CENTER,
        FONT,
        MARQUEE,
        MULTICOL,
        NOBR,
        SPACER,
        TT,
        RTC,
        // Used for all tags that don't have special handling in HTML.  Add new tags
        // to the end so as to preserve backwards-compatibility.
        UNKNOWN,
        // A marker value to indicate the end of the enum, for iterating over it.
        // Also used as the terminator for varargs functions that take tags.
        LAST,
    }

    public static class HtmlUtf16Tag
    {
        public const string Html = "html";
        public const string Head = "head";
        public const string Title = "title";
        public const string Base = "base";
        public const string Link = "link";
        public const string Meta = "meta";
        public const string Style = "style";
        public const string Script = "script";
        public const string Noscript = "noscript";
        public const string Template = "template";
        public const string Body = "body";
        public const string Article = "article";
        public const string Section = "section";
        public const string Nav = "nav";
        public const string Aside = "aside";
        public const string H1 = "h1";
        public const string H2 = "h2";
        public const string H3 = "h3";
        public const string H4 = "h4";
        public const string H5 = "h5";
        public const string H6 = "h6";
        public const string Hgroup = "hgroup";
        public const string Header = "header";
        public const string Footer = "footer";
        public const string Address = "address";
        public const string P = "p";
        public const string Hr = "hr";
        public const string Pre = "pre";
        public const string Blockquote = "blockquote";
        public const string Ol = "ol";
        public const string Ul = "ul";
        public const string Li = "li";
        public const string Dl = "dl";
        public const string Dt = "dt";
        public const string Dd = "dd";
        public const string Figure = "figure";
        public const string Figcaption = "figcaption";
        public const string Main = "main";
        public const string Div = "div";
        public const string A = "a";
        public const string Em = "em";
        public const string Strong = "strong";
        public const string Small = "small";
        public const string S = "s";
        public const string Cite = "cite";
        public const string Q = "q";
        public const string Dfn = "dfn";
        public const string Abbr = "abbr";
        public const string Data = "data";
        public const string Time = "time";
        public const string Code = "code";
        public const string Var = "var";
        public const string Samp = "samp";
        public const string Kbd = "kbd";
        public const string Sub = "sub";
        public const string Sup = "sup";
        public const string I = "i";
        public const string B = "b";
        public const string U = "u";
        public const string Mark = "mark";
        public const string Ruby = "ruby";
        public const string Rt = "rt";
        public const string Rp = "rp";
        public const string Bdi = "bdi";
        public const string Bdo = "bdo";
        public const string Span = "span";
        public const string Br = "br";
        public const string Wbr = "wbr";
        public const string Ins = "ins";
        public const string Del = "del";
        public const string Image = "image";
        public const string Img = "img";
        public const string Iframe = "iframe";
        public const string Embed = "embed";
        public const string Object = "object";
        public const string Param = "param";
        public const string Video = "video";
        public const string Audio = "audio";
        public const string Source = "source";
        public const string Track = "track";
        public const string Canvas = "canvas";
        public const string Map = "map";
        public const string Area = "area";
        public const string Math = "math";
        public const string Mi = "mi";
        public const string Mo = "mo";
        public const string Mn = "mn";
        public const string Ms = "ms";
        public const string Mtext = "mtext";
        public const string Mglyph = "mglyph";
        public const string Malignmark = "malignmark";
        public const string AnnotationXml = "annotation-xml";
        public const string Svg = "svg";
        public const string Foreignobject = "foreignobject";
        public const string Desc = "desc";
        public const string Table = "table";
        public const string Caption = "caption";
        public const string Colgroup = "colgroup";
        public const string Col = "col";
        public const string Tbody = "tbody";
        public const string Thead = "thead";
        public const string Tfoot = "tfoot";
        public const string Tr = "tr";
        public const string Td = "td";
        public const string Th = "th";
        public const string Form = "form";
        public const string Fieldset = "fieldset";
        public const string Legend = "legend";
        public const string Label = "label";
        public const string Input = "input";
        public const string Button = "button";
        public const string Select = "select";
        public const string Datalist = "datalist";
        public const string Optgroup = "optgroup";
        public const string Option = "option";
        public const string Textarea = "textarea";
        public const string Keygen = "keygen";
        public const string Output = "output";
        public const string Progress = "progress";
        public const string Meter = "meter";
        public const string Details = "details";
        public const string Summary = "summary";
        public const string Menu = "menu";
        public const string Menuitem = "menuitem";
        public const string Applet = "applet";
        public const string Acronym = "acronym";
        public const string Bgsound = "bgsound";
        public const string Dir = "dir";
        public const string Frame = "frame";
        public const string Frameset = "frameset";
        public const string Noframes = "noframes";
        public const string Isindex = "isindex";
        public const string Listing = "listing";
        public const string Xmp = "xmp";
        public const string Nextid = "nextid";
        public const string Noembed = "noembed";
        public const string Plaintext = "plaintext";
        public const string Rb= "rb";
        public const string Strike = "strike";
        public const string Basefont = "basefont";
        public const string Big = "big";
        public const string Blink = "blink";
        public const string Center = "center";
        public const string Font = "font";
        public const string Marquee = "marquee";
        public const string Multicol = "multicol";
        public const string Nobr = "nobr";
        public const string Spacer = "spacer";
        public const string Tt = "tt";
        public const string Rtc = "rtc";
    }

    public static class HtmlUtf8Tag
    {
        public static readonly byte[] Html          = {(byte) 'h', (byte) 't', (byte) 'm', (byte) 'l'};
        public static readonly byte[] Head          = {(byte) 'h', (byte) 'e', (byte) 'a', (byte) 'd'};
        public static readonly byte[] Title         = {(byte) 't', (byte) 'i', (byte) 't', (byte) 'l', (byte) 'e'};
        public static readonly byte[] Base          = {(byte) 'b', (byte) 'a', (byte) 's', (byte) 'e'};
        public static readonly byte[] Link          = {(byte) 'l', (byte) 'i', (byte) 'n', (byte) 'k'};
        public static readonly byte[] Meta          = {(byte) 'm', (byte) 'e', (byte) 't', (byte) 'a'};
        public static readonly byte[] Style         = {(byte) 's', (byte) 't', (byte) 'y', (byte) 'l', (byte) 'e'};
        public static readonly byte[] Script        = {(byte) 's', (byte) 'c', (byte) 'r', (byte) 'i', (byte) 'p', (byte) 't'};
        public static readonly byte[] Noscript      = {(byte) 'n', (byte) 'o', (byte) 's', (byte) 'c', (byte) 'r', (byte) 'i', (byte) 'p', (byte) 't'};
        public static readonly byte[] Template      = {(byte) 't', (byte) 'e', (byte) 'm', (byte) 'p', (byte) 'l', (byte) 'a', (byte) 't', (byte) 'e'};
        public static readonly byte[] Body          = {(byte) 'b', (byte) 'o', (byte) 'd', (byte) 'y'};
        public static readonly byte[] Article       = {(byte) 'a', (byte) 'r', (byte) 't', (byte) 'i', (byte) 'c', (byte) 'l', (byte) 'e'};
        public static readonly byte[] Section       = {(byte) 's', (byte) 'e', (byte) 'c', (byte) 't', (byte) 'i', (byte) 'o', (byte) 'n'};
        public static readonly byte[] Nav           = {(byte) 'n', (byte) 'a', (byte) 'v'};
        public static readonly byte[] Aside         = {(byte) 'a', (byte) 's', (byte) 'i', (byte) 'd', (byte) 'e'};
        public static readonly byte[] H1            = {(byte) 'h', (byte) '1'};
        public static readonly byte[] H2            = {(byte) 'h', (byte) '2'};
        public static readonly byte[] H3            = {(byte) 'h', (byte) '3'};
        public static readonly byte[] H4            = {(byte) 'h', (byte) '4'};
        public static readonly byte[] H5            = {(byte) 'h', (byte) '5'};
        public static readonly byte[] H6            = {(byte) 'h', (byte) '6'};
        public static readonly byte[] Hgroup        = {(byte) 'h', (byte) 'g', (byte) 'r', (byte) 'o', (byte) 'u', (byte) 'p'};
        public static readonly byte[] Header        = {(byte) 'h', (byte) 'e', (byte) 'a', (byte) 'd', (byte) 'e', (byte) 'r'};
        public static readonly byte[] Footer        = {(byte) 'f', (byte) 'o', (byte) 'o', (byte) 't', (byte) 'e', (byte) 'r'};
        public static readonly byte[] Address       = {(byte) 'a', (byte) 'd', (byte) 'd', (byte) 'r', (byte) 'e', (byte) 's', (byte) 's'};
        public static readonly byte[] P             = {(byte) 'p' };
        public static readonly byte[] Hr            = {(byte) 'h', (byte) 'r'};
        public static readonly byte[] Pre           = {(byte) 'p', (byte) 'r', (byte) 'e'};
        public static readonly byte[] Blockquote    = {(byte) 'b', (byte) 'l', (byte) 'o', (byte) 'c', (byte) 'k', (byte) 'q', (byte) 'u', (byte) 'o', (byte) 't', (byte) 'e'};
        public static readonly byte[] Ol            = {(byte) 'o', (byte) 'l'};
        public static readonly byte[] Ul            = {(byte) 'u', (byte) 'l'};
        public static readonly byte[] Li            = {(byte) 'l', (byte) 'i'};
        public static readonly byte[] Dl            = {(byte) 'd', (byte) 'l'};
        public static readonly byte[] Dt            = {(byte) 'd', (byte) 't'};
        public static readonly byte[] Dd            = {(byte) 'd', (byte) 'd'};
        public static readonly byte[] Figure        = {(byte) 'f', (byte) 'i', (byte) 'g', (byte) 'u', (byte) 'r', (byte) 'e'};
        public static readonly byte[] Figcaption    = {(byte) 'f', (byte) 'i', (byte) 'g', (byte) 'c', (byte) 'a', (byte) 'p', (byte) 't', (byte) 'i', (byte) 'o', (byte) 'n'};
        public static readonly byte[] Main          = {(byte) 'm', (byte) 'a', (byte) 'i', (byte) 'n'};
        public static readonly byte[] Div           = {(byte) 'd', (byte) 'i', (byte) 'v'};
        public static readonly byte[] A             = {(byte) 'a' };
        public static readonly byte[] Em            = {(byte) 'e', (byte) 'm'};
        public static readonly byte[] Strong        = {(byte) 's', (byte) 't', (byte) 'r', (byte) 'o', (byte) 'n', (byte) 'g'};
        public static readonly byte[] Small         = {(byte) 's', (byte) 'm', (byte) 'a', (byte) 'l', (byte) 'l'};
        public static readonly byte[] S             = {(byte) 's' };
        public static readonly byte[] Cite          = {(byte) 'c', (byte) 'i', (byte) 't', (byte) 'e'};
        public static readonly byte[] Q             = {(byte) 'q' };
        public static readonly byte[] Dfn           = {(byte) 'd', (byte) 'f', (byte) 'n'};
        public static readonly byte[] Abbr          = {(byte) 'a', (byte) 'b', (byte) 'b', (byte) 'r'};
        public static readonly byte[] Data          = {(byte) 'd', (byte) 'a', (byte) 't', (byte) 'a'};
        public static readonly byte[] Time          = {(byte) 't', (byte) 'i', (byte) 'm', (byte) 'e'};
        public static readonly byte[] Code          = {(byte) 'c', (byte) 'o', (byte) 'd', (byte) 'e'};
        public static readonly byte[] Var           = {(byte) 'v', (byte) 'a', (byte) 'r'};
        public static readonly byte[] Samp          = {(byte) 's', (byte) 'a', (byte) 'm', (byte) 'p'};
        public static readonly byte[] Kbd           = {(byte) 'k', (byte) 'b', (byte) 'd'};
        public static readonly byte[] Sub           = {(byte) 's', (byte) 'u', (byte) 'b'};
        public static readonly byte[] Sup           = {(byte) 's', (byte) 'u', (byte) 'p'};
        public static readonly byte[] I             = {(byte) 'i' };
        public static readonly byte[] B             = {(byte) 'b' };
        public static readonly byte[] U             = {(byte) 'u' };
        public static readonly byte[] Mark          = {(byte) 'm', (byte) 'a', (byte) 'r', (byte) 'k'};
        public static readonly byte[] Ruby          = {(byte) 'r', (byte) 'u', (byte) 'b', (byte) 'y'};
        public static readonly byte[] Rt            = {(byte) 'r', (byte) 't'};
        public static readonly byte[] Rp            = {(byte) 'r', (byte) 'p'};
        public static readonly byte[] Bdi           = {(byte) 'b', (byte) 'd', (byte) 'i'};
        public static readonly byte[] Bdo           = {(byte) 'b', (byte) 'd', (byte) 'o'};
        public static readonly byte[] Span          = {(byte) 's', (byte) 'p', (byte) 'a', (byte) 'n'};
        public static readonly byte[] Br            = {(byte) 'b', (byte) 'r'};
        public static readonly byte[] Wbr           = {(byte) 'w', (byte) 'b', (byte) 'r'};
        public static readonly byte[] Ins           = {(byte) 'i', (byte) 'n', (byte) 's'};
        public static readonly byte[] Del           = {(byte) 'd', (byte) 'e', (byte) 'l'};
        public static readonly byte[] Image         = {(byte) 'i', (byte) 'm', (byte) 'a', (byte) 'g', (byte) 'e'};
        public static readonly byte[] Img           = {(byte) 'i', (byte) 'm', (byte) 'g'};
        public static readonly byte[] Iframe        = {(byte) 'i', (byte) 'f', (byte) 'r', (byte) 'a', (byte) 'm', (byte) 'e'};
        public static readonly byte[] Embed         = {(byte) 'e', (byte) 'm', (byte) 'b', (byte) 'e', (byte) 'd'};
        public static readonly byte[] Object        = {(byte) 'o', (byte) 'b', (byte) 'j', (byte) 'e', (byte) 'c', (byte) 't'};
        public static readonly byte[] Param         = {(byte) 'p', (byte) 'a', (byte) 'r', (byte) 'a', (byte) 'm'};
        public static readonly byte[] Video         = {(byte) 'v', (byte) 'i', (byte) 'd', (byte) 'e', (byte) 'o'};
        public static readonly byte[] Audio         = {(byte) 'a', (byte) 'u', (byte) 'd', (byte) 'i', (byte) 'o'};
        public static readonly byte[] Source        = {(byte) 's', (byte) 'o', (byte) 'u', (byte) 'r', (byte) 'c', (byte) 'e'};
        public static readonly byte[] Track         = {(byte) 't', (byte) 'r', (byte) 'a', (byte) 'c', (byte) 'k'};
        public static readonly byte[] Canvas        = {(byte) 'c', (byte) 'a', (byte) 'n', (byte) 'v', (byte) 'a', (byte) 's'};
        public static readonly byte[] Map           = {(byte) 'm', (byte) 'a', (byte) 'p'};
        public static readonly byte[] Area          = {(byte) 'a', (byte) 'r', (byte) 'e', (byte) 'a'};
        public static readonly byte[] Math          = {(byte) 'm', (byte) 'a', (byte) 't', (byte) 'h'};
        public static readonly byte[] Mi            = {(byte) 'm', (byte) 'i'};
        public static readonly byte[] Mo            = {(byte) 'm', (byte) 'o'};
        public static readonly byte[] Mn            = {(byte) 'm', (byte) 'n'};
        public static readonly byte[] Ms            = {(byte) 'm', (byte) 's'};
        public static readonly byte[] Mtext         = {(byte) 'm', (byte) 't', (byte) 'e', (byte) 'x', (byte) 't'};
        public static readonly byte[] Mglyph        = {(byte) 'm', (byte) 'g', (byte) 'l', (byte) 'y', (byte) 'p', (byte) 'h'};
        public static readonly byte[] Malignmark    = {(byte) 'm', (byte) 'a', (byte) 'l', (byte) 'i', (byte) 'g', (byte) 'n', (byte) 'm', (byte) 'a', (byte) 'r', (byte) 'k'};
        public static readonly byte[] AnnotationXml = {(byte) 'a', (byte) 'n', (byte) 'n', (byte) 'o', (byte) 't', (byte) 'a', (byte) 't', (byte) 'i', (byte) 'o', (byte) 'n', (byte) '-', (byte) 'x', (byte) 'm', (byte) 'l'};
        public static readonly byte[] Svg           = {(byte) 's', (byte) 'v', (byte) 'g'};
        public static readonly byte[] Foreignobject = {(byte) 'f', (byte) 'o', (byte) 'r', (byte) 'e', (byte) 'i', (byte) 'g', (byte) 'n', (byte) 'o', (byte) 'b', (byte) 'j', (byte) 'e', (byte) 'c', (byte) 't'};
        public static readonly byte[] Desc          = {(byte) 'd', (byte) 'e', (byte) 's', (byte) 'c'};
        public static readonly byte[] Table         = {(byte) 't', (byte) 'a', (byte) 'b', (byte) 'l', (byte) 'e'};
        public static readonly byte[] Caption       = {(byte) 'c', (byte) 'a', (byte) 'p', (byte) 't', (byte) 'i', (byte) 'o', (byte) 'n'};
        public static readonly byte[] Colgroup      = {(byte) 'c', (byte) 'o', (byte) 'l', (byte) 'g', (byte) 'r', (byte) 'o', (byte) 'u', (byte) 'p'};
        public static readonly byte[] Col           = {(byte) 'c', (byte) 'o', (byte) 'l'};
        public static readonly byte[] Tbody         = {(byte) 't', (byte) 'b', (byte) 'o', (byte) 'd', (byte) 'y'};
        public static readonly byte[] Thead         = {(byte) 't', (byte) 'h', (byte) 'e', (byte) 'a', (byte) 'd'};
        public static readonly byte[] Tfoot         = {(byte) 't', (byte) 'f', (byte) 'o', (byte) 'o', (byte) 't'};
        public static readonly byte[] Tr            = {(byte) 't', (byte) 'r'};
        public static readonly byte[] Td            = {(byte) 't', (byte) 'd'};
        public static readonly byte[] Th            = {(byte) 't', (byte) 'h'};
        public static readonly byte[] Form          = {(byte) 'f', (byte) 'o', (byte) 'r', (byte) 'm'};
        public static readonly byte[] Fieldset      = {(byte) 'f', (byte) 'i', (byte) 'e', (byte) 'l', (byte) 'd', (byte) 's', (byte) 'e', (byte) 't'};
        public static readonly byte[] Legend        = {(byte) 'l', (byte) 'e', (byte) 'g', (byte) 'e', (byte) 'n', (byte) 'd'};
        public static readonly byte[] Label         = {(byte) 'l', (byte) 'a', (byte) 'b', (byte) 'e', (byte) 'l'};
        public static readonly byte[] Input         = {(byte) 'i', (byte) 'n', (byte) 'p', (byte) 'u', (byte) 't'};
        public static readonly byte[] Button        = {(byte) 'b', (byte) 'u', (byte) 't', (byte) 't', (byte) 'o', (byte) 'n'};
        public static readonly byte[] Select        = {(byte) 's', (byte) 'e', (byte) 'l', (byte) 'e', (byte) 'c', (byte) 't'};
        public static readonly byte[] Datalist      = {(byte) 'd', (byte) 'a', (byte) 't', (byte) 'a', (byte) 'l', (byte) 'i', (byte) 's', (byte) 't'};
        public static readonly byte[] Optgroup      = {(byte) 'o', (byte) 'p', (byte) 't', (byte) 'g', (byte) 'r', (byte) 'o', (byte) 'u', (byte) 'p'};
        public static readonly byte[] Option        = {(byte) 'o', (byte) 'p', (byte) 't', (byte) 'i', (byte) 'o', (byte) 'n'};
        public static readonly byte[] Textarea      = {(byte) 't', (byte) 'e', (byte) 'x', (byte) 't', (byte) 'a', (byte) 'r', (byte) 'e', (byte) 'a'};
        public static readonly byte[] Keygen        = {(byte) 'k', (byte) 'e', (byte) 'y', (byte) 'g', (byte) 'e', (byte) 'n'};
        public static readonly byte[] Output        = {(byte) 'o', (byte) 'u', (byte) 't', (byte) 'p', (byte) 'u', (byte) 't'};
        public static readonly byte[] Progress      = {(byte) 'p', (byte) 'r', (byte) 'o', (byte) 'g', (byte) 'r', (byte) 'e', (byte) 's', (byte) 's'};
        public static readonly byte[] Meter         = {(byte) 'm', (byte) 'e', (byte) 't', (byte) 'e', (byte) 'r'};
        public static readonly byte[] Details       = {(byte) 'd', (byte) 'e', (byte) 't', (byte) 'a', (byte) 'i', (byte) 'l', (byte) 's'};
        public static readonly byte[] Summary       = {(byte) 's', (byte) 'u', (byte) 'm', (byte) 'm', (byte) 'a', (byte) 'r', (byte) 'y'};
        public static readonly byte[] Menu          = {(byte) 'm', (byte) 'e', (byte) 'n', (byte) 'u'};
        public static readonly byte[] Menuitem      = {(byte) 'm', (byte) 'e', (byte) 'n', (byte) 'u', (byte) 'i', (byte) 't', (byte) 'e', (byte) 'm'};
        public static readonly byte[] Applet        = {(byte) 'a', (byte) 'p', (byte) 'p', (byte) 'l', (byte) 'e', (byte) 't'};
        public static readonly byte[] Acronym       = {(byte) 'a', (byte) 'c', (byte) 'r', (byte) 'o', (byte) 'n', (byte) 'y', (byte) 'm'};
        public static readonly byte[] Bgsound       = {(byte) 'b', (byte) 'g', (byte) 's', (byte) 'o', (byte) 'u', (byte) 'n', (byte) 'd'};
        public static readonly byte[] Dir           = {(byte) 'd', (byte) 'i', (byte) 'r'};
        public static readonly byte[] Frame         = {(byte) 'f', (byte) 'r', (byte) 'a', (byte) 'm', (byte) 'e'};
        public static readonly byte[] Frameset      = {(byte) 'f', (byte) 'r', (byte) 'a', (byte) 'm', (byte) 'e', (byte) 's', (byte) 'e', (byte) 't'};
        public static readonly byte[] Noframes      = {(byte) 'n', (byte) 'o', (byte) 'f', (byte) 'r', (byte) 'a', (byte) 'm', (byte) 'e', (byte) 's'};
        public static readonly byte[] Isindex       = {(byte) 'i', (byte) 's', (byte) 'i', (byte) 'n', (byte) 'd', (byte) 'e', (byte) 'x'};
        public static readonly byte[] Listing       = {(byte) 'l', (byte) 'i', (byte) 's', (byte) 't', (byte) 'i', (byte) 'n', (byte) 'g'};
        public static readonly byte[] Xmp           = {(byte) 'x', (byte) 'm', (byte) 'p'};
        public static readonly byte[] Nextid        = {(byte) 'n', (byte) 'e', (byte) 'x', (byte) 't', (byte) 'i', (byte) 'd'};
        public static readonly byte[] Noembed       = {(byte) 'n', (byte) 'o', (byte) 'e', (byte) 'm', (byte) 'b', (byte) 'e', (byte) 'd'};
        public static readonly byte[] Plaintext     = {(byte) 'p', (byte) 'l', (byte) 'a', (byte) 'i', (byte) 'n', (byte) 't', (byte) 'e', (byte) 'x', (byte) 't'};
        public static readonly byte[] Rb            = {(byte) 'r', (byte) 'b'};
        public static readonly byte[] Strike        = {(byte) 's', (byte) 't', (byte) 'r', (byte) 'i', (byte) 'k', (byte) 'e'};
        public static readonly byte[] Basefont      = {(byte) 'b', (byte) 'a', (byte) 's', (byte) 'e', (byte) 'f', (byte) 'o', (byte) 'n', (byte) 't'};
        public static readonly byte[] Big           = {(byte) 'b', (byte) 'i', (byte) 'g'};
        public static readonly byte[] Blink         = {(byte) 'b', (byte) 'l', (byte) 'i', (byte) 'n', (byte) 'k'};
        public static readonly byte[] Center        = {(byte) 'c', (byte) 'e', (byte) 'n', (byte) 't', (byte) 'e', (byte) 'r'};
        public static readonly byte[] Font          = {(byte) 'f', (byte) 'o', (byte) 'n', (byte) 't'};
        public static readonly byte[] Marquee       = {(byte) 'm', (byte) 'a', (byte) 'r', (byte) 'q', (byte) 'u', (byte) 'e', (byte) 'e'};
        public static readonly byte[] Multicol      = {(byte) 'm', (byte) 'u', (byte) 'l', (byte) 't', (byte) 'i', (byte) 'c', (byte) 'o', (byte) 'l'};
        public static readonly byte[] Nobr          = {(byte) 'n', (byte) 'o', (byte) 'b', (byte) 'r'};
        public static readonly byte[] Spacer        = {(byte) 's', (byte) 'p', (byte) 'a', (byte) 'c', (byte) 'e', (byte) 'r'};
        public static readonly byte[] Tt            = {(byte) 't', (byte) 't'};
        public static readonly byte[] Rtc           = {(byte) 'r', (byte) 't', (byte) 'c'};
    }
}
