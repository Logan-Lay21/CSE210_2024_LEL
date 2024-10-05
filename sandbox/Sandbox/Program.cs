using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Costume nurse = new();
        nurse.headWear = "face mask";
        nurse.handWear = "nitrile gloves";
        nurse.footWear = "orthopedic sneakers";
        nurse.upperBodyWear = "scrubs";
        nurse.lowerBodyWear = "scrubs";
        nurse.accessory = "stethoscope";

        Costume detective = new();
        detective.headWear = "fedora";
        detective.handWear = "leather";
        detective.footWear = "loafers";
        detective.upperBodyWear = "trenchcoat";
        detective.lowerBodyWear = "slacks";
        detective.accessory = "magnifying glass";

        Costume rancher = new();
        rancher.headWear = "cowboy hat";
        rancher.handWear = "leather";
        rancher.footWear = "boots";
        rancher.upperBodyWear = "flannel shirt";
        rancher.lowerBodyWear = "jeans";
        rancher.accessory = "lasso";

        Console.WriteLine("Nurse Costume");
        nurse.ShowWardrobe();
        Console.WriteLine("Detective Costume");
        detective.ShowWardrobe();
        Console.WriteLine("Rancher Costume");
        rancher.ShowWardrobe();
    }
}