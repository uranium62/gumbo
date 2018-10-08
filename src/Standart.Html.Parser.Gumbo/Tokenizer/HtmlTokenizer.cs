namespace Standart.Html.Parser.Gumbo
{
    using System;
    using System.Text;

    /**
    * This is the main tokenizer state struct, containing all state used by in
    * tokenizing the input stream.
    */
    public partial class HtmlTokenizer
    {
        // The current lexer state. Starts in LEX_DATA.
        private HtmlTokenizerEnum _state;

        // A flag indicating whether the current input character needs to reconsumed
        // in another state, or whether the next input character should be read for
        // the next iteration of the state loop.  This is set when the spec reads
        // "Reconsume the current input character in..."
        private bool _reconsumeCurrentInput;

        // A flag indicating whether the current node is a foreign element. This is
        // set by gumbo_tokenizer_set_is_current_node_foreign and checked in the
        // markup declaration state.
        private bool _isCurrentNodeForeign;

        
        // A flag indicating whether the tokenizer is in a CDATA section.  If so, then
        // text tokens emitted will be TOKEN_CDATA.
        private bool _isInCdata;

        // Certain states (notably character references) may emit two character tokens
        // at once, but the contract for lex() fills in only one token at a time.  The
        // extra character is buffered here, and then this is checked on entry to
        // lex().  If a character is stored here, it's immediately emitted and control
        // returns from the lexer. NO_CHAR is used to represent 'no character
        // stored.'
        //
        // Note that characters emitted through this mechanism will have their source
        // position marked as the character under the mark, i.e. multiple characters
        // may be emitted with the same position.  This is desirable for character
        // references, but unsuitable for many other cases.  Use the _temporary_buffer
        // mechanism if the buffered characters must have their original positions in
        // the document.
        private int _bufferedEmitChar;

        // A temporary buffer to accumulate characters, as described by the "temporary
        // buffer" phrase in the tokenizer spec.  We use this in a somewhat unorthodox
        // way: we record the specific character to go into the buffer, which may
        // sometimes be a lowercased version of the actual input character.  However,
        // we *also* use utf8iterator_mark() to record the position at tag start.
        // When we start flushing the temporary buffer, we set _temporary_buffer_emit
        // to the start of it, and then increment it for each call to the tokenizer.
        // We also call utf8iterator_reset(), and utf8iterator_next() through the
        // input stream, so that tokens emitted by emit_char have the correct position
        // and original text.
        private StringBuilder _temporaryBuffer;

        // The current cursor position we're emitting from within
        // _temporary_buffer.data.  NULL whenever we're not flushing the buffer.
        private ReadOnlyMemory<char> _temporaryBufferEmit;

        // The temporary buffer is also used by the spec to check whether we should
        // enter the script data double escaped state, but we can't use the same
        // buffer for both because we have to flush out "<s" as emits while still
        // maintaining the context that will eventually become "script".  This is a
        // separate buffer that's used in place of the temporary buffer for states
        // that may enter the script data double escape start state.
        private StringBuilder _scriptDataBuffer;

        // Pointer to the beginning of the current token in the original buffer; used
        // to record the original text.
        private ReadOnlyMemory<char> _tokenStart;

        // GumboSourcePosition recording the source location of the start of the
        // current token.
        private HtmlSourcePosition _tokenStartPos;

        // Current tag state.
        private HtmlTagState _tagState;

        // Doctype state.  We use the temporary buffer to accumulate characters (it's
        // not used for anything else in the doctype states), and then freshly
        // allocate the strings in the doctype token, then copy it over on emit.
        private HtmlTokenDocType _docTypeState;
        
        // The UTF8Iterator over the tokenizer input.
        // Utf8Iterator _input;

        public const int NO_CHAR = -1;
    }
}