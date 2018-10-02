namespace Standart.Html.Gumbo
{
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
}
