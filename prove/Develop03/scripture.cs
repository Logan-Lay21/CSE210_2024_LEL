using System;
using System.Runtime.CompilerServices;
using System.Formats.Asn1;

// Alma 37:6

public class Scripture
{
    private string _verse = "Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise.";

    public List<WinScripture> _verseList = new();

    public Scripture() {
        string [] transfer = _verse.Split(" ");
        foreach (string word in transfer) {
            WinScripture wis = new();
            wis.SetWord(word); 
            _verseList.Add(wis);
        }
    }

    public bool RandomIndex() {
        Random randomGenerator = new Random();
        int i = randomGenerator.Next(0,_verseList.Count);
        int count = 0;
        int wordsLeft = 0;
        foreach (WinScripture word in _verseList) {
            if (!word.GetisHidden()){
                wordsLeft++;
            };
        }
        do {
            if (_verseList[i].GetisHidden() == false) {
                _verseList[i].HideWord();
                _verseList[i].SetisHidden(true);
                count++;
                wordsLeft -= 1;
            }

            else {
                i = randomGenerator.Next(0,_verseList.Count);
            }
        } while ((count < 3) && (!(wordsLeft == 0)));
        if (wordsLeft == 0) {
            // Console.WriteLine("No wordy :)");
            return true;
        }
        else {
            // Console.WriteLine("You lying???");
            return false;
        }
    }

    public void DisplayScripture() {
        Reference _r = new Reference("Alma", "36", "7");
        _r.DisplayReference();
        foreach (WinScripture word in _verseList) {
            Console.Write($"{word.GetWord()} ");
        }
    }

    public string GetVerse()
    {
        return _verse;
    }

}
