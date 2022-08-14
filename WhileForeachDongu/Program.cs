internal class Program
{
    private static void Main(string[] args)
    {
        //while
        //1den başlayıp konsoldan girilen sayı dahil ortalama hesaplayıp yazdırma
        Console.WriteLine("Bir sayı girin:");
        int sayi=int.Parse(Console.ReadLine());
        int sayac=1;
        int toplam=0;
        while (sayac==sayi)
        {
            toplam+=sayac;
            sayac++;
        }
        Console.WriteLine(toplam/sayac);

        //A'dan Z'ye kadar tüm harfleri yazdırma
        char character='a';
        while (character < 'z')
        {
            Console.Write(character);
            character++;
        }

        //Foreach
        string[] arabalar={"BMW","Ford","Toyota","Nissan"};
        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }
    }
}