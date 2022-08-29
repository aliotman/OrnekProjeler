internal class Program
{
    private static void Main(string[] args)
    {
        string degisken="Dersimiz CSharp, Hosgeldiniz!";
        string degisken2="dersimiz CSharp, Hosgeldiniz!";

        //Length;
        Console.WriteLine(degisken.Length);
        //ToUpper , ToLower
        Console.WriteLine(degisken.ToUpper());
        Console.WriteLine(degisken.ToLower());

        //Concat
        Console.WriteLine(string.Concat(degisken,"Merhaba"));
        //Compare , CompareTo
        Console.WriteLine(degisken.CompareTo(degisken2)); //çıktısı -1 , 0 , 1 ;
        Console.WriteLine(string.Compare(degisken,degisken2,true)); //buyuk kucuk harf duyarlılığı yok
        Console.WriteLine(string.Compare(degisken,degisken2,false));//buyuk kucuk harf duyarlılığı var

        //Contains
        Console.WriteLine(degisken.Contains(degisken2)); //degisken'in içinde degisken2 var mı? kontrol et
        Console.WriteLine(degisken.EndsWith("Hosgeldiniz!")); //çıktı true
        Console.WriteLine(degisken.StartsWith("Merhaba!")); //çıktı false

        //IndexOf , LastIndexOf
        Console.WriteLine(degisken.IndexOf("CS")); //yazılan şeyin ilk karakterinin indexi döner
        Console.WriteLine(degisken.IndexOf("Zikriye")); //bulamadığı için çıktısı -1
        Console.WriteLine(degisken.LastIndexOf("i")); //birden fazla i var ama bulduğu son indexi getirir

        //Insert
        Console.WriteLine(degisken.Insert(0,"Merhaba!")); // 0. indexe girilen kelimeyi ekler

        //PadLeft , PadRight
        Console.WriteLine(degisken+degisken2.PadLeft(30)); //karakter sayısını 30a tamamlayacak kadar girilen karakteri ekler(bir şey yazmazsak boşluk ekler)
        Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
        Console.WriteLine(degisken.PadRight(50)+degisken2);
        Console.WriteLine(degisken.PadRight(50,'-')+degisken2);
        
        //Remove
        Console.WriteLine(degisken.Remove(10)); //10.indexten sonrasını siler ve 10.index öncesini getirir
        Console.WriteLine(degisken.Remove(5,3)); //5.indexten başlayarak 3 karakter sil
        Console.WriteLine(degisken.Remove(0,1)); //0.indexten başlayarak 1 karakter sil

        //Replace
        Console.WriteLine(degisken.Replace("CSharp","C#")); //CSharp kelimesini C# ile değiştirir
        Console.WriteLine(degisken.Replace(" ","*")); // Boşlukları * a çevirir

        //Split
        Console.WriteLine(degisken.Split(' ')[1]);//Boşluğa göre kelimeleri parçalayıp diziye atar ve 1.indexi döndürür

        //Substring
        Console.WriteLine(degisken.Substring(4)); //4.indexten başlayıp son indexe kadar getirir
        Console.WriteLine(degisken.Substring(4,6)); //4.indexten başlayıp 6 karakter getirir

    }
}