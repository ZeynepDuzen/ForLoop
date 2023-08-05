using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i); 
            //}
            //Console.WriteLine();
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (int i = 2; i <= 20; i = i + 2)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int j = 19; j >= 1; j-=1)
            //{
            //    Console.WriteLine(j);
            //}

            //int j;
            //for (j = 19; j >= 1; j-=2)
            //{
            //    Console.WriteLine(j);
            //}
            //Console.WriteLine("J son deger : " + j);

            // *** tam sayi - cift sayi toplamlari
            Console.WriteLine("Lütfen bir baslangic degeri girin : ");
            int baslangıc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen bir bitis degeri girin : ");
            int bitis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiginiz deger araligindaki tek sayilar mi yoksa cift sayilar mi toplansın ? tek: t, cift: c");
            string tekCift = Console.ReadLine();

            int toplam = 0;

            if (baslangıc < bitis)
            {
                for (int i = baslangıc; i < bitis; i++)
                {
                    
                    if (i % 2 == 0 && tekCift == "c")
                    {
                       toplam += i;
                    }
                    if (i % 2 == 1 && tekCift == "t")
                    {
                        toplam += i;
                    }
                    
                }
                Console.WriteLine("toplam : " + toplam);
            }
            


            Console.Read();

        }
       
    }
}
