using System;

namespace toplamaCikarma
{
    class Program
    {
        static int secim,sayiBir,sayiIkı;
        static void Main(string[] args)

        {
            Console.WriteLine("Yapmak istediğiniz fonksiyon kodunu giriniz : \n 1-4 işlem \n 2-Karesini Alma \n 3-Kara Kök");
           secim =Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Yapmak istediğiniz fonksiyon kodunu giriniz : \n 1-Toplama \n 2-Çıkarma \n 3-Bölme \n 4-Çarpma");
                    int secimDortIslem = Convert.ToInt32(Console.ReadLine());
                    switch (secimDortIslem)
                    {
                        case 1:
                            Console.WriteLine("Toplama istediğiniz İlk Sayısı Yazınız");
                            int sayiBir = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Toplama istediğiniz İkinci Sayısı Yazınız");
                            int sayiIki = Convert.ToInt32(Console.ReadLine());
                            if (sayiBir != null && sayiIki != null  )
                            {
                                int sonuc = sayiBir + sayiIki;
                                Console.WriteLine("Sonuç :  "+ sonuc);
                                
                            }
                            break;
                        case 2:
                            Console.WriteLine("Çıkarmak istediğiniz İlk Sayısı Yazınız");
                             sayiBir = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Çıkarmak istediğiniz İkinci Sayısı Yazınız");
                             sayiIki = Convert.ToInt32(Console.ReadLine());
                            if (sayiBir != null && sayiIki != null)
                            {
                                int sonuc = sayiBir - sayiIki;

                                Console.WriteLine("Sonuç :  " + sonuc);

                            }
                            break;
                        case 3:
                            Console.WriteLine("Bölme istediğiniz İlk Sayısı Yazınız");
                            sayiBir = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Bölme istediğiniz İkinci Sayısı Yazınız");
                            sayiIki = Convert.ToInt32(Console.ReadLine());
                            if (sayiBir != null && sayiIki != null)
                            {
                                int sonuc = sayiBir / sayiIki;
                                Console.WriteLine("Sonuç :  " + sonuc);

                            }
                            break;
                        case 4:
                            Console.WriteLine("Çarpma istediğiniz İlk Sayısı Yazınız");
                            sayiBir = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Çarpma istediğiniz İkinci Sayısı Yazınız");
                            sayiIki = Convert.ToInt32(Console.ReadLine());
                            if (sayiBir != null && sayiIki != null)
                            {
                                int sonuc = sayiBir * sayiIki;

                                Console.WriteLine("Sonuç :  " + sonuc);

                            }
                            break;

                        default:
                            Console.WriteLine("Lütfen bir fonksiyon seçiniz");
                            Console.WriteLine("Yapmak istediğiniz fonksiyon kodunu giriniz : \n 1-Toplama \n 2-Çıkarma \n 3-Bölme \n 4-Çarpma");
                             secimDortIslem = Convert.ToInt32(Console.ReadLine());
                            break;
                    }

                    break;
                case 2:
                    Console.WriteLine("Karesini almak istediğiniz Sayıyı Yazınız");
                    int karesi = Convert.ToInt32(Console.ReadLine());
                    if (karesi != null)
                    {
                      double  sonuc = Math.Pow(karesi, 2);
                            Console.WriteLine("Sonuç :  " + sonuc);

                    }
                    break;
                case 3:
                    Console.WriteLine("karekok almak istediğiniz Sayıyı Yazınız");
                    int karekok = Convert.ToInt32(Console.ReadLine());
                    if (karekok != null)
                    {
                       double sonuc = Math.Sqrt(karekok);
                        Console.WriteLine("Sonuç :  " + sonuc);

                    }
                    break;

                default:
                    break;
            }
        }
    }
}
