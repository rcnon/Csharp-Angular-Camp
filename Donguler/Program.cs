﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
             string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
             string kurs3 = "Java";
             string kurs4 = "Python";

             Console.WriteLine(kurs1);
             Console.WriteLine(kurs2);
             Console.WriteLine(kurs3);
             Console.WriteLine(kurs4);
                                     */
            //array (dizi-aşağıdaki gibi) ile yazılmalı : 

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı","Programlamaya Başlangıç için Temel Kurs","Java","Python","C++"};

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("***" + "For döngüsü bitti." + "***");
            
            //foreach, dizileri kolay bir şekilde dolaşır.

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
