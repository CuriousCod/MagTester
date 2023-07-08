namespace MagData;

public class EvolutionCondition
{
    public EvolutionCondition(Names evolutionMagName)
    {
        EvolutionMag = evolutionMagName;
    }

    public Names EvolutionMag = Names.None;
    public Classes RequiredClass = Classes.None;
    public Gender RequiredGender = Gender.None;
    public Names RequiredMag = Names.None;
    public List<SectionIDs> RequiredSectionId = new List<SectionIDs>();

    public int CharacterLevel { get; set; }
    public int MinLevel { get; set; }
    public int Tier { get; set; }

    public bool AreStatsRequired = true;

    public bool IsDefImportant = false;
    public bool IsPowImportant = false;
    public bool IsDexImportant = false;
    public bool IsMindImportant = false;

    public bool IsBasicStatComparisonRequired = true;

    public MagStats.Names LargestStat = MagStats.Names.None;
    public MagStats.Names SecondLargestStat = MagStats.Names.None;
    public MagStats.Names ThirdLargestStat = MagStats.Names.None;
    public MagStats.Names SmallestStat = MagStats.Names.None;
    public bool LargestStatAllowedToBeEqual { get; set; }
    public bool SecondLargestStatAllowedToBeEqual { get; set; }

    public bool LargestStatAllowedMustBeEqual { get; set; }

    public List<SpecialStatRequirement> SpecialStatRequirements = new List<SpecialStatRequirement>();

    public bool StatComparisonGroupsRequired { get; set; }
    public bool FirstComparisonLargerThanSecond { get; set; }
    public bool FirstComparisonLargerOrEqualToSecond { get; set; }

    public bool DoNotSumSecondComparisons { get; set; }

    public StatComparison StatComparison01 = new();
    public StatComparison StatComparison02 = new();

    public class StatComparison
    {
        public MagStats.Names Stat1 = MagStats.Names.None;
        public MagStats.Names Stat2 = MagStats.Names.None;
        public MagStats.Names Stat3 = MagStats.Names.None;
    }

    public class SpecialStatRequirement
    {
        public MagStats.Names Stat { get; set; }
        public int Value { get; set; }
    }

    public bool AreConditionsFulfilled(Mag mag, Classes currentClass, SectionIDs currentSectionId)
    {
        if (!CheckRequiredCharacterLevel(100))
        {
            return false;
        }

        if (!CheckRequiredLevel(mag.MagStats.Level))
        {
            return false;
        }

        if (!CheckRequiredMag(mag.Name))
        {
            return false;
        }

        if (!CheckClass(currentClass))
        {
            return false;
        }

        if (!CheckGender(Gender.None))
        {
            return false;
        }

        if (!CheckSectionId(currentSectionId))
        {
            return false;
        }

        if (!CheckStats(mag.MagStats))
        {
            return false;
        }

        return true;
    }

    public Names GetEvolutionMagName()
    {
        return EvolutionMag;
    }

    private bool CheckRequiredCharacterLevel(int characterLevel)
    {
        return characterLevel >= CharacterLevel;
    }

    private bool CheckRequiredLevel(int currentLevel)
    {
        if (Tier == 0)
        {
            if (currentLevel != 10)
            {
                return false;
            }
        }

        if (Tier == 1)
        {
            if (currentLevel != 35)
            {
                return false;
            }
        }

        if (Tier == 2)
        {
            if (currentLevel < 50 || currentLevel % 5 != 0)
            {
                return false;
            }
        }

        if (Tier == 3)
        {
            if (currentLevel < 100 || currentLevel % 10 != 0)
            {
                return false;
            }
        }

        return MinLevel == 0 || MinLevel <= currentLevel;
    }

    private bool CheckRequiredMag(Names currentMag)
    {
        return RequiredMag == Names.None || RequiredMag == currentMag;
    }

    private bool CheckClass(Classes currentClass)
    {
        if (RequiredClass == Classes.None)
        {
            return true;
        }

        return RequiredClass == currentClass;
    }

    private bool CheckGender(Gender currentGender)
    {
        if (RequiredGender == Gender.None)
        {
            return true;
        }

        return RequiredGender == currentGender;
    }

    private bool CheckSectionId(SectionIDs currentSectionId)
    {
        return RequiredSectionId.Count == 0 || RequiredSectionId.Contains(currentSectionId);
    }

    private bool CheckStats(MagStats magStats)
    {
        if (!AreStatsRequired)
        {
            return true;
        }

        if (!CheckStatComparisonGroups(magStats))
        {
            return false;
        }

        if (!CheckSpecialStatRequirements(magStats))
        {
            return false;
        }

        return CheckBasicStatComparison(magStats);
    }

