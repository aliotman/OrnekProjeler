internal class Program
{
    private static void Main(string[] args)
    {
       //Söz dizimi
       //class SinifAdi
       // {
       //   [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
       //   [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametreler])
       //   {
       //       Metot Komutları
       //   }
       // }

       //Erişim Belirleyiciler
       // *Public
       // *Private
       // *Internal
       // *Protected
       Calisan calisan1=new();
       calisan1.Ad="Ayşe";
       calisan1.Soyad="Kara";
       calisan1.No=23425634;
       calisan1.Departman="İnsan Kaynakları";
       calisan1.CalisanBilgileri();

       Calisan calisan2=new();
       calisan2.Ad="Deniz";
       calisan2.Soyad="Arda";
       calisan2.No=25646789;
       calisan2.Departman="Satın Alma";
       calisan2.CalisanBilgileri();
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}",Ad);
            Console.WriteLine("Çalışan Soyadı: {0}",Soyad);
            Console.WriteLine("Çalışan Numarası: {0}",No);
            Console.WriteLine("Çalışan Departmanı0}",Departman);

        }
    }
}