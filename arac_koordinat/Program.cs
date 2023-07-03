using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arac_koordinat
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Aracın başlangıç konumunu ve yönünü girin (örn: 3 2 N): ");
                string[] aracBaslangic = Console.ReadLine().Split(' ');
                int aracX = Convert.ToInt32(aracBaslangic[0]);
                int aracY = Convert.ToInt32(aracBaslangic[1]);
                string aracYon = aracBaslangic[2];

                Console.Write("Komut dizisini girin: ");
                string komutlar = Console.ReadLine();

                foreach (char komut in komutlar)
                {
                    if (komut == 'L')
                    {
                        // Sol dönüş
                        if (aracYon == "N")
                            aracYon = "W";
                        else if (aracYon == "W")
                            aracYon = "S";
                        else if (aracYon == "S")
                            aracYon = "E";
                        else if (aracYon == "E")
                            aracYon = "N";
                    }
                    else if (komut == 'R')
                    {
                        // Sağ dönüş
                        if (aracYon == "N")
                            aracYon = "E";
                        else if (aracYon == "E")
                            aracYon = "S";
                        else if (aracYon == "S")
                            aracYon = "W";
                        else if (aracYon == "W")
                            aracYon = "N";
                    }
                    else if (komut == 'F')
                    {
                        // İleri hareket
                        if (aracYon == "N")
                        {
                            if (aracY < 10)
                                aracY++;
                            else
                                aracY = 1;
                        }
                        else if (aracYon == "E")
                        {
                            if (aracX < 10)
                                aracX++;
                            else
                                aracX = 1;
                        }
                        else if (aracYon == "S")
                        {
                            if (aracY > 1)
                                aracY--;
                            else
                                aracY = 10;
                        }
                        else if (aracYon == "W")
                        {
                            if (aracX > 1)
                                aracX--;
                            else
                                aracX = 10;
                        }
                    }
                }
                Console.WriteLine("Aracın son konumu ve yönü: " + aracX + " " + aracY + " " + aracYon);
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Devam etmek için bir tuşa basın, çıkmak için 'esc' tuşuna basın.");
                var key = Console.ReadKey(true);
                if (key.Key==ConsoleKey.Escape) 
                break;
        }
            Console.ReadKey();
        }
        }
    }





    

