using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = text.Split(' ').Select(w => new Word(w)).ToList();
        }

        public string Display()
        {
            return $"{_reference.GetReference()}\n{GetScriptureString()}";
        }

        private string GetScriptureString()
        {
            return string.Join(" ", _words.Select(w => w.IsMemorized() ? "_____" : w.GetText()));
        }

        public void HideRandomWords(int count)
        {
            Random random = new Random();
            var unmemorizedWords = _words.Where(w => !w.IsMemorized()).ToList();
            for (int i = 0; i < count && unmemorizedWords.Any(); i++)
            {
                int index = random.Next(unmemorizedWords.Count);
                unmemorizedWords[index].Memorize();
                unmemorizedWords.RemoveAt(index);
            }
        }

        public void MemorizeWord(string wordText)
        {
            var word = _words.FirstOrDefault(w => w.GetText().Equals(wordText, StringComparison.OrdinalIgnoreCase));
            if (word != null)
            {
                word.Memorize();
            }
        }

        public int GetMemorizedCount() => _words.Count(w => w.IsMemorized());

        public int GetTotalWords() => _words.Count;
    }
}


