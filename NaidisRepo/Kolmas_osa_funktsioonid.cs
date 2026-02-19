using System;
using System.Collections.Generic;
using System.Reflection;

namespace NaidisRepo
{
    public static class Kolmas_osa_funktsioonid
    {
        public static void ViieArvuAnaluus()
        {
            Console.Clear();
            Console.WriteLine("2. Viie arvu analüüs\n");

            double[] arvud = Tekstist_arvud();

            var t = AnaluusiArve(arvud);

            Console.WriteLine("\nTulemused:");
            Console.WriteLine("Summa: " + t.Item1);
            Console.WriteLine("Keskmine: " + t.Item2);
            Console.WriteLine("Korrutis: " + t.Item3);
        }

        public static double[] Tekstist_arvud()
        {
            Console.Write("Sisesta 5 arvu (tühikuga): ");
            string rida = Console.ReadLine();
            string[] osad = rida.Split(' ');

            double[] arvud = new double[5];

            for (int i = 0; i < 5; i++)
            {
                arvud[i] = double.Parse(osad[i]);
            }

            return arvud;
        }

        public static Tuple<double, double, double> AnaluusiArve(double[] arvud)
        {
            double summa = 0;
            double korrutis = 1;

            for (int i = 0; i < arvud.Length; i++)
            {
                summa = summa + arvud[i];
                korrutis = korrutis * arvud[i];
            }

            double keskmine = summa / arvud.Length;

            return new Tuple<double, double, double>(summa, keskmine, korrutis);
        }

        public static void NimedJaVanused()
        {
            Console.Clear();
            Console.WriteLine("3. Nimed ja vanused\n");

            List<Inimene> inimesed = new List<Inimene>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Sisesta nimi: ");
                string nimi = Console.ReadLine();

                Console.Write("Sisesta vanus: ");
                int vanus = int.Parse(Console.ReadLine());

                Inimene uus = new Inimene();
                uus.Nimi = nimi;
                uus.Vanus = vanus;

                inimesed.Add(uus);
            }

            var t = Statistika(inimesed);

            Console.WriteLine("\nStatistika:");
            Console.WriteLine("Vanuste summa: " + t.Item1);
            Console.WriteLine("Keskmine vanus: " + t.Item2);
            Console.WriteLine("Vanim: " + t.Item3.Nimi + " (" + t.Item3.Vanus + ")");
            Console.WriteLine("Noorim: " + t.Item4.Nimi + " (" + t.Item4.Vanus + ")");
        }

        public static Tuple<int, double, Inimene, Inimene> Statistika(List<Inimene> inimesed)
        {
            int summa = 0;

            Inimene vanim = inimesed[0];
            Inimene noorim = inimesed[0];

            for (int i = 0; i < inimesed.Count; i++)
            {
                summa = summa + inimesed[i].Vanus;

                if (inimesed[i].Vanus > vanim.Vanus)
                {
                    vanim = inimesed[i];
                }

                if (inimesed[i].Vanus < noorim.Vanus)
                {
                    noorim = inimesed[i];
                }
            }

            double keskmine = (double)summa / inimesed.Count;

            return new Tuple<int, double, Inimene, Inimene>(summa, keskmine, vanim, noorim);
        }

        public static void OstaElevantAra()
        {
            Console.Clear();
            Console.WriteLine("4. Osta elevant ära!\n");

            string marksõna = "okei ma ostan";

            string fraas = $"Osta elevant ära! (Sisesta '{marksõna}' ostmiseks)";

            List<string> sisestused = KuniMarksonani(marksõna, fraas);

            Console.WriteLine("\nKõik sisestused:");
            for (int i = 0; i < sisestused.Count; i++)
            {
                Console.WriteLine((i + 1) + ") " + sisestused[i]);
            }
        }

        public static List<string> KuniMarksonani(string marksona, string fraas)
        {
            List<string> lst = new List<string>();

            while (true)
            {
                Console.WriteLine(fraas);
                Console.Write("Sinu vastus: ");
                string vastus = Console.ReadLine();

                lst.Add(vastus);

                if (vastus == marksona)
                {
                    Console.WriteLine("Tubli! Ostad elevandi ära!");
                    break;
                }

                string meie_vastus = $"Seda räägivad kõik, et {vastus}, aga osta elevant ära!";
                lst.Add(meie_vastus);
                Console.WriteLine(meie_vastus+"\n");
            }

            return lst;
        }


        public static void ArvamiseMang()
        {
            Console.Clear();
            Console.WriteLine("5. Arvamise mäng\n");

            Random rnd = new Random();

            while (true)
            {
                ArvaArv(rnd);

                Console.Write("\nKas soovid uuesti mängida? (j/e): ");
                string vastus = Console.ReadLine();

                if (vastus.ToLower() != "j")
                {
                    break;
                }

                Console.Clear();
            }
        }

        public static void ArvaArv(Random rnd)
        {
            int juhuArv = rnd.Next(1, 101);

            for (int katse = 1; katse <= 5; katse++)
            {
                Console.Write("Katse " + katse + "/5. Sisesta arv (1-100): ");
                int arv = int.Parse(Console.ReadLine());

                if (arv == juhuArv)
                {
                    Console.WriteLine($"Tubli! Arv oli {juhuArv}.");
                    return;
                }
                else if (arv > juhuArv)
                {
                    Console.WriteLine("Liiga suur.");
                }
                else
                {
                    Console.WriteLine("Liiga väike.");
                }
            }

            Console.WriteLine("Katseid sai otsa! = ( Õige arv oli " + juhuArv);
        }

    }
}
