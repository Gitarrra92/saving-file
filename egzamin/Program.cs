using System;
using System.IO;

namespace egzamin
{
    class Program
    {
        static void Main(string[] args)
        {
            ZapiszdoPlikuTxt(" ", trojkat());
            WyswietlPlikTxt("obraz.txt");
            Console.ReadKey();
        }

        static string trojkat()
        {
            string tmp = "";
            int width = 0;
            Console.WriteLine("Please give the hight");
            while (!Int32.TryParse(Console.ReadLine(), out width));

            tmp = "";
            int height = width;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write("*");
                    tmp += "*";
                }

                Console.WriteLine();
                tmp += Environment.NewLine;
                width--;
            }


            return tmp;
        }

        static void WyswietlPlikTxt(string path)
        {
            try
            {
                Console.WriteLine("Please give the name of the file where it should be safe");
                string fileName = Console.ReadLine();
                Console.WriteLine("I save it to the file {0}.txt", fileName);
                Console.WriteLine(File.ReadAllText(path));
            }
            catch (Exception e)
            {

                Console.WriteLine("There was an error " + e.Message);
            }
        }

        static void ZapiszdoPlikuTxt(string path, string WhatToSave)
        {
            try
            {
                Console.WriteLine("I save it to file ...");
                File.WriteAllText(path, WhatToSave);
            }
            catch (Exception e)
            {

                Console.WriteLine("There was an error " + e.Message);
            }
        }
    }
}



