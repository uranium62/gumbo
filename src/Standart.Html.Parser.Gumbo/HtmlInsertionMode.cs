namespace Standart.Html.Parser.Gumbo
{
    // http://www.whatwg.org/specs/web-apps/current-work/complete/parsing.html#insertion-mode
    // If new enum values are added, be sure to update the TokenHandlers dispatch
    // table in parser
    public enum HtmlInsertionMode
    {
        INITIAL,
        BEFORE_HTML,
        BEFORE_HEAD,
        IN_HEAD,
        IN_HEAD_NOSCRIPT,
        AFTER_HEAD,
        IN_BODY,
        TEXT,
        IN_TABLE,
        IN_TABLE_TEXT,
        IN_CAPTION,
        IN_COLUMN_GROUP,
        IN_TABLE_BODY,
        IN_ROW,
        IN_CELL,
        IN_SELECT,
        IN_SELECT_IN_TABLE,
        IN_TEMPLATE,
        AFTER_BODY,
        IN_FRAMESET,
        AFTER_FRAMESET,
        AFTER_AFTER_BODY,
        AFTER_AFTER_FRAMESET
    }
}
