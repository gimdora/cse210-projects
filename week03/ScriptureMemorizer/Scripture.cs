using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = [];

        string[] parts = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<int> visibleIndexes = [];

        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndexes.Add(i);
            }
        }

        if (visibleIndexes.Count == 0)
        {
            return;
        }

        Random random = new();

        for (int i = 0; i < numberToHide; i++)
        {
            if (visibleIndexes.Count == 0)
            {
                break;
            }

            int randIndexInVisible = random.Next(visibleIndexes.Count);
            int wordIndex = visibleIndexes[randIndexInVisible];

            _words[wordIndex].Hide();

            visibleIndexes.RemoveAt(randIndexInVisible);
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();

        List<string> wordTexts = [];
        foreach (Word word in _words)
        {
            wordTexts.Add(word.GetDisplayText());
        }

        string scriptureText = string.Join(" ", wordTexts);
        return $"{referenceText} {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
