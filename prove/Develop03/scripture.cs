using System;
using System.Runtime.CompilerServices;
using System.Formats.Asn1;

// Alma 37:6

public class Scripture
{
    private string _verse = "Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise.";

    public List<WinScripture> _verseList = new();

    public void DefVerseList() {
        // int x = 0;
        string [] transfer = _verse.Split(" ");
        foreach (string word in transfer) {
            WinScripture wis = new();
            wis.SetWord(word); 
            _verseList.Add(wis);
            // Console.WriteLine(_verseList[x].GetWord());
            // Console.WriteLine(_verseList[x].GetisHidden());

            // x++;
        }
    }

    public void RandomIndex() {
        Random randomGenerator = new Random();
        int i = randomGenerator.Next(0,38);
        int count = 0;
        do {
            if (_verseList[i].GetisHidden() == false) {
                WinScripture wis = new();
                wis.HideWord(i);
                wis.SetisHidden(true);
                count++;
            }
            else {
            i = randomGenerator.Next(1,38);
            }
        } while (count != 3);

            
            
    }

    public string GetVerse()
    {
        return _verse;
    }

}
