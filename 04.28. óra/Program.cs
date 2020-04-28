using System;
using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata;

namespace _04._28._óra
{
    class Program
    {
        static void Main(string[] args)
        {
            string hely1;
            Console.WriteLine("Kérem a file helyét");
            hely1 = Console.ReadLine();
            string adat = hely1;
            StreamReader f = new StreamReader(adat);
            int N = 0;
            while (!f.EndOfStream)
            {
                f.ReadLine();
                N++;
            }
            string[] sor = new string[N];
            StreamReader f1 = new StreamReader(adat);
            int s = 0;
            while (!f1.EndOfStream)
            {
                sor[s] = f1.ReadLine();
                s++;
            }
            string[] vezeteknev = new string[N];
            string[] keresztnev = new string[N];
            int[] pontszámok = new int[N];
            int[] pontszámokfix = new int[N];

            for (int i = 1; i < N; i++)
            {
                string[] darab = sor[i].Split(';');
                vezeteknev[i] = darab[0];
                pontszámok[i] = Convert.ToInt32(darab[1]);
            }
            for (int i = 1; i < N; i++)
            {
                string[] darab = sor[i].Split(';');
                vezeteknev[i] = darab[0];
                pontszámokfix[i] = Convert.ToInt32(darab[1]);
            }
            for (int i = 1; i < 11; i++)
                Console.WriteLine("{0}. elem = {1}", i, pontszámok[i]);
            for (int vege = 10; vege > 1; vege--)
            {
                int max = 1;
                for (int i = 1; i < vege; i++)
                    if (pontszámok[max] < pontszámok[i])
                        max = i;
                int felre;
                felre = pontszámok[vege]; pontszámok[vege] = pontszámok[max]; pontszámok[max] = felre;
            }
            
            
           

            /*   Console.WriteLine("rendezve");
               for (int i = 1; i < 4; i++)
                   Console.WriteLine("{0}. elem = {1}", i, pontszámok[i]);*/
            for (int i = 1; i < N - 1; i++) 
            { for (int j = i + 1; j < N; j++) { 
                    if (pontszámok[j] > pontszámok[i]) 
                    { int c = pontszámok[i]; pontszámok[i] = pontszámok[j]; 
                        pontszámok[j] = c; 
                    } 
                } 
            }
            Console.WriteLine();

            /*     Console.WriteLine("A tömb elemei xsökkenő sorrendben: ");
                 for (int i = 0; i < 3; i++) Console.Write("{0}, ", pontszámok[i]);*/
            int elsohanyat = 0;
            Console.WriteLine("Első hány helyet szeretné megnézni?");
            elsohanyat = Convert.ToInt32(Console.ReadLine());
         
            for (int hely = 1; hely < elsohanyat; hely++)
            {
                for (int i = 1; i < N; i++)
                {
                    if (pontszámokfix[i] == pontszámok[hely])
                    {
                        Console.WriteLine("{1}. Helyezett {0}", vezeteknev[i], hely);
                    }
                }
            }
        }
                
    }
}
