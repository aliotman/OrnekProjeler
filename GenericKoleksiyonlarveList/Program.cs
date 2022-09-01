internal class Program
{
    private static void Main(string[] args)
    {
        //List<T> class
        //System.Collections.Generic
        //T ---> object türündedir.
        List<int>sayiListesi=new List<int>();
        sayiListesi.Add(23);
        sayiListesi.Add(10);
        sayiListesi.Add(4);
        sayiListesi.Add(5);
        sayiListesi.Add(92);
        sayiListesi.Add(34);

        List<string>renkListesi=new List<string>();
        renkListesi.Add("Kırmızı");
        renkListesi.Add("Mavi");
        renkListesi.Add("Turuncu");
        renkListesi.Add("Sarı");
        renkListesi.Add("Yeşil");

        //Count
        Console.WriteLine(sayiListesi.Count);
        Console.WriteLine(renkListesi.Count);

        foreach (var sayi in sayiListesi)
        {
            Console.WriteLine(sayi);
        }
        foreach (var renk in renkListesi)
        {
            Console.WriteLine(renk);
        }

        sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
        renkListesi.ForEach(renk=>Console.WriteLine(renk));

        //Liste içerisinde arama
        if(sayiListesi.Contains(10))
        {
            Console.WriteLine("10 liste içerisinde bulundu!");
        }
        //eleman ile index'e erişme
        Console.WriteLine(renkListesi.BinarySearch("Sarı"));
        
        //Diziyi List'e çevirme
        string [] hayvanlar={"Kedi","Köpek","Kuş"};
        List<string>hayvanListesi=new List<string>(hayvanlar);

        //Listeyi nasıl temizleriz
        hayvanListesi.Clear();

        //List içerisinde nesne tutmak
        List<Kullanicilar> kullanicilistesi=new List<Kullanicilar>();
        Kullanicilar kullanici1=new Kullanicilar();
        kullanici1.Isim="Ayşe";
        kullanici1.Soyisim="Yılaz";
        kullanici1.Yas=36;

        Kullanicilar kullanici2=new Kullanicilar();
        kullanici2.Isim="Özcan";
        kullanici2.Soyisim="Çalışkan";
        kullanici2.Yas=36;

        kullanicilistesi.Add(kullanici1);
        kullanicilistesi.Add(kullanici2);

        List<Kullanicilar> yeniListe= new List<Kullanicilar>();
        yeniListe.Add(new Kullanicilar()
        {
        Isim="Deniz",
        Soyisim="Arda",
        Yas=24
        });
        foreach (Kullanicilar kullanici in kullanicilistesi)
        {
            Console.WriteLine("Kullanıcı Adı: "+kullanici.Isim);
            Console.WriteLine("Kullanıcı Soayadı: "+kullanici.Soyisim);
            Console.WriteLine("Kullanıcı Adı: "+kullanici.Yas);
        }
        yeniListe.Clear(); //temizledik
    }
    public class Kullanicilar
    {
    private string isim;
    private string soyisim;
    private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}