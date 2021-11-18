using System;

namespace toplamaCikarma
{
    class Program
    {
        static int a=0,fonksiyon;
        static void Main(string[] args)

        {
            Console.WriteLine("Yapmak istediğiniz fonksiyon kodunu giriniz : \n 1-Toplama \n 2-Çıkartma \n 3-Çarpma \n 4-Bölme");
           Convert.ToInt32(Console.ReadLine());
            while (fonksiyon.GetType() != a.GetType())
            {
                Console.WriteLine("Yapmak istediğiniz fonksiyon kodunu giriniz : \n 1-Toplama \n 2-Çıkartma \n 3-Çarpma \n 4-Bölme");
                fonksiyon = Convert.ToInt32(Console.ReadLine());
                if (fonksiyon==1|| fonksiyon == 2 || fonksiyon == 3 || fonksiyon == 4)
                {
                    break;

                }
            }

        }
    }
}
