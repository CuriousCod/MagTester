namespace MagData;

// public enum Stats
// {
//     Def,
//     Pow,
//     Dex,
//     Mind
// }

public class Stats
{
    public int Def { get; set; }
    public int Pow { get; set; }
    public int Dex { get; set; }
    public int Mind { get; set; }
    public int Synchro { get; set; }
    public int Iq { get; set; }
    public int Level { get; set; }
    public int Tier { get; set; }

    public enum Names
    {
        Def,
        Pow,
        Dex,
        Mind,
    }

    public Stats(int tier)
    {
        Tier = tier;
    }

    public Stats(int def, int pow, int dex, int mind, int synchro, int iq)
    {
        Def = def;
        Pow = pow;
        Dex = dex;
        Mind = mind;
        Synchro = synchro;
        Iq = iq;
    }

    public Stats(int def, int pow, int dex, int mind, int synchro, int iq, int level, int tier)
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

    public bool AddStats(Stats stats)
    {
        Def += stats.Def;
        Pow += stats.Pow;
        Dex += stats.Dex;
        Mind += stats.Mind;
        Synchro += stats.Synchro;
        Iq += stats.Iq;

        var isLevelUp = IsLevelUp();

        if (isLevelUp)
        {
            Level++;
        }

        ResetOverflowStats();

        return isLevelUp;
    }

    public Names GetHighestBaseStat()
    {
        var highestStat = Names.Def;

        if (Pow > Def)
        {
            highestStat = Names.Pow;
        }

        if (Dex > Pow)
        {
            highestStat = Names.Dex;
        }

        if (Mind > Dex)
        {
            highestStat = Names.Mind;
        }

        return highestStat;
    }

    public bool IsPowerHighestStat()
    {
        return Pow > Def && Pow > Dex && Pow > Mind;
    }

    public bool IsMindHighestStat()
    {
        return Mind > Def && Mind > Dex && Mind > Pow;
    }

    public bool IsDexHighestStat()
    {
        return Dex > Def && Dex > Pow && Dex > Mind;
    }

    public bool IsDefHighestStat()
    {
        return Def > Pow && Def > Dex && Def > Mind;
    }


    private bool IsLevelUp()
    {
        if (Level == 200)
        {
            return false;
        }

        return Def >= 100 || Pow >= 100 || Dex >= 100 || Mind >= 100;
    }

    private void ResetOverflowStats()
    {
        if (Def >= 100)
        {
            Def = Level != 200 ? Math.Clamp(Def - 100, 0, 100) : 100;
        }

        if (Pow >= 100)
        {
            Pow = Level != 200 ? Math.Clamp(Pow - 100, 0, 100) : 100;
        }

        if (Dex >= 100)
        {
            Dex = Level != 200 ? Math.Clamp(Dex - 100, 0, 100) : 100;
        }

        if (Mind >= 100)
        {
            Mind = Level != 200 ? Math.Clamp(Mind - 100, 0, 100) : 100;
        }

        Def = Math.Clamp(Def, 0, 100);
        Pow = Math.Clamp(Pow, 0, 100);
        Dex = Math.Clamp(Dex, 0, 100);
        Mind = Math.Clamp(Mind, 0, 100);
        Synchro = Math.Clamp(Synchro, 0, 120);
        Iq = Math.Clamp(Iq, 0, 200);
    }
}