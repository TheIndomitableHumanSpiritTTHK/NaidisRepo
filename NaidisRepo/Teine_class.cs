using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaidisRepo
{
    public class Teine_class
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
    }
}