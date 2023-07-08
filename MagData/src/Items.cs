namespace MagData;

public static class Items
{
    public enum Names
    {
        Monomate,
        Dimate,
        Trimate,
        Monofluid,
        Difluid,
        Trifluid,
        Antidote,
        Antiparalysis,
        SolAtomizer,
        MoonAtomizer,
        StarAtomizer,
    }

    public class Data
    {
        public Names Names { get; set; }
        public Stats Stats { get; set; }

        public Data(Names names, Stats stats)
        {
            Names = names;
            Stats = stats;
        }
    }

    public class Stats
    {
        public int Def { get; set; }
        public int Pow { get; set; }
        public int Dex { get; set; }
        public int Mind { get; set; }
        public int Synchro { get; set; }
        public int Iq { get; set; }

        public Stats(int def, int pow, int dex, int mind, int synchro, int iq)
        {
            Def = def;
            Pow = pow;
            Dex = dex;
            Mind = mind;
            Synchro = synchro;
            Iq = iq;
        }
    }
}

