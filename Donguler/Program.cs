internal class Program
{
    private static void Main(string[] args)
    {
         //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
         Console.WriteLine("Bir sayı giriniz: ");
         int sayac= int.Parse(Console.ReadLine());
      for (int i = 1; i <= sayac; i++)
      {
        if(i%2==1)
        {
            Console.WriteLine(i);
        }
      }
      int tektoplam=0,cifttoplam=0;
      //1 ile 1000 arasındaki tek ve çift sayıların kendi aralarındaki toplamlarını ekrana yazdır
      for (int i = 1; i <= 1000; i++)
      {
        if(i%2==1)
        {
            tektoplam+=i;
        }
        else
            cifttoplam+=i;
        
      }
      Console.WriteLine("Tek Toplam: "+tektoplam);
      Console.WriteLine("Çift Toplam: "+cifttoplam);

        //break ve continue kullanımı
        for (int i = 1; i < 10; i ++)
        {
            if (i==4)
            {
                break;
                Console.WriteLine(i);
            }
        } //çıktısı 1,2,3

        for (int i = 1; i < 10; i ++)
        {
            if (i==4)
            {
                continue;
                Console.WriteLine(i);
            }
        } //çıktısı 1,2,3,5,6,7,8,9
     
    }
}