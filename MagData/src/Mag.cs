namespace MagData;

public class Mag
{
    public Names Name { get; set; }
    public Classes RequiredClass { get; set; }
    public Stats Stats { get; set; }
    public FeedTable FeedTable { get; set; }
    // public Skills LearnedSkill { get; set; }

    public Mag(Mag mag)
    {
        Name = mag.Name;
        RequiredClass = mag.RequiredClass;
        Stats = mag.Stats;
        FeedTable = mag.FeedTable;
    }

    public Mag(Names name, Classes requiredClass, Stats stats, FeedTable feedTable)
    {
        Name = name;
        RequiredClass = requiredClass;
        Stats = stats;
        FeedTable = feedTable;
    }

    public bool Feed(Items item, Classes currentClass)
    {
        var itemGain = FeedTable.GetItemData(item);

        var levelUp = Stats.AddStats(itemGain.Stats);

        if (levelUp)
        {
            LevelUp(currentClass);
        }

        return levelUp;
    }

    private void LevelUp(Classes currentClass)
    {
        if (Stats is {Level: 10, Tier: 0})
        {
            FirstTierEvolution(currentClass);
            return;
        }

        if (Stats is {Level: 35, Tier: 1})
        {
            // SecondTierEvolution(currentClass);
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

    private void SecondTierEvolution(Classes currentClass)
    {
        if (Stats.IsDefHighestStat())
        {
            throw new NotImplementedException();
        }

        Names evolutionName;

        switch (Name)
        {
            case Names.Varuna:
                evolutionName = SecondTierEvolutionParser(Names.Rudra, Names.Marutah, Names.Vayu);
                EvolveMag(evolutionName == Names.None ? Names.Rudra : evolutionName);
                break;
            case Names.Kalki:
                evolutionName = SecondTierEvolutionParser(Names.Surya, Names.Mitra, Names.Tapas);
                EvolveMag(evolutionName == Names.None ? Names.Mitra : evolutionName);
                break;
            case Names.Vritra:
                evolutionName = SecondTierEvolutionParser(Names.Sumba, Names.Ashvinau, Names.Namuci);
                EvolveMag(evolutionName == Names.None ? Names.Namuci : evolutionName);
                break;
            default:
                throw new ArgumentOutOfRangeException(Name.ToString());
        }
    }

    private Names SecondTierEvolutionParser(Names powOption, Names dexOption, Names mindOption)
    {
        if (Stats.IsPowerHighestStat())
        {
            return powOption;
        }

        if (Stats.IsDexHighestStat())
        {
            return dexOption;
        }

        if (Stats.IsMindHighestStat())
        {
            return mindOption;
        }

        return Names.None;
    }

    private void EvolveMag(Names magName)
    {
        var newMag = Mags.GetMag(magName);

        Name = newMag.Name;
        Stats.Tier = newMag.Stats.Tier;
        FeedTable = newMag.FeedTable;
        RequiredClass = newMag.RequiredClass;
    }

    public static Mag GetDefaultMag()
    {
        const Names name = Names.Mag;
        const Classes requiredClass = Classes.None;
        var stats = new Stats(0, 0, 0, 0, 0, 0, 0, 0);
        var feedTable = FeedTables.FeedTable00;

        return new Mag(name, requiredClass, stats, feedTable);
    }

    public static List<string> GetClassNames()
    {
        var classNames = Enum.GetNames(typeof(Classes));

        classNames = classNames.Take(classNames.Length - 1).ToArray();

        return classNames.ToList();
    }

    public static List<string> GetFeedItemNames()
    {
        return Enum.GetNames(typeof(Items)).ToList();
    }
}