internal class Program
{
    private static void Main(string[] args)
    {
        int month=Datetime.Now.Month;
        switch (month)
        {
            case 1: Console.Writeline("Ocak Ayındasınız");
            break;
            case 2: Console.Writeline("Şubat Ayındasınız");
            break;
            case 4: Console.Writeline("Nisan Ayındasınız");
            break;
            case 3: Console.Writeline("Mart Ayındasınız");
            break;
            default: Console.Writeline("Yanlış veri girişi");
            break;
        }
        switch (month)
        {
            case 12:
            case 1:
            case 2: Console.Writeline("Kış Ayındasınız");
            break;

            case 3:
            case 4:
            case 5: Console.Writeline("Bahar Ayındasınız");
            break;

            case 6:
            case 7:
            case 8: Console.Writeline("Yaz Ayındasınız");
            break;

            default:
            case 9:
            case 10:
            case 11: Console.Writeline("Sonbahar Ayındasınız");
            break;
        }
    }
}