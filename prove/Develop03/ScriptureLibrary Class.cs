using System;
using System.Collections.Generic;
using System.IO;

namespace ScriptureMemorizer
{
    public class ScriptureLibrary
    {
        private List<Scripture> _scriptures;

        public ScriptureLibrary(string filePath)
        {
            _scriptures = new List<Scripture>();
            LoadScriptures(filePath);
        }

        private void LoadScriptures(string filePath)
        {
            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split('|');
                if (parts.Length == 2)
                {
                    var referenceParts = parts[0].Split(' ');
                    var book = referenceParts[0];
                    var chapterVerse = referenceParts[1].Split(':');
                    var chapter = int.Parse(chapterVerse[0]);
                    var verses = chapterVerse[1].Split('-');
                    var verseStart = int.Parse(verses[0]);
                    var verseEnd = verses.Length > 1 ? int.Parse(verses[1]) : verseStart;

                    var reference = new Reference(book, chapter, verseStart, verseEnd);
                    var text = parts[1];

                    _scriptures.Add(new Scripture(reference, text));
                }
            }
        }

        public Scripture GetRandomScripture()
        {
            Random random = new Random();
            return _scriptures[random.Next(_scriptures.Count)];
        }
    }
}