    private bool CheckBasicStatComparison(MagStats magStats)
    {
        if (!IsBasicStatComparisonRequired)
        {
            return true;
        }

        var largestStat = GetStatValue(magStats, LargestStat);
        var secondLargestStat = GetStatValue(magStats, SecondLargestStat);
        var thirdLargestStat = GetStatValue(magStats, ThirdLargestStat);
        var smallestStat = GetStatValue(magStats, SmallestStat);

        var check1 = CompareStat(LargestStat, magStats, largestStat);
        var check2 = CompareStat(SecondLargestStat, magStats, secondLargestStat);
        var check3 = CompareStat(ThirdLargestStat, magStats, thirdLargestStat);
        var check4 = CompareStat(SmallestStat, magStats, smallestStat);

        var check5 = largestStat > secondLargestStat || LargestStatAllowedToBeEqual && largestStat >= secondLargestStat;
        var check6 = secondLargestStat > thirdLargestStat || SecondLargestStatAllowedToBeEqual && secondLargestStat >= thirdLargestStat;

        if (LargestStatAllowedMustBeEqual)
        {
            check5 = largestStat == secondLargestStat;
        }

        if (largestStat == 0 && secondLargestStat == 0)
        {
            check5 = true;
        }

        if (secondLargestStat == 0 && thirdLargestStat == 0)
        {
            check6 = true;
        }

        return check1 && check2 && check3 && check4 && check5 && check6;
    }

    private bool CheckStatComparisonGroups(MagStats magStats)
    {
        if (!StatComparisonGroupsRequired)
        {
            return true;
        }

        var firstComparison01 = GetStatValue(magStats, StatComparison01.Stat1);
        var firstComparison02 = GetStatValue(magStats, StatComparison01.Stat2);
        var firstComparison03 = GetStatValue(magStats, StatComparison01.Stat3);

        var secondComparison01 = GetStatValue(magStats, StatComparison02.Stat1);
        var secondComparison02 = GetStatValue(magStats, StatComparison02.Stat2);
        var secondComparison03 = GetStatValue(magStats, StatComparison02.Stat3);

        var firstComparison = firstComparison01 + firstComparison02 + firstComparison03;

        if (DoNotSumSecondComparisons)
        {
            if (FirstComparisonLargerThanSecond)
            {
                return firstComparison > secondComparison01 && firstComparison > secondComparison02 && firstComparison > secondComparison03;
            }

            if (FirstComparisonLargerOrEqualToSecond)
            {
                return firstComparison >= secondComparison01 && firstComparison >= secondComparison02 && firstComparison >= secondComparison03;
            }

            return firstComparison == secondComparison01 && firstComparison == secondComparison02 && firstComparison == secondComparison03;
        }

        var secondComparison = secondComparison01 + secondComparison02 + secondComparison03;

        if (FirstComparisonLargerThanSecond)
        {
            return firstComparison > secondComparison;
        }

        if (FirstComparisonLargerOrEqualToSecond)
        {
            return firstComparison >= secondComparison;
        }

        return firstComparison == secondComparison;
    }

    private bool CheckSpecialStatRequirements(MagStats magStats)
    {
        var checks = new List<bool>();

        foreach (var specialStatRequirement in SpecialStatRequirements)
        {
            var specialStatValue = GetStatValue(magStats, specialStatRequirement.Stat);
            var check = specialStatValue > specialStatRequirement.Value;
            checks.Add(check);
        }

        return checks.All(x => x);
    }

    private bool CompareStat(MagStats.Names stat, MagStats magStats, int comparisonValue)
    {
        switch (stat)
        {
            case MagStats.Names.Def:
                return !IsDefImportant || CompareValues(magStats.Def, comparisonValue);
            case MagStats.Names.Pow:
                return !IsPowImportant || CompareValues(magStats.Pow, comparisonValue);
            case MagStats.Names.Dex:
                return !IsDexImportant || CompareValues(magStats.Dex, comparisonValue);
            case MagStats.Names.Mind:
                return !IsMindImportant || CompareValues(magStats.Mind, comparisonValue);
            case MagStats.Names.None:
                return true;
            default:
                throw new ArgumentOutOfRangeException(nameof(stat), stat, null);
        }
    }

    private bool CompareValues(int value1, int value2, bool largerThan = false)
    {
        if (largerThan)
        {
            return value1 > value2;
        }

        return value1 >= value2;
    }

    private int GetStatValue(MagStats magStats, MagStats.Names stat)
    {
        switch (stat)
        {
            case MagStats.Names.Def:
                return magStats.Def;
            case MagStats.Names.Pow:
                return magStats.Pow;
            case MagStats.Names.Dex:
                return magStats.Dex;
            case MagStats.Names.Mind:
                return magStats.Mind;
            case MagStats.Names.Synchro:
                return magStats.Synchro;
            case MagStats.Names.Iq:
                return magStats.Iq;
            case MagStats.Names.None:
                return 0;
            default:
                throw new ArgumentOutOfRangeException(nameof(stat), stat, null);
        }
    }
}