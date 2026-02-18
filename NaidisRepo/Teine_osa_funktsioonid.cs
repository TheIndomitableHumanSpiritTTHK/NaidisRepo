namespace NaidisRepo
{
    public class Teine_osa_funktsioonid
    {
        public static void JukuKino()
        {
            Console.Write("Sisesta eesnimi: ");
            string eesnimi = Console.ReadLine();
            int vanus = 0;

            if (eesnimi.ToLower() != "juku")
            {
                Console.WriteLine("See ülesanne on Juku jaoks — sinu nimi pole Juku.");
                return;
            }

            Console.WriteLine("Lähme Jukuga kinno!");
            while (true)
            {
                Console.Write("Sisesta Juku vanus: ");
                try
                {
                    vanus = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Palun sisesta korrektne täisarv.");
                }
            }

            if (vanus < 0 || vanus > 100)
            {
                Console.WriteLine("Vigased andmed. Vanus peab olema suurem kui 0 ja väiksem kui 100.");
                return;
            }

            string pilet = "";

            if (vanus < 6)
            {
                pilet = "tasuta";
                Console.WriteLine("Pilet Juku jaoks on tasuta.");
                return;
            }
            else if (vanus <= 14)
            {
                pilet = "lastepilet";
            }
            else if (vanus <= 65)
            {
                pilet = "täispilet";
            }
            else
            {
                pilet = "sooduspilet";
            }
            Console.WriteLine($"Jukule on vaja: {pilet}.");
        }

        public static void Pinginaabrid()
        {
            Console.Write("Sisesta 1. õpilase nimi: ");
            string n1 = Console.ReadLine();
            Console.Write("Sisesta 2. õpilase nimi: ");
            string n2 = Console.ReadLine();

            Console.WriteLine($"{n1} ja {n2} on täna pinginaabrid.");
        }

        public static void TubaPindalaJaRemont()
        {
            double a = 0;
            double b = 0;

            while (true)
            {
                Console.Write("Sisesta sein 1 pikkus (meetrites): ");
                try
                {
                    a = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sisesta palun korrektne arv (nt 3.5).");
                }

            }

            while (true)
            {
                Console.Write("Sisesta sein 2 pikkus (meetrites): ");
                try
                {
                    b = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sisesta palun korrektne arv (nt 3.5).");
                }
            }

            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Pikkused peavad olema positiivsed.");
                return;
            }

            double pindala = a * b;
            Console.WriteLine($"Põranda pindala: {Math.Round(pindala, 2)} m2");

            bool remont = false;
            while (true)
            {
                Console.Write("Kas soovid remonti teha? (jah/ei): ");
                string vastus = Console.ReadLine().ToLower();

                if (vastus == "jah")
                {
                    remont = true;
                    break;
                }
                if (vastus == "ei")
                {
                    remont = false;
                    break;
                }

                Console.WriteLine("Palun vasta jah või ei.");
            }

            if (!remont)
            {
                Console.WriteLine("Remonti ei tehta.");
                return;
            }

            double hind = 0;
            while (true)
            {
                Console.Write("Kui palju maksab 1 m2 (eurot): ");
                try
                {
                    hind = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sisesta palun korrektne arv (nt 12.5).");
                }
            }

            if (hind < 0)
            {
                Console.WriteLine("Hind ei saa olla negatiivne.");
                return;
            }

            double kokku = pindala * hind;
            Console.WriteLine($"Põranda vahetamise hind: {Math.Round(kokku, 2)} eurot");
        }

        public static void Alghind30Soodustus()
        {
            double soodushind = 0;
            while (true)
            {
                Console.Write("Sisesta soodushind (€): ");
                try
                {
                    soodushind = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sisesta palun korrektne arv (nt 12.5).");
                }
            }

            if (soodushind < 0)
            {
                Console.WriteLine("Hind ei saa olla negatiivne.");
                return;
            }

            double alghind = soodushind / 0.7;
            Console.WriteLine($"Alghind oli: {Math.Round(alghind, 2)} €");
        }

        public static void Temperatuur()
        {
            double t = 0;
            while (true)
            {
                Console.Write("Sisesta temperatuur (°C): ");
                try
                {
                    t = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sisesta palun korrektne arv (nt 13).");
                }
            }

            if (t > 17.99)
                Console.WriteLine("Temperatuur on (või üle) 18°C (soovitav toasoojus talvel).");
            else
                Console.WriteLine("Temperatuur on alla 18°C.");
        }
        public static void PikkusKategooria()
        {
            int p = 0;
            while (true)
            {
                Console.Write("Sisesta pikkus (cm): ");
                try
                {
                    p = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sisesta palun korrektne täisarv");
                }
            }

            if (p < 160)
            {
                Console.WriteLine("Sa oled lühike.");
            }
            else if (p <= 185)
            {
                Console.WriteLine("Sa oled keskmine.");
            }
            else
            {
                Console.WriteLine("Sa oled pikk.");
            }
        }
        public static void PikkusJaSugu()
        {
            Console.Write("Sisesta sugu (m/n): ");
            string sugu = Console.ReadLine().ToLower();

            int p = 0;
            while (true)
            {
                Console.Write("Sisesta pikkus (cm): ");
                try
                {
                    p = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sisesta palun korrektne täisarv");
                }
            }

            if (sugu == "m")
            {
                if (p < 170)
                {
                    Console.WriteLine("Meeste jaoks on sa lühike");
                }
                else if (p <= 190)
                {
                    Console.WriteLine("Meeste jaoks on sa keskmine");
                }
                else
                {
                    Console.WriteLine("Meeste jaoks on sa pikk");
                }
            }
            else if (sugu == "n")
            {
                if (p < 160)
                {
                    Console.WriteLine("Naiste jaoks on sa lühike");
                }
                else if (p <= 175)
                {
                    Console.WriteLine("Naiste jaoks on sa keskmine");
                }
                else
                {
                    Console.WriteLine("Naiste jaoks on sa pikk");
                }
            }
            else
            {
                Console.WriteLine("Tundmatu sugu. Kasuta m või n.");
            }
        }

        public static void PoodOstud()
        {
            string[] kysimused = {
                "piima",
                "saia",
                "leiba"
            };
            string[] nimed = {
                "piim",
                "sai",
                "leib"
            };
            double[] hinnad = {
                1.20,
                0.70,
                0.50
            };

            double summa = 0;
            List<string> ostud = new List<string>();

            for (int i = 0; i < kysimused.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Kas soovid osta {kysimused[i]} ({hinnad[i]} eur)? (jah/ei): ");
                    string s = Console.ReadLine().ToLower();

                    if (s == "jah")
                    {
                        summa += hinnad[i];
                        ostud.Add($"{nimed[i]} ({hinnad[i]} eur)");
                        break;
                    }
                    else if (s == "ei")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Palun vasta jah või ei.");
                    }
                }
            }

            if (ostud.Count == 0)
            {
                Console.WriteLine("Midagi ei ostetud.");
            }
            else
            {
                Console.WriteLine("Ostetud: " + string.Join(", ", ostud));
                Console.WriteLine("Kokku: " + Math.Round(summa, 2) + " eur");
            }
        }

    }
}