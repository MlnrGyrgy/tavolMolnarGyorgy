namespace tavolMolnarGyorgy
{
    class Atleta
    {
        public string Rajtszam { get; private set; }

        public string VezNev { get; private set; }

        public string KerNev { get; private set; }

        public string Egyesulet { get; private set; }

        public int Ugras { get; private set; }
     
        public Atleta(string sor)
        {
            string[] egy = sor.Split(';');
            Rajtszam = egy[0];
            VezNev = egy[1];
            KerNev = egy[1];
            Egyesulet = egy[2];
            Ugras = int.Parse(egy[3]);
        }
       
    }
}