namespace Standart.Html.Gumbo
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit)]
    public struct SourcePosition
    {
        [FieldOffset(0)]
        public uint Line;
        [FieldOffset(4)]
        public uint Column;
        [FieldOffset(8)]
        public uint Offset;
    }
}