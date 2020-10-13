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
                Console.WriteLine(i.VezNev + " " + i.KerNev + " -----> " + i.Ugras);
            }
            Console.WriteLine();
        }

        static void Egyesuletek()
        {
            Console.WriteLine("3. feladat: Egyesületek");
            string[] egyesulet = new string[] { "Kalocsai Rozmarok", "Pecsi Kenguruk", "Miskolci Parducok" };
            foreach (var i in adatok)
            {
                if (egyesulet.Contains(i.Egyesulet))
                {
                    Console.WriteLine(i.Egyesulet);
                }
            }
            Console.WriteLine();
        }
        static void LegnagyobbUgras()
        {
            Console.WriteLine("4.feladat: Legnagyobb ugrás");
            int LegmagasabbUgras = 0;
            foreach (var i in adatok)
            {
                if (i.Ugras > LegmagasabbUgras)
                {
                    LegmagasabbUgras = i.Ugras;
                }
            }
            Console.WriteLine(LegmagasabbUgras + " ");
        }
        static void AtlagAlatt()
        {
            Console.WriteLine("5. feladat: Átlag alatti ugrások száma");
            Console.WriteLine();
        }
        static void FajlbaIras()
        {
            Console.WriteLine("6.feladat: Az adatok fájlba iratása");
            StreamWriter ir = new StreamWriter("versenyzok.txt");
            foreach (var i in adatok)
            {
                ir.WriteLine(i.VezNev + i.KerNev + ";" + i.Rajtszam);
            }
            ir.Close();
        }
        static void Main(string[] args)
        {
            Beolvas();
            NevekEsUgrasok();
            Egyesuletek();
            LegnagyobbUgras();
            AtlagAlatt();
            FajlbaIras();
            //foreach (var i in adatok)
            //{
            //   Console.WriteLine(i.Rajtszam+ " " + i.VezNev+" "+ i.KerNev+" "+ i.Ugras);
            //}
            Console.ReadKey();
        }
    }
}
