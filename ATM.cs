using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte hak = 3;
            int secim;
            double bakiye=0;
            double ekle;
            double cikar;
            byte a;
            AnaSayfa:
                Console.Write("Parolanızı Giriniz : ");
                int sifre = Convert.ToInt32(Console.ReadLine());
                if (sifre == 1234)
                {


                    Console.WriteLine("Banka (1) Kredi(2)");
                    a = Convert.ToByte(Console.ReadLine());
                    if (a == 1)
                    {
                    GirisEkrani:
                        Console.Write(" \n1-Bakiye \n2-Para Yatırma \n3-Para Çekme \n4-Çıkış : ");
                        secim = Convert.ToInt32(Console.ReadLine());
                        do
                        {
                            switch (secim)
                            {
                                case 1:
                                    Console.Write("Bakiyeniz {0} TL", bakiye);
                                    goto GirisEkrani;

                                case 2:
                                    Console.Write("Ne Kadar Para Yatırmak İstiyorsunuz? : ");
                                    ekle = Convert.ToDouble(Console.ReadLine());
                                    bakiye += ekle;
                                    goto GirisEkrani;

                                case 3:
                                    Console.WriteLine("Ne Kadar Para Çekmek İstiyorsunuz? : ");
                                    cikar = Convert.ToDouble(Console.ReadLine());
                                    if (cikar <= bakiye)
                                    {
                                        bakiye -= cikar;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yetersiz Bakiye !!!");
                                    }
                                    goto GirisEkrani;


                            }
                        } while (secim != 4);
                    CikisEkrani:
                        Console.WriteLine("Çıkmak İstiyor Musunuz? (E/H) : ");
                        string cevap = Console.ReadLine();
                        if (cevap == "e" || cevap == "E")
                        {
                            Console.WriteLine("Güle Güle !!! ");
                            Console.Read();
                            Environment.Exit(0);
                        }
                        else if (cevap == "h" || cevap == "H")
                        {
                            goto GirisEkrani;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Giriş !!! \n");
                            goto CikisEkrani;
                        }
                    }
                }
                else
                {
                    hak--;
                    Console.WriteLine("Hatalı !!! {0} Hakkınız Kaldı...", hak);
                    if (hak == 0) 
                    {
                        Console.Write("Kartınız Bloke Olmuştur !!!!");
                    }
                    else
                    {
                        goto AnaSayfa;
                    }

                }
                Console.Read();
    }











               

              
        }

    }

