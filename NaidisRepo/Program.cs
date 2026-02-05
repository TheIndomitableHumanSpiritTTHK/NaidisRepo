

using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace NaidisRepo

{
    public class StartPage
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Osa Andmetüübid");

            string tekst = "Tere tulemast C# maailma!";
            Console.WriteLine($"Oli loodud muutuja tekst, mis võrdub: {tekst}");
            Console.WriteLine("Oli loodud muutuja tekst, mis võrdub: {0}", tekst);

            Console.Write("Mis on sinu nimi?: ");
            string nimi = Console.ReadLine();
            Console.Write("Kui vana sa oled?");

            try
            {
                int vanus = int.Parse(Console.ReadLine());
                Console.WriteLine($"Tere {nimi}. Sa oled {vanus} aastat vana");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            try
            {
                Console.Write("Arv 1");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Arv 2");
                float b = float.Parse(Console.ReadLine());
                float vastus = Naidis_funktsioonid.Summa(a, b);
                Console.WriteLine($"Summa {a} ja {b} võrdub {vastus}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            //Random rnd = new Random();
            //int juhuslik_arv = rnd.Next(-5, 25);
            //Console.WriteLine(Naidis_funktsioonid.Kuu_nimetus(juhuslik_arv));
            //juhuslik_arv = rnd.Next(-5, 25);
            //tekst = Naidis_funktsioonid.Kuu_nimetus(juhuslik_arv)

            Teine_class.JukuKino();

        }

        }
    }
}