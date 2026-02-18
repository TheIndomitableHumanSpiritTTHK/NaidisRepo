using System.Text;

namespace NaidisRepo

{
    public class StartPage
    {

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Tere tulemast minu programmisse!");
                Console.WriteLine("Milline ülesanne osa kas te tahaksite jooksma panna?");

                Console.WriteLine("1. Osa Andmetüübid");
                Console.WriteLine("2. Osa Funktsioonid");
                Console.WriteLine("3. Osa");
                Console.WriteLine("4. Osa");
                Console.WriteLine("5. Osa");
                Console.WriteLine("0. Välja");

                Console.Write("Sinu valik: ");
                string valik = Console.ReadLine();

                switch (valik)
                {
                    case "1":
                        //Kood 1. osale
                        break;
                    case "2":
                        Teine_osa();
                        break;
                    case "3":
                        //Kood 3. osale
                        break;
                    case "4":
                        //Kood 4. osale
                        break;
                    case "5":
                        //Kood 5. osale
                        break;
                    case "0":
                        Console.Clear();
                        Console.WriteLine("Äitah kasutamise eest! Tulge tagasi mõni kord veel.");
                        return;

                    default:
                        Console.WriteLine("Tundmatu valik. Vajuta Enter...");
                        Console.ReadLine();
                        continue;
                }
            }
        }


        public static void Teine_osa()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("2. osa Funktsioonid");
                Console.WriteLine("Milline ÜL kas te tahaksite üle vaadata?");
                Console.WriteLine();

                Console.WriteLine("1  - ÜL: Juku kino pilet");
                Console.WriteLine("2  - ÜL: Kaks pinginaabrit");
                Console.WriteLine("3  - ÜL: Ristküliku toa pindala + remondi hind");
                Console.WriteLine("4  - ÜL: Leia alghind (30% soodustuse alghinnaga)");
                Console.WriteLine("5  - ÜL: Temperatuur > 18?");
                Console.WriteLine("6  - ÜL: Pikkuse kategooria - lühike / keskmine / pikk");
                Console.WriteLine("7  - ÜL: Pikkus + sugu - lühike / keskmine / pikk");
                Console.WriteLine("8  - ÜL: Poes ostud");
                Console.WriteLine("0  - Tagasi");
                Console.WriteLine();

                Console.Write("Sinu valik: ");
                string valik = Console.ReadLine();

                switch (valik)
                {
                    case "1":
                        Teine_osa_funktsioonid.JukuKino();
                        break;
                    case "2":
                        Teine_osa_funktsioonid.Pinginaabrid();
                        break;
                    case "3":
                        Teine_osa_funktsioonid.TubaPindalaJaRemont();
                        break;
                    case "4":
                        Teine_osa_funktsioonid.Alghind30Soodustus();
                        break;
                    case "5":
                        Teine_osa_funktsioonid.Temperatuur();
                        break;
                    case "6":
                        Teine_osa_funktsioonid.PikkusKategooria();
                        break;
                    case "7":
                        Teine_osa_funktsioonid.PikkusJaSugu();
                        break;
                    case "8":
                        Teine_osa_funktsioonid.PoodOstud();
                        break;
                    case "0":
                        return;

                    default:
                        Console.WriteLine("Tundmatu valik. Vajuta Enter...");
                        Console.ReadLine();
                        continue;
                }
                Console.WriteLine("\nVajuta Enter, et menüüsse tagasi minna...");
                Console.ReadLine();
            }
        }


        //Console.WriteLine("1. Osa Andmetüübid");

        //string tekst = "Tere tulemast C# maailma!";
        //Console.WriteLine($"Oli loodud muutuja tekst, mis võrdub: {tekst}");
        //Console.WriteLine("Oli loodud muutuja tekst, mis võrdub: {0}", tekst);

        //Console.Write("Mis on sinu nimi?: ");
        //string nimi = Console.ReadLine();
        //Console.Write("Kui vana sa oled?");

        //try
        //{
        //    int vanus = int.Parse(Console.ReadLine());
        //    Console.WriteLine($"Tere {nimi}. Sa oled {vanus} aastat vana");
        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine(e);
        //    throw;
        //}

        //try
        //{
        //    Console.Write("Arv 1");
        //    float a = float.Parse(Console.ReadLine());
        //    Console.Write("Arv 2");
        //    float b = float.Parse(Console.ReadLine());
        //    float vastus = Naidis_funktsioonid.Summa(a, b);
        //    Console.WriteLine($"Summa {a} ja {b} võrdub {vastus}");
        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine(e);
        //}

        ////Random rnd = new Random();
        ////int juhuslik_arv = rnd.Next(-5, 25);
        ////Console.WriteLine(Naidis_funktsioonid.Kuu_nimetus(juhuslik_arv));
        ////juhuslik_arv = rnd.Next(-5, 25);
        ////tekst = Naidis_funktsioonid.Kuu_nimetus(juhuslik_arv)

        //Teine_class.JukuKino();

        // Console.WriteLine("3. Osa. Kordused ja Listid, massivid");
        //            for (int i = 0; i< 10; i++)
        //            {
        //                Console.WriteLine($"Tere, {i + 1}");
        //            }
        //    Console.WriteLine("While: ");
        //            int j = 0;
        //            while (j< 10)
        //            {
        //                Console.WriteLine($"Tere, {j + 1}");
        //                j++;
        //            }
        //Console.WriteLine("Do while: ");
        //do
        //{
        //    Console.WriteLine($"Tere, {j}");
        //    j--;
        //}
        //while (j != 0);

        //List<Isik> inimesed = new List<Isik>();

        //for (int i = 0; i < 3; i++)
        //{
        //    Console.Write("Sisesta nimi: ");
        //    string nimi = Console.ReadLine();

        //    Console.Write("Sisesta vanus: ");
        //    int vanus = int.Parse(Console.ReadLine());

        //    Isik uusIsik = new Isik();
        //    uusIsik.Nimi = nimi;
        //    uusIsik.Vanus = vanus;

        //    inimesed.Add(uusIsik);
        //}

        //Console.WriteLine("\nKõik inimesed tervitavad:\n");

        //foreach (Isik isik in inimesed)
        //{
        //    isik.Tervita();
        //}
    }
}