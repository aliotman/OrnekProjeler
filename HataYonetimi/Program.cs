using System;
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
        Console.WriteLine("Bir Sayi Giriniz");
        int sayi=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Girmiş olduğunuz sayı şudur: "+sayi); 
        }
        catch(Exception ex)
        {
        Console.WriteLine("Hata: "+ex.ToString());
        }
        // finally
        // {
        //     Console.WriteLine("İşlem tamamlandı.");
        // }

        try
        {
           // int a=int.Parse(null);
           // int a=int.Parse("test");
           int a=int.Parse("-20000000000");
        }
        catch(ArgumentNullException ex)
        {
            Console.WriteLine("Boş değer girdiniz!");
            Console.WriteLine(ex);
        }
        catch(FormatException ex)
        {
            Console.WriteLine("Veri Tipi Uygun Değil!");
            Console.WriteLine(ex);
        }
        catch(OverflowException ex)
        {
            Console.WriteLine("Çok küçük veya çok büyük bir değer girdiniz!");
            Console.WriteLine(ex);
        }
        finally
        {
            System.Console.WriteLine("İşlem başarıyla tamamlandı.");
        }
       
    }
}