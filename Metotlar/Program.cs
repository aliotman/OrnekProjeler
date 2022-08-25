internal class Program
{
    private static void Main(string[] args)
    {
        ///Erişim_belirleyici geridönüş_tipi metot_adı(parametreler_listesi//arguman)
        //{
            //komutlar;
            //return;
        //}
        int a=2;
        int b=3;
        Console.WriteLine(a+b);

        int sonuc=Topla(a,b);
        Console.WriteLine(sonuc);

        Metotlar ornek= new Metotlar();
        ornek.EkranaYazdir(sonuc.ToString());
    }
    static int Topla(int deger1,int deger2)
    {
        return(deger1+deger2);
    }
}
class Metotlar
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public int ArttirveTopla(ref int deger1,ref int deger2)
    {
        deger1+=1;
        deger2+=1;
        return deger1+deger2;
    }
}