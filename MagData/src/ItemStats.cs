namespace MagData;

public class ItemStats
{
    public int Def { get; set; }
    public int Pow { get; set; }
    public int Dex { get; set; }
    public int Mind { get; set; }
    public int Synchro { get; set; }
    public int Iq { get; set; }

    public ItemStats(int def, int pow, int dex, int mind, int synchro, int iq)
    {
        Def = def;
        Pow = pow;
        Dex = dex;
        Mind = mind;
        Synchro = synchro;
        Iq = iq;
    }
}