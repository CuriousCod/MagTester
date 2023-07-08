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

    public bool Feed(Items.Names names, PlayerCharacter playerCharacter)
    {
        var itemGain = FeedTable.GetItemData(names);

        var levelUp = MagStats.AddStats(itemGain.Stats);

        if (levelUp)
        {
            LevelUp(playerCharacter);
        }

        return levelUp;
    }

    private void LevelUp(PlayerCharacter playerCharacter)
    {
        foreach (var evolutionCondition in EvolutionConditions)
        {
            if (!evolutionCondition.AreConditionsFulfilled(this, playerCharacter))
            {
                continue;
            }

            EvolveMag(evolutionCondition.GetEvolutionMagName());
            return;
        }
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
        const PlayerCharacter.Classes requiredClass = PlayerCharacter.Classes.None;
        var stats = new MagStats(5, 0, 0, 0, 0, 0, 5, 0);
        var feedTable = FeedTables.GetFeedTable(0);

        return new Mag(name, stats, feedTable, MagData.EvolutionConditions.GetEvolutionConditionsForMag(name));
    }

    public static List<string> GetClassNames()
    {
        var classNames = Enum.GetNames(typeof(PlayerCharacter.Classes));

        classNames = classNames.Take(classNames.Length - 1).ToArray();

        return classNames.ToList();
    }

    public static List<string> GetFeedItemNames()
    {
        return Enum.GetNames(typeof(Items.Names)).ToList();
    }
}