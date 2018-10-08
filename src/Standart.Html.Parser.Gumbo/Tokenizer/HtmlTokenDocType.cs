namespace Standart.Html.Parser.Gumbo
{
    /**
    * The class containing all information pertaining to doctype tokens. 
    */
    public class HtmlTokenDocType
    {
        public string Name;
        public string PublicIdentifier;
        public string SystemIdentifier;
        public bool ForceQuirks;
        
        // There's no way to tell a 0-length public or system ID apart from the
        // absence of a public or system ID, but they're handled different by the
        // spec, so we need bool flags for them.
        public bool HasPublicIdentifier;
        public bool HasSystemIdentifier;
    }
}