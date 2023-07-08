namespace MagData;

public class MagStats
{
    public int Def { get; set; }
    public int Pow { get; set; }
    public int Dex { get; set; }
    public int Mind { get; set; }
    public int Synchro { get; set; }
    public int Iq { get; set; }
    public int Level { get; set; }
    public int Tier { get; set; }
    public int DefCounter { get; set; }
    public int PowCounter { get; set; }
    public int DexCounter { get; set; }
    public int MindCounter { get; set; }

    public enum Names
    {
        None,
        Def,
        Pow,
        Dex,
        Mind,
        Synchro,
        Iq,
    }

    // For serialization
    public MagStats(){}

    public MagStats(int tier)
    {
        Tier = tier;
    }

    public MagStats(int def, int pow, int dex, int mind, int synchro, int iq)
    {
        Def = def;
        Pow = pow;
        Dex = dex;
        Mind = mind;
        Synchro = synchro;
        Iq = iq;
    }

    public MagStats(int def, int pow, int dex, int mind, int synchro, int iq, int level, int tier)
    {
        Def = def;
        Pow = pow;
        Dex = dex;
        Mind = mind;
        Synchro = synchro;
        Iq = iq;
        Level = level;
        Tier = tier;
    }

    public bool AddStats(Items.Stats itemStats)
    {
        DefCounter += itemStats.Def;
        PowCounter += itemStats.Pow;
        DexCounter += itemStats.Dex;
        MindCounter += itemStats.Mind;
        Synchro += itemStats.Synchro;
        Iq += itemStats.Iq;

        var isLevelUp = IsLevelUp();

        if (isLevelUp)
        {
            Level++;
        }

        ResetOverflowStats();

        return isLevelUp;
    }

    private bool IsLevelUp()
    {
        if (Level == 200)
        {
            return false;
        }

        return DefCounter >= 100 || PowCounter >= 100 || DexCounter >= 100 || MindCounter >= 100;
    }

    private void ResetOverflowStats()
    {
        if (DefCounter >= 100)
        {
            Def = Level != 200 ? Def + 1 : Def;
            DefCounter = Level != 200 ? Math.Clamp(DefCounter - 100, 0, 100) : 100;
        }

        if (PowCounter >= 100)
        {
            Pow = Level != 200 ? Pow + 1 : Pow;
            PowCounter = Level != 200 ? Math.Clamp(PowCounter - 100, 0, 100) : 100;
        }

        if (DexCounter >= 100)
        {
            Dex = Level != 200 ? Dex + 1 : Dex;
            DexCounter = Level != 200 ? Math.Clamp(DexCounter - 100, 0, 100) : 100;
        }

        if (MindCounter >= 100)
        {
            Mind = Level != 200 ? Mind + 1 : Mind;
            MindCounter = Level != 200 ? Math.Clamp(MindCounter - 100, 0, 100) : 100;
        }

        DefCounter = Math.Clamp(DefCounter, 0, 100);
        PowCounter = Math.Clamp(PowCounter, 0, 100);
        DexCounter = Math.Clamp(DexCounter, 0, 100);
        MindCounter = Math.Clamp(MindCounter, 0, 100);
        Synchro = Math.Clamp(Synchro, 0, 120);
        Iq = Math.Clamp(Iq, 0, 200);
    }
}