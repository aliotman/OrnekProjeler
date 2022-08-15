internal class Program
{
    private static void Main(string[] args)
    {
        string [] renkler=new string[5];
        string[]hayvanlar={"Kedi","Köpek","Kuş","Maymun"};
        int [] dizi;
        dizi = new int[5];

        //Dizilere değer atama ve erişim
        renkler[0]="Mavi";
        
        dizi[3]=10;
        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);


        //Döngülerle dizi kullanımı
Console.Write("Dizinin eleman sayısını girin");
int diziuzunlugu=int.Parse(Console.ReadLine());
int [] sayiDizisi=new int [diziuzunlugu];

for (int i = 0; i < diziuzunlugu; i++)
{
    Console.WriteLine("Dizinin {0}. elemanını girin",i+1);
    sayiDizisi[i]=int.Parse(Console.ReadLine());
}
int toplam=0;
foreach (int sayi in sayiDizisi)
{
    toplam+=sayi;
    Console.WriteLine("Ortalama: "+toplam/diziuzunlugu);
}


    }
}