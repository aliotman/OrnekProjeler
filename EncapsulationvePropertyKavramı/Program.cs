internal class Program
{
    private static void Main(string[] args)
    {
        Ogrenci ogr = new Ogrenci();
        ogr.Isim="Ayşe";
        ogr.Soyisim="Yılmaz";
        ogr.OgrenciNo=293;
        ogr.Sinif=3;
        ogr.OgrenciBilgileriniGetir();

        ogr.SinifAtlat();
        ogr.OgrenciBilgileriniGetir();

        Ogrenci ogr2=new Ogrenci("Deniz","Arda",256,1);
        ogr2.SinifDusur();
        ogr2.SinifDusur();
        ogr2.OgrenciBilgileriniGetir();

    }
}
class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public string Isim /////////////// Bu şekilde de yazılabilir /////////////
    {
        get {return isim;}
        set {isim = value;}
    }                  ///////////////////////////////////////////////////////
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif 
    {
        get {return sinif;} 
        set {
                if(sinif<1)
                {
                    System.Console.WriteLine("Sınıf en az 1 olabilir !");
                    sinif=1;
                }
                else
                    sinif = value;
            } 
    }
    public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
    {
        Isim = ısim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }
    public Ogrenci(){}
    public void OgrenciBilgileriniGetir()
    {
       Console.WriteLine("************** Ögrenci Bilgileri **********");
       Console.WriteLine("Ögrenci Adı:      {0}",this.Isim);
       Console.WriteLine("Ögrenci Soyadı:   {0}",this.Soyisim);
       Console.WriteLine("Ögrenci No:       {0}",this.OgrenciNo);
       Console.WriteLine("Ögrenci Sınıf:    {0}",this.Sinif);
    }
    public void SinifAtlat()
    {
        this.Sinif=this.Sinif+1;
    }
    public void SinifDusur()
    {
        this.Sinif=this.Sinif-1;
    }
}    