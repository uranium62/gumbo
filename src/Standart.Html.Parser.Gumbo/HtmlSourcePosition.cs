namespace Standart.Html.Parser.Gumbo
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit)]
    public struct HtmlSourcePosition
    {
        [FieldOffset(0)]
        public uint Line;
        [FieldOffset(4)]
        public uint Column;
        [FieldOffset(8)]
        public uint Offset;

        public static HtmlSourcePosition Empty => new HtmlSourcePosition();
    }
}