using System;
using System.Collections.Concurrent;
using System.Threading.Channels;

class Reference
{
    public string _book = "";
    public string _chpt = "";
    public string  _v1 = "";
    public string _v2 = " ";

    public Reference(string book, string chpt, string startVerse) {
        _book = book;
        _chpt = chpt;
        _v1 = startVerse;
    }

    public Reference(string book, string chpt, string startVerse, string endVerse) {
        _book = book;
        _chpt = chpt;
        _v1 = startVerse;
        _v2 = endVerse;
    }

    public void DisplayReference() {
        if (_v2 == " ") {
            Console.Write($"{_book} {_chpt}:{_v1} ");
        }
        else {
            Console.Write($"{_book} {_chpt}:{_v1}-{_v2} ");
        }
    }
}
