using System;

public class WinScripture
{
    private string _word = "";
    private bool _isHidden = false;

    public string GetWord() {
        return _word;
    }

    public void SetWord(string word) {
        _word = word;
    }

    public bool GetisHidden() {
        return _isHidden;
    }

    public void SetisHidden(bool tf) {
        _isHidden = tf;
    }

    public void HideWord() {
        // Scripture _s = new();
        // int length = _s._verseList[i].GetWord().Length;
        // string replace = new string('_', length);
        // _s._verseList[i].SetWord(replace);

        int length = _word.Length;
        string replace = new string('_', length);
        SetWord(replace);
    }
}

// string midWord = _s._verseList[5].GetWord();
// int length = midWord.Length;