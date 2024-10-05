class Costume
{
    //attributes (member variables)
    public string headWear;
    public string handWear;
    public string footWear;
    public string upperBodyWear;
    public string lowerBodyWear;
    public string accessory;
    //behaviors (member function, or *methods*)
    public void ShowWardrobe()
    {
        string result = "";
        result += "\nHead gear: " + headWear;
        result += "\nHand gear: " + handWear;
        result += "\nFoot gear: " + upperBodyWear;
        result += "\nTorso gear: " + lowerBodyWear;
        result += "\nLeg gear: " + footWear;
        result += "\nAccessory: " + accessory;
        Console.WriteLine(result + "\n");
    }
}