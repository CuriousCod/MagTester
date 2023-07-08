namespace MagData;

public class Mag
{
    public Names Name { get; set; }
    public MagStats MagStats { get; set; }
    public FeedTable FeedTable { get; set; }
    public List<EvolutionCondition> EvolutionConditions { get; set; }
    // public Skills LearnedSkill { get; set; }

    public Mag(Mag mag)
    {
        Name = mag.Name;
        MagStats = mag.MagStats;
        FeedTable = mag.FeedTable;
        EvolutionConditions = mag.EvolutionConditions;
    }

    public Mag(Names name, MagStats magStats, FeedTable feedTable, List<EvolutionCondition> evolutionConditions)
    {
        Name = name;
        MagStats = magStats;
        FeedTable = feedTable;
        EvolutionConditions = evolutionConditions;
    }

    public bool Feed(Items.Names names, Classes currentClass)
    {
        var itemGain = FeedTable.GetItemData(names);

        var levelUp = MagStats.AddStats(itemGain.Stats);

        if (levelUp)
        {
            LevelUp(currentClass);
        }

        return levelUp;
    }

    private void LevelUp(Classes currentClass)
    {
        foreach (var evolutionCondition in EvolutionConditions)
        {
            if (!evolutionCondition.AreConditionsFulfilled(this, currentClass, SectionIDs.None))
            {
                continue;
            }

            EvolveMag(evolutionCondition.GetEvolutionMagName());
            return;
        }

        return;

        if (MagStats is {Level: 10, Tier: 0})
        {
            FirstTierEvolution(currentClass);
            return;
        }

        if (MagStats is {Level: 35, Tier: 1})
        {
            SecondTierEvolution();
            return;
        }
    }

    private void FirstTierEvolution(Classes currentClass)
    {
        switch (currentClass)
        {
            case Classes.None:
                throw new Exception("Cannot evolve a mag with no class.");
            case Classes.Hunter:
                EvolveMag(Names.Varuna);
                break;
            case Classes.Ranger:
                EvolveMag(Names.Kalki);
                break;
            case Classes.Force:
                EvolveMag(Names.Vritra);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(currentClass), currentClass, null);
        }
    }

    private void SecondTierEvolution()
    {
        switch (Name)
        {
            case Names.Varuna:
                EvolveMag(SecondTierEvolutionParser(Names.Rudra, Names.Rudra, Names.Marutah, Names.Vayu));
                break;
            case Names.Kalki:
                EvolveMag(SecondTierEvolutionParser(Names.Mitra, Names.Surya, Names.Mitra, Names.Tapas));
                break;
            case Names.Vritra:
                EvolveMag(SecondTierEvolutionParser(Names.Namuci, Names.Sumba, Names.Ashvinau, Names.Namuci));
                break;
            default:
                throw new ArgumentOutOfRangeException(Name.ToString());
        }
    }

    private Names SecondTierEvolutionParser(Names defaultOption, Names powOption, Names dexOption, Names mindOption)
    {
        if (MagStats.IsDefHighestStat())
        {
            var secondHighestStat = MagStats.GetSecondHighestStatName();
            return secondHighestStat switch
            {
                MagStats.Names.None => defaultOption,
                MagStats.Names.Def => throw new Exception("This should never happen."),
                MagStats.Names.Pow => powOption,
                MagStats.Names.Dex => dexOption,
                MagStats.Names.Mind => mindOption,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        if (MagStats.IsPowerHighestStat())
        {
            return powOption;
        }

        if (MagStats.IsDexHighestStat())
        {
            return dexOption;
        }

        if (MagStats.IsMindHighestStat())
        {
            return mindOption;
        }

        return defaultOption;
    }

    private void EvolveMag(Names magName)
    {
        var newMag = Mags.GetMag(magName);

        Name = newMag.Name;
        MagStats.Tier = newMag.MagStats.Tier;
        FeedTable = newMag.FeedTable;
        EvolutionConditions = newMag.EvolutionConditions;
    }

    public static Mag GetDefaultMag()
    {
        const Names name = Names.Mag;
        const Classes requiredClass = Classes.None;
        var stats = new MagStats(5, 0, 0, 0, 0, 0, 5, 0);
        var feedTable = FeedTables.GetFeedTable(0);

        return new Mag(name, stats, feedTable, MagData.EvolutionConditions.GetEvolutionConditionsForMag(name));
    }

    public static List<string> GetClassNames()
    {
        var classNames = Enum.GetNames(typeof(Classes));

        classNames = classNames.Take(classNames.Length - 1).ToArray();

        return classNames.ToList();
    }

    public static List<string> GetFeedItemNames()
    {
        return Enum.GetNames(typeof(Items.Names)).ToList();
    }
}