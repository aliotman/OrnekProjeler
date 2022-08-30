internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear); //Yılın kaçıncı günü olduğunu döndürür
        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortDateString());

        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddHours(3));
        Console.WriteLine(DateTime.Now.AddSeconds(30));
        Console.WriteLine(DateTime.Now.AddMonths(5));
        Console.WriteLine(DateTime.Now.AddYears(10));
        Console.WriteLine(DateTime.Now.AddMilliseconds(50));

        //DateTime Format
        Console.WriteLine(DateTime.Now.ToString("dd"));
        Console.WriteLine(DateTime.Now.ToString("ddd")); //Günün string karşılığı 3 karakterle gelir 'Mon'
        Console.WriteLine(DateTime.Now.ToString("dddd")); //Monday

        Console.WriteLine(DateTime.Now.ToString("MM")); //04
        Console.WriteLine(DateTime.Now.ToString("MMM")); //Ayın string karşılığı 3 karakterle gelir 'Apr'
        Console.WriteLine(DateTime.Now.ToString("MMMM")); //April

        Console.WriteLine(DateTime.Now.ToString("yy")); //22
        Console.WriteLine(DateTime.Now.ToString("yyyy")); //2022

        //Math Kütüphanesi
        Console.WriteLine(Math.Abs(-75)); //Mutlak değer, çıktısı 75
        Console.WriteLine(Math.Sin(10));
        Console.WriteLine(Math.Cos(10));
        Console.WriteLine(Math.Tan(10));

        Console.WriteLine(Math.Ceiling(22.3)); //23 Her zaman yukarıya yuvarlar
        Console.WriteLine(Math.Round(23.3)); //22 
        Console.WriteLine(Math.Round(22.7)); //23 Round her zaman yukarıya yuvarlar
        Console.WriteLine(Math.Floor(22.7)); //22 Her zaman aşağıya yuvarlar
        
        Console.WriteLine(Math.Max(2,6));//6
        Console.WriteLine(Math.Min(2,6));//2

        Console.WriteLine(Math.Pow(3,4)); //3 üzeri 4 işlemini verir = 81
        Console.WriteLine(Math.Sqrt(9)); //9un karekökünü alır = 3

        Console.WriteLine(Math.Log(9));//9 un e tabanındaki logaritmik karşılığı
        Console.WriteLine(Math.Exp(3));//e üzeri 3 verir
        Console.WriteLine(Math.Log10(10));//10 sayısının logaritma10 tabanındaki karşılığı

        

        
    }
}