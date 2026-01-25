using System;
using System.Collections.Generic;
using System.Linq;


namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Reference reference = new Reference("John", 3, 16);
            Scripture scripture = new Scripture(reference, 
                "For God so loved the world that he gave his one and only Son, " +
                "that whoever believes in him shall not perish but have eternal life.");

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                
                if (scripture.AllWordsHidden())
                {
                    Console.WriteLine("\nAll words are hidden. Good job!");
                    break;
                }

                Console.WriteLine("\nPress Enter to hide some words or type 'quit' to exit:");
                string input = Console.ReadLine().Trim().ToLower();

                if (input == "quit")
                    break;

                
                scripture.HideRandomWords(3);
            }

            Console.WriteLine("Thanks for using Scripture Memorizer!");
        }
    }

    class Word
    {
        private string _text;
        private bool _isHidden;

        public Word(string text)
        {
            _text = text;
            _isHidden = false;
        }

        public void Hide()
        {
            _isHidden = true;
        }

        public bool IsHidden()
        {
            return _isHidden;
        }

        public string GetDisplayText()
        {
            return _isHidden ? new string('_', _text.Length) : _text;
        }
    }

    class Reference
    {
        private string _book;
        private int _chapter;
        private int _startVerse;
        private int? _endVerse;

        
        public Reference(string book, int chapter, int startVerse)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = startVerse;
            _endVerse = null;
        }

    
        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = startVerse;
            _endVerse = endVerse;
        }

        public string GetDisplayText()
        {
            return _endVerse.HasValue 
                ? $"{_book} {_chapter}:{_startVerse}-{_endVerse.Value}" 
                : $"{_book} {_chapter}:{_startVerse}";
        }
    }

    class Scripture
    {
        private Reference _reference;
        private List<Word> _words;
        private Random _random;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = text.Split(' ').Select(w => new Word(w)).ToList();
            _random = new Random();
        }

        public void HideRandomWords(int count)
        {
            
            var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

            if (visibleWords.Count == 0) return;

            for (int i = 0; i < count; i++)
            {
                if (visibleWords.Count == 0) break;

                int index = _random.Next(visibleWords.Count);
                visibleWords[index].Hide();

                // Remove from visible list so we don't hide the same word twice
                visibleWords.RemoveAt(index);
            }
        }

        public string GetDisplayText()
        {
            return $"{_reference.GetDisplayText()} {string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
        }

        public bool AllWordsHidden()
        {
            return _words.All(w => w.IsHidden());
        }
    }
}