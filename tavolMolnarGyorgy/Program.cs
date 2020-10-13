using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tavolMolnarGyorgy
{
    class Program
    {
        static List<Atleta> adatok = new List<Atleta>();
        static void Beolvas()
        {
            Console.WriteLine("1.feladat: adatok beolvasása");
            StreamReader file = new StreamReader("tavol.csv");
            while (!file.EndOfStream)
            {
                adatok.Add(new Atleta(file.ReadLine()));
            }
            file.Close();
            Console.WriteLine();
        }
        static void NevekEsUgrasok()
        {
            Console.WriteLine("2.feladat: Nevek és ugrások");
            foreach (var i in adatok)
            {
                Console.WriteLine(i.VezNev+" "+i.KerNev+" -----> "+i.Ugras);
            }
            Console.WriteLine();
        }
        
        static void Egyesuletek()
        {
            Console.WriteLine("3. feladat: Egyesületek");
            string[] egyesulet = new string[] {"Kalocsai Rozmarok","Pecsi Kenguruk","Miskolci Parducok"};
            foreach (var i in adatok)
            {
                if (egyesulet.Contains(i.Egyesulet))
                {
                    Console.WriteLine(i.Egyesulet);
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Beolvas();
            NevekEsUgrasok();
            Egyesuletek();
            //foreach (var i in adatok)
            //{
            //   Console.WriteLine(i.Rajtszam+ " " + i.VezNev+" "+ i.KerNev+" "+ i.Ugras);
            //}
            Console.ReadKey();
        }
    }
}
