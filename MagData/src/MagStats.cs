namespace MagData;

// public enum Stats
// {
//     Def,
//     Pow,
//     Dex,
//     Mind
// }

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

    public Names GetSecondHighestStatName()
    {
        var highestStat = GetHighestBaseStat();

        if (highestStat == Names.Def)
        {
            if (Pow > Dex && Pow > Mind)
            {
                return Names.Pow;
            }

            if (Dex > Pow && Dex > Mind)
            {
                return Names.Dex;
            }

            if (Mind > Pow && Mind > Dex)
            {
                return Names.Mind;
            }
        }

        if (highestStat == Names.Pow)
        {
            if (Def > Dex && Def > Mind)
            {
                return Names.Def;
            }

            if (Dex > Def && Dex > Mind)
            {
                return Names.Dex;
            }

            if (Mind > Def && Mind > Dex)
            {
                return Names.Mind;
            }
        }

        if (highestStat == Names.Dex)
        {
            if (Def > Pow && Def > Mind)
            {
                return Names.Def;
            }

            if (Pow > Def && Pow > Mind)
            {
                return Names.Pow;
            }

            if (Mind > Def && Mind > Pow)
            {
                return Names.Mind;
            }
        }

        if (highestStat == Names.Mind)
        {
            if (Def > Pow && Def > Dex)
            {
                return Names.Def;
            }

            if (Pow > Def && Pow > Dex)
            {
                return Names.Pow;
            }

            if (Dex > Def && Dex > Pow)
            {
                return Names.Dex;
            }
        }

        return Names.None;
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