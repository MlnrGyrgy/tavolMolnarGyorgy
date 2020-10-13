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
            StreamReader file = new StreamReader("tavol.csv");
            while (!file.EndOfStream)
            {
                adatok.Add(new Atleta(file.ReadLine()));
            }
            file.Close();
        }
        static void Main(string[] args)
        {
            Beolvas();
            foreach (var i in adatok)
            {
               Console.WriteLine(i.Rajtszam+ " " + i.VezNev+" "+ i.KerNev+" "+ i.Ugras);
            }
            Console.ReadKey();
        }
    }
}
