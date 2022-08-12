internal class Program
{
    private static void Main(string[] args)
    {
        //Implicit Conversion (bilinçsiz dönüşüm)
        byte a=5;
        sbyte b=30;
        short c=10;
        int d=a+b+c;
        Console.WriteLine("d:"+d);

        long h=d;
        Console.WriteLine("h:"+h);

        float i=h;
        Console.WriteLine("i:"+i);

        string e="C";
        char ch='#';
        object g=e+ch+d;
        Console.WriteLine("g:"+g);

        //Explicit Conversion (Bilinçli Dönüşüm)
        int x=4;
        byte y=(byte)x;
        Console.WriteLine("y:"+y);
        
        int z=100;
        byte t=(byte)z;
        Console.WriteLine("t:"+t);

        float w=10.3f;
        byte v=(byte)w;
        System.Console.WriteLine("v:"+v);

        //ToString Methodu
        int xx=6;
        string yy=xx.ToString();
        Console.WriteLine("yy:"+yy);

        string zz=12.5f.ToString();
        System.Console.WriteLine("zz:"+zz);

        //System.Convert
        string s1="10",s2="20";
        int ilkSayi,ikinciSayi;
        int toplam;
        ilkSayi= Convert.ToInt32(s1);
        ikinciSayi = Convert.ToInt32(s2);
        toplam=ilkSayi+ikinciSayi;
        Console.WriteLine("Toplam: "+toplam);

        //Parse
        ParseMethod();
    }
    public static void ParseMethod()
    {
        string metin1="10";
        string metin2="10.25";
        int rakam1;
        double double1;
        rakam1=int.Parse(metin1);
        double1=double.Parse(metin2);
        Console.WriteLine("Rakam1:"+rakam1);
        Console.WriteLine("Double1:"+double1);
    }
}