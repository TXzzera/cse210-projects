using System;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private int _hideCount = 0;
     private List<int> _randomWordsToHide = new List<int>();

    public Scripture(Reference reference, string text)
    {
        string[] words = text.Split(" ");

        foreach(string wordText in words){
            Word word = new Word(wordText);
            _words.Add(word);
        }
        _reference = reference;
        generateRandomWordsToHide();
    }
    
    public void HideWords(int numberHidden)
    {
        int wordsToHide = Math.Min(numberHidden, _randomWordsToHide.Count - _hideCount); // Garante que não tente esconder mais palavras do que existem

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = _randomWordsToHide[_hideCount];
            _words[index].Hide();
            _hideCount++;
        }
    }

    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in _words)
        {
            text += $"{word.GetDisplayText()} ";
        }
        return $"{_reference.GetDisplayText()} {text.Trim()}";
    }

    public bool TotalHidden()
    {
        return _hideCount == _words.Count;
    }

    private void generateRandomWordsToHide()
    {
        for (int i = 0; i < _words.Count; i++)
        {
            _randomWordsToHide.Add(i);
        }

        Random random = new Random();
        for (int i = _randomWordsToHide.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            int temp = _randomWordsToHide[i];
            _randomWordsToHide[i] = _randomWordsToHide[j];
            _randomWordsToHide[j] = temp;
        }
    }
}