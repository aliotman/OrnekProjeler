internal class Program
{
    private static void Main(string[] args)
    {
        //Sort
        int[] sayidizisi={23,12,86,72,3,11,17};
        Console.WriteLine("**** Sırasız Dizi ****");
        foreach (int sayi in sayidizisi)
        {
            Console.WriteLine(sayi);
        }
        Console.WriteLine("**** Sıralı Dizi ****");
        Array.Sort(sayidizisi);
        foreach (int sayi2 in sayidizisi)
        {
           Console.WriteLine(sayi2); 
        }
        

        //Clear
        Console.WriteLine("**** Array Clear ****");
        Array.Clear(sayidizisi,2,2); //2. indexten başlayarak 2 adet elemanı temizle(sıfır değerini ata)
        foreach (int sayi3 in sayidizisi)
        {
            Console.WriteLine(sayi3); 
        }

        //Reverse
        Console.WriteLine("**** Array Reverse ****");
        Array.Reverse(sayidizisi);
        foreach (int sayi4 in sayidizisi)
        {
            Console.WriteLine(sayi4);
        }

        //IndexOf(verdiğimiz dizi içerisinde verdiğimiz elemanın eğer dizide varsa bize indexini getirir)
        Console.WriteLine("**** Array IndexOf ****");
        Console.WriteLine(Array.IndexOf(sayidizisi,23));
     
        //Resize
        Console.WriteLine("Array Resize");
        Array.Resize<int>(ref sayidizisi,9);
        sayidizisi[8]=99;
        foreach (int sayi5 in sayidizisi)
        {
            Console.WriteLine(sayi5);
        }
    }
}