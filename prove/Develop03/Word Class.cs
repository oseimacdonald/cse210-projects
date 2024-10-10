namespace ScriptureMemorizer
{
    public class Word
    {
        private string _text;
        private bool _isMemorized;

        public Word(string text)
        {
            _text = text;
            _isMemorized = false;
        }

        public string GetText() => _text;

        public bool IsMemorized() => _isMemorized;

        public void Memorize() => _isMemorized = true;
    }
}

