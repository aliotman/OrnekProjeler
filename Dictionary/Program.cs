using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int,string> kullanicilar=new Dictionary<int, string>();
        kullanicilar.Add(10,"Ayşe Yılmaz");
        kullanicilar.Add(12,"Ahmet Yılmaz");
        kullanicilar.Add(18,"Deniz Arda");
        kullanicilar.Add(20,"Özcan Coşar");

        //Dizinin Elemanlarına Erişim
        Console.WriteLine("****** Elemanlara Erişim ********");
        Console.WriteLine(kullanicilar(12));
        foreach (var item in kullanicilar)
            Console.WriteLine(item);

        //Count eleman sayısı
        Console.WriteLine("****** Count ********");
        Console.WriteLine(kullanicilar.Count);

        //Contains
        Console.WriteLine("****** Contains ********");
        Console.WriteLine(kullanicilar.ContainsKey(12)); //çıktısı true
        Console.WriteLine(kullanicilar.ContainsValue("Zikriye Ürkmez")); //çıktısı false

        //Remove
        Console.WriteLine("****** Remove ********");
        Console.WriteLine(kullanicilar.Remove(12));
        foreach (var item in kullanicilar)
            Console.WriteLine(item);

        //Keys Yazdırma
        Console.WriteLine("****** Keys ********");
        foreach (var item in kullanicilar.Keys)
        {
            Console.WriteLine(item);
        }
        //Values yazdırma
        Console.WriteLine("****** Values ********");
        foreach (var item in kullanicilar.Values)
        {
            Console.WriteLine(item);
        }

    }
}