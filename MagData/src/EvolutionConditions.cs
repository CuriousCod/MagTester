namespace MagData;

public class EvolutionConditions
{
    public static List<EvolutionCondition> GetEvolutionConditionsForMag(Names magName)
    {
        switch (magName)
        {
            case Names.None:
                break;
            case Names.Mag:
                return GetTier1EvolutionConditions();
            case Names.Varuna:
                return GetTier2EvolutionConditions();
            case Names.Kalki:
                return GetTier2EvolutionConditions();
            case Names.Vritra:
                return GetTier2EvolutionConditions();
            case Names.Rudra:
                return GetTier3EvolutionConditions();
            case Names.Marutah:
                return GetTier3EvolutionConditions();
            case Names.Vayu:
                return GetTier3EvolutionConditions();
            case Names.Surya:
                return GetTier3EvolutionConditions();
            case Names.Mitra:
                return GetTier3EvolutionConditions();
            case Names.Tapas:
                return GetTier3EvolutionConditions();
            case Names.Sumba:
                return GetTier3EvolutionConditions();
            case Names.Ashvinau:
                return GetTier3EvolutionConditions();
            case Names.Namuci:
                return GetTier3EvolutionConditions();
            case Names.Andhaka:
                return GetTier4EvolutionConditions();
            case Names.Apsaras:
                return GetTier4EvolutionConditions();
            case Names.Bana:
                return GetTier4EvolutionConditions();
            case Names.Bhirava:
                return GetTier4EvolutionConditions();
            case Names.Durga:
                return GetTier4EvolutionConditions();
            case Names.Garuda:
                return GetTier4EvolutionConditions();
            case Names.Ila:
                return GetTier4EvolutionConditions();
            case Names.Kabanda:
                return GetTier4EvolutionConditions();
            case Names.Kaitabha:
                return GetTier4EvolutionConditions();
            case Names.Kama:
                return GetTier4EvolutionConditions();
            case Names.Kumara:
                return GetTier4EvolutionConditions();
            case Names.Madhu:
                return GetTier4EvolutionConditions();
            case Names.Marica:
                return GetTier4EvolutionConditions();
            case Names.Naga:
                return GetTier4EvolutionConditions();
            case Names.Nandin:
                return GetTier4EvolutionConditions();
            case Names.Naraka:
                return GetTier4EvolutionConditions();
            case Names.Ravana:
                return GetTier4EvolutionConditions();
            case Names.Ribhava:
                return GetTier4EvolutionConditions();
            case Names.Sita:
                return GetTier4EvolutionConditions();
            case Names.Soma:
                return GetTier4EvolutionConditions();
            case Names.Ushasu:
                return GetTier4EvolutionConditions();
            case Names.Varaha:
                return GetTier4EvolutionConditions();
            case Names.Yaksa:
                return GetTier4EvolutionConditions();
            case Names.Bhima:
                break;
            case Names.Deva:
                break;
            case Names.Diwari:
                break;
            case Names.Nidra:
                break;
            case Names.Pushan:
                break;
            case Names.Rati:
                break;
            case Names.Rukmin:
                break;
            case Names.Sato:
                break;
            case Names.Savitri:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(magName), magName, null);
        }

        return new List<EvolutionCondition>();
    }

    private static List<EvolutionCondition> GetTier1EvolutionConditions()
    {
        var varuna = new EvolutionCondition(Names.Varuna)
        {
            RequiredClass = Classes.Hunter,
            RequiredMag = Names.Mag,
            CharacterLevel = 0,
            MinLevel = 0,
            Tier = 0,
            AreStatsRequired = false,
            IsBasicStatComparisonRequired = false,
            StatComparisonGroupsRequired = false,
        };

        var kalki = new EvolutionCondition(Names.Kalki)
        {
            RequiredClass = Classes.Ranger,
            RequiredMag = Names.Mag,
            CharacterLevel = 0,
            MinLevel = 0,
            Tier = 0,
            AreStatsRequired = false,
            IsBasicStatComparisonRequired = false,
            StatComparisonGroupsRequired = false,
        };

        var vritra = new EvolutionCondition(Names.Vritra)
        {
            RequiredClass = Classes.Force,
            RequiredMag = Names.Mag,
            CharacterLevel = 0,
            MinLevel = 0,
            Tier = 0,
            AreStatsRequired = false,
            IsBasicStatComparisonRequired = false,
            StatComparisonGroupsRequired = false,
        };

        return new List<EvolutionCondition>
        {
            varuna,
            kalki,
            vritra,
        };
    }

    private static List<EvolutionCondition> GetTier2EvolutionConditions()
    {
        var rudra = new EvolutionCondition(Names.Rudra)
        {
            RequiredMag = Names.Varuna,
            Tier = 1,
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Pow,
            LargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            StatComparisonGroupsRequired = false,
        };

        var marutah = new EvolutionCondition(Names.Marutah)
        {
            RequiredMag = Names.Varuna,
            Tier = 1,
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Dex,
            LargestStatAllowedToBeEqual = false,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            StatComparisonGroupsRequired = false,
        };

        var vayu = new EvolutionCondition(Names.Vayu)
        {
            RequiredMag = Names.Varuna,
            Tier = 1,
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Mind,
            LargestStatAllowedToBeEqual = false,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            StatComparisonGroupsRequired = false,
        };

        var surya = new EvolutionCondition(Names.Surya)
        {
            RequiredMag = Names.Kalki,
            Tier = 1,
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Pow,
            LargestStatAllowedToBeEqual = false,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            StatComparisonGroupsRequired = false,
        };

        var mitra = new EvolutionCondition(Names.Mitra)
        {
            RequiredMag = Names.Kalki,
            Tier = 1,
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Dex,
            LargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            StatComparisonGroupsRequired = false,
        };

        var tapas = new EvolutionCondition(Names.Tapas)
        {
            RequiredMag = Names.Kalki,
            Tier = 1,
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Mind,
            LargestStatAllowedToBeEqual = false,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            StatComparisonGroupsRequired = false,
        };

        var sumba = new EvolutionCondition(Names.Sumba)
        {
            RequiredMag = Names.Vritra,
            Tier = 1,
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Pow,
            LargestStatAllowedToBeEqual = false,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            StatComparisonGroupsRequired = false,
        };

        var ashvinau = new EvolutionCondition(Names.Ashvinau)
        {
            RequiredMag = Names.Vritra,
            Tier = 1,
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Dex,
            LargestStatAllowedToBeEqual = false,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            StatComparisonGroupsRequired = false,
        };

        var namuci = new EvolutionCondition(Names.Namuci)
        {
            RequiredMag = Names.Vritra,
            Tier = 1,
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Mind,
            LargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            StatComparisonGroupsRequired = false,
        };

        return new List<EvolutionCondition>
        {
            rudra,
            marutah,
            vayu,
            surya,
            mitra,
            tapas,
            sumba,
            ashvinau,
            namuci,
        };
    }

    private static List<EvolutionCondition> GetTier3EvolutionConditions()
    {
        const int tier2 = 2;

        var andhaka = new EvolutionCondition(Names.Andhaka)
        {
            Tier = tier2,
            RequiredClass = Classes.Force,
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = false,
            SpecialStatRequirements = new List<EvolutionCondition.SpecialStatRequirement>(){new()
                {
                    Stat = MagStats.Names.Def,
                    Value = 44
                }
            },
            StatComparisonGroupsRequired = true,
            FirstComparisonLargerThanSecond = true,
            DoNotSumSecondComparisons = true,
            StatComparison01 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Pow
            },
            StatComparison02 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Pow,
                Stat2 = MagStats.Names.Def,
                Stat3 = MagStats.Names.Mind
            }
        };

        var apsaras01 = new EvolutionCondition(Names.Apsaras)
        {
            Tier = tier2,
            RequiredClass = Classes.Hunter,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Bluefull, SectionIDs.Pinkal, SectionIDs.Oran, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Pow,
            SecondLargestStat = MagStats.Names.Mind,
            ThirdLargestStat = MagStats.Names.Dex,
            SmallestStat = MagStats.Names.Dex,
            LargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false,
        };

        var apsaras02 = new EvolutionCondition(Names.Apsaras)
        {
            Tier = tier2,
            RequiredClass = Classes.Ranger,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Skyly, SectionIDs.Purplenum, SectionIDs.Redria, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Mind,
            SecondLargestStat = MagStats.Names.Dex,
            ThirdLargestStat = MagStats.Names.Pow,
            SmallestStat = MagStats.Names.Pow,
            LargestStatAllowedToBeEqual = false,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false,
        };

        var bana01 = new EvolutionCondition(Names.Bana)
        {
            Tier = tier2,
            RequiredClass = Classes.Hunter,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Bluefull, SectionIDs.Pinkal, SectionIDs.Oran, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Mind,
            SecondLargestStat = MagStats.Names.Pow,
            ThirdLargestStat = MagStats.Names.Dex,
            SmallestStat = MagStats.Names.Dex,
            SecondLargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false,
        };

        var bana02 = new EvolutionCondition(Names.Bana)
        {
            Tier = tier2,
            RequiredClass = Classes.Force,
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = false,
            SpecialStatRequirements = new List<EvolutionCondition.SpecialStatRequirement>(){new()
                {
                    Stat = MagStats.Names.Def,
                    Value = 44
                }
            },
            StatComparisonGroupsRequired = true,
            FirstComparisonLargerOrEqualToSecond = true,
            StatComparison01 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Dex
            },
            StatComparison02 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Pow
            }
        };

        var bana03 = new EvolutionCondition(Names.Bana)
        {
            Tier = tier2,
            RequiredClass = Classes.Force,
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = false,
            SpecialStatRequirements = new List<EvolutionCondition.SpecialStatRequirement>(){new()
                {
                    Stat = MagStats.Names.Def,
                    Value = 44
                }
            },
            StatComparisonGroupsRequired = true,
            FirstComparisonLargerOrEqualToSecond = true,
            StatComparison01 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Mind
            },
            StatComparison02 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Pow
            }
        };

        var bhirava01 = new EvolutionCondition(Names.Bhirava)
        {
            Tier = tier2,
            RequiredClass = Classes.Hunter,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Skyly, SectionIDs.Purplenum, SectionIDs.Redria, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Pow,
            SecondLargestStat = MagStats.Names.Mind,
            ThirdLargestStat = MagStats.Names.Dex,
            SmallestStat = MagStats.Names.Dex,
            LargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false,
        };

        var bhirava02 = new EvolutionCondition(Names.Bhirava)
        {
            Tier = tier2,
            RequiredClass = Classes.Ranger,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Skyly, SectionIDs.Purplenum, SectionIDs.Redria, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Pow,
            SecondLargestStat = MagStats.Names.Mind,
            ThirdLargestStat = MagStats.Names.Dex,
            SmallestStat = MagStats.Names.Dex,
            LargestStatAllowedToBeEqual = false,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false,
        };

        var bhirava03 = new EvolutionCondition(Names.Bhirava)
        {
            Tier = tier2,
            RequiredClass = Classes.Ranger,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Skyly, SectionIDs.Purplenum, SectionIDs.Redria, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Dex,
            SecondLargestStat = MagStats.Names.Pow,
            ThirdLargestStat = MagStats.Names.Mind,
            SmallestStat = MagStats.Names.Mind,
            LargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false,
        };

        var bhirava04 = new EvolutionCondition(Names.Bhirava)
        {
            Tier = tier2,
            RequiredClass = Classes.Force,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Bluefull, SectionIDs.Pinkal, SectionIDs.Oran, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Dex,
            SecondLargestStat = MagStats.Names.Mind,
            ThirdLargestStat = MagStats.Names.Pow,
            SmallestStat = MagStats.Names.Pow,
            LargestStatAllowedToBeEqual = false,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var durga = new EvolutionCondition(Names.Durga)
        {
            Tier = tier2,
            RequiredClass = Classes.Ranger,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Bluefull, SectionIDs.Pinkal, SectionIDs.Oran, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Mind,
            SecondLargestStat = MagStats.Names.Dex,
            ThirdLargestStat = MagStats.Names.Pow,
            SmallestStat = MagStats.Names.Pow,
            LargestStatAllowedToBeEqual = false,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var garuda01 = new EvolutionCondition(Names.Garuda)
        {
            Tier = tier2,
            RequiredClass = Classes.Hunter,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Bluefull, SectionIDs.Pinkal, SectionIDs.Oran, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Dex,
            SecondLargestStat = MagStats.Names.Pow,
            ThirdLargestStat = MagStats.Names.Mind,
            SmallestStat = MagStats.Names.Mind,
            LargestStatAllowedToBeEqual = false,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var garuda02 = new EvolutionCondition(Names.Garuda)
        {
            Tier = tier2,
            RequiredClass = Classes.Force,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Bluefull, SectionIDs.Pinkal, SectionIDs.Oran, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Dex,
            SecondLargestStat = MagStats.Names.Pow,
            ThirdLargestStat = MagStats.Names.Mind,
            SmallestStat = MagStats.Names.Mind,
            LargestStatAllowedToBeEqual = false,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var ila01 = new EvolutionCondition(Names.Ila)
        {
            Tier = tier2,
            RequiredClass = Classes.Hunter,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Skyly, SectionIDs.Purplenum, SectionIDs.Redria, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Dex,
            SecondLargestStat = MagStats.Names.Pow,
            ThirdLargestStat = MagStats.Names.Mind,
            SmallestStat = MagStats.Names.Mind,
            LargestStatAllowedToBeEqual = false,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var ila02 = new EvolutionCondition(Names.Ila)
        {
            Tier = tier2,
            RequiredClass = Classes.Force,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Bluefull, SectionIDs.Pinkal, SectionIDs.Oran, SectionIDs.Skyly},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Mind,
            SecondLargestStat = MagStats.Names.Dex,
            ThirdLargestStat = MagStats.Names.Pow,
            SmallestStat = MagStats.Names.Pow,
            LargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var kabanda01 = new EvolutionCondition(Names.Kabanda)
        {
            Tier = tier2,
            RequiredClass = Classes.Hunter,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Skyly, SectionIDs.Purplenum, SectionIDs.Redria, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Mind,
            SecondLargestStat = MagStats.Names.Pow,
            ThirdLargestStat = MagStats.Names.Dex,
            SmallestStat = MagStats.Names.Dex,
            LargestStatAllowedToBeEqual = false,
            SecondLargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var kabanda02 = new EvolutionCondition(Names.Kabanda)
        {
            Tier = tier2,
            RequiredClass = Classes.Hunter,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Bluefull, SectionIDs.Pinkal, SectionIDs.Oran, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Mind,
            SecondLargestStat = MagStats.Names.Pow,
            ThirdLargestStat = MagStats.Names.Dex,
            SmallestStat = MagStats.Names.Dex,
            LargestStatAllowedToBeEqual = false,
            SecondLargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var kabanda03 = new EvolutionCondition(Names.Kabanda)
        {
            Tier = tier2,
            RequiredClass = Classes.Force,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Skyly, SectionIDs.Purplenum, SectionIDs.Redria, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Mind,
            SecondLargestStat = MagStats.Names.Dex,
            ThirdLargestStat = MagStats.Names.Pow,
            SmallestStat = MagStats.Names.Pow,
            LargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var kaitabha01 = new EvolutionCondition(Names.Kaitabha)
        {
            Tier = tier2,
            RequiredClass = Classes.Ranger,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Bluefull, SectionIDs.Pinkal, SectionIDs.Oran, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Pow,
            SecondLargestStat = MagStats.Names.Mind,
            ThirdLargestStat = MagStats.Names.Dex,
            SmallestStat = MagStats.Names.Dex,
            LargestStatAllowedToBeEqual = false,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var kaitabha02 = new EvolutionCondition(Names.Kaitabha)
        {
            Tier = tier2,
            RequiredClass = Classes.Ranger,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Bluefull, SectionIDs.Pinkal, SectionIDs.Oran, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Dex,
            SecondLargestStat = MagStats.Names.Pow,
            ThirdLargestStat = MagStats.Names.Mind,
            SmallestStat = MagStats.Names.Mind,
            LargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var kama01 = new EvolutionCondition(Names.Kama)
        {
            Tier = tier2,
            RequiredClass = Classes.Hunter,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Bluefull, SectionIDs.Pinkal, SectionIDs.Oran, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Pow,
            SecondLargestStat = MagStats.Names.Dex,
            ThirdLargestStat = MagStats.Names.Mind,
            SmallestStat = MagStats.Names.Mind,
            LargestStatAllowedToBeEqual = true,
            SecondLargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var kama02 = new EvolutionCondition(Names.Kama)
        {
            Tier = tier2,
            RequiredClass = Classes.Hunter,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Bluefull, SectionIDs.Pinkal, SectionIDs.Oran, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Dex,
            SecondLargestStat = MagStats.Names.Mind,
            ThirdLargestStat = MagStats.Names.Pow,
            SmallestStat = MagStats.Names.Pow,
            LargestStatAllowedMustBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var kama03 = new EvolutionCondition(Names.Kama)
        {
            Tier = tier2,
            RequiredClass = Classes.Ranger,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Skyly, SectionIDs.Purplenum, SectionIDs.Redria, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Pow,
            SecondLargestStat = MagStats.Names.Dex,
            ThirdLargestStat = MagStats.Names.Mind,
            SmallestStat = MagStats.Names.Mind,
            SecondLargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var kama04 = new EvolutionCondition(Names.Kama)
        {
            Tier = tier2,
            RequiredClass = Classes.Ranger,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Skyly, SectionIDs.Purplenum, SectionIDs.Redria, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Dex,
            SecondLargestStat = MagStats.Names.Mind,
            ThirdLargestStat = MagStats.Names.Pow,
            SmallestStat = MagStats.Names.Pow,
            LargestStatAllowedToBeEqual = true,
            SecondLargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var kama05 = new EvolutionCondition(Names.Kama)
        {
            Tier = tier2,
            RequiredClass = Classes.Hunter,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Skyly, SectionIDs.Purplenum, SectionIDs.Redria, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Pow,
            SecondLargestStat = MagStats.Names.Mind,
            ThirdLargestStat = MagStats.Names.Dex,
            SmallestStat = MagStats.Names.Dex,
            LargestStatAllowedMustBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var kumara01 = new EvolutionCondition(Names.Kumara)
        {
            Tier = tier2,
            RequiredClass = Classes.Force,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Bluefull, SectionIDs.Pinkal, SectionIDs.Oran, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Mind,
            SecondLargestStat = MagStats.Names.Pow,
            ThirdLargestStat = MagStats.Names.Dex,
            SmallestStat = MagStats.Names.Dex,
            LargestStatAllowedToBeEqual = true,
            SecondLargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var kumara02 = new EvolutionCondition(Names.Kumara)
        {
            Tier = tier2,
            RequiredClass = Classes.Force,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Bluefull, SectionIDs.Pinkal, SectionIDs.Oran, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Pow,
            SecondLargestStat = MagStats.Names.Dex,
            ThirdLargestStat = MagStats.Names.Mind,
            SmallestStat = MagStats.Names.Mind,
            LargestStatAllowedMustBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var madhu = new EvolutionCondition(Names.Madhu)
        {
            Tier = tier2,
            RequiredClass = Classes.Ranger,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Bluefull, SectionIDs.Pinkal, SectionIDs.Oran, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Pow,
            SecondLargestStat = MagStats.Names.Dex,
            ThirdLargestStat = MagStats.Names.Mind,
            SmallestStat = MagStats.Names.Mind,
            SecondLargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var marica = new EvolutionCondition(Names.Marica)
        {
            Tier = tier2,
            RequiredClass = Classes.Force,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Bluefull, SectionIDs.Pinkal, SectionIDs.Oran, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Pow,
            SecondLargestStat = MagStats.Names.Dex,
            ThirdLargestStat = MagStats.Names.Mind,
            SmallestStat = MagStats.Names.Mind,
            SecondLargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var naga01 = new EvolutionCondition(Names.Naga)
        {
            Tier = tier2,
            RequiredClass = Classes.Force,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Bluefull, SectionIDs.Pinkal, SectionIDs.Oran, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Pow,
            SecondLargestStat = MagStats.Names.Mind,
            ThirdLargestStat = MagStats.Names.Dex,
            SmallestStat = MagStats.Names.Dex,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var naga02 = new EvolutionCondition(Names.Naga)
        {
            Tier = tier2,
            RequiredClass = Classes.Force,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Skyly, SectionIDs.Purplenum, SectionIDs.Redria, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Mind,
            SecondLargestStat = MagStats.Names.Pow,
            ThirdLargestStat = MagStats.Names.Dex,
            SmallestStat = MagStats.Names.Dex,
            LargestStatAllowedToBeEqual = true,
            SecondLargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var naga03 = new EvolutionCondition(Names.Naga)
        {
            Tier = tier2,
            RequiredClass = Classes.Force,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Skyly, SectionIDs.Purplenum, SectionIDs.Redria, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Pow,
            SecondLargestStat = MagStats.Names.Dex,
            ThirdLargestStat = MagStats.Names.Mind,
            SmallestStat = MagStats.Names.Mind,
            LargestStatAllowedMustBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var nandin = new EvolutionCondition(Names.Nandin)
        {
            Tier = tier2,
            RequiredClass = Classes.Hunter,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Skyly, SectionIDs.Purplenum, SectionIDs.Redria, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Dex,
            SecondLargestStat = MagStats.Names.Mind,
            ThirdLargestStat = MagStats.Names.Pow,
            SmallestStat = MagStats.Names.Pow,
            SecondLargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var naraka = new EvolutionCondition(Names.Naraka)
        {
            Tier = tier2,
            RequiredClass = Classes.Force,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Skyly, SectionIDs.Purplenum, SectionIDs.Redria, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Pow,
            SecondLargestStat = MagStats.Names.Dex,
            ThirdLargestStat = MagStats.Names.Mind,
            SmallestStat = MagStats.Names.Mind,
            SecondLargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var ravana = new EvolutionCondition(Names.Ravana)
        {
            Tier = tier2,
            RequiredClass = Classes.Force,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Skyly, SectionIDs.Purplenum, SectionIDs.Redria, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Pow,
            SecondLargestStat = MagStats.Names.Mind,
            ThirdLargestStat = MagStats.Names.Dex,
            SmallestStat = MagStats.Names.Dex,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var ribhava = new EvolutionCondition(Names.Ribhava)
        {
            Tier = tier2,
            RequiredClass = Classes.Force,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Skyly, SectionIDs.Purplenum, SectionIDs.Redria, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Dex,
            SecondLargestStat = MagStats.Names.Pow,
            ThirdLargestStat = MagStats.Names.Mind,
            SmallestStat = MagStats.Names.Mind,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var sita = new EvolutionCondition(Names.Sita)
        {
            Tier = tier2,
            RequiredClass = Classes.Force,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Skyly, SectionIDs.Purplenum, SectionIDs.Redria, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Dex,
            SecondLargestStat = MagStats.Names.Mind,
            ThirdLargestStat = MagStats.Names.Pow,
            SmallestStat = MagStats.Names.Pow,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var soma = new EvolutionCondition(Names.Soma)
        {
            Tier = tier2,
            RequiredClass = Classes.Hunter,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill,SectionIDs.Bluefull, SectionIDs.Pinkal, SectionIDs.Oran, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Mind,
            SecondLargestStat = MagStats.Names.Dex,
            ThirdLargestStat = MagStats.Names.Pow,
            SmallestStat = MagStats.Names.Pow,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var ushasu = new EvolutionCondition(Names.Ushasu)
        {
            Tier = tier2,
            RequiredClass = Classes.Hunter,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Skyly, SectionIDs.Purplenum, SectionIDs.Redria, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Mind,
            SecondLargestStat = MagStats.Names.Dex,
            ThirdLargestStat = MagStats.Names.Pow,
            SmallestStat = MagStats.Names.Pow,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var varaha01 = new EvolutionCondition(Names.Varaha)
        {
            Tier = tier2,
            RequiredClass = Classes.Hunter,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Skyly, SectionIDs.Purplenum, SectionIDs.Redria, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Pow,
            SecondLargestStat = MagStats.Names.Dex,
            ThirdLargestStat = MagStats.Names.Mind,
            SmallestStat = MagStats.Names.Mind,
            LargestStatAllowedToBeEqual = true,
            SecondLargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var varaha02 = new EvolutionCondition(Names.Varaha)
        {
            Tier = tier2,
            RequiredClass = Classes.Hunter,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Skyly, SectionIDs.Purplenum, SectionIDs.Redria, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Dex,
            SecondLargestStat = MagStats.Names.Mind,
            ThirdLargestStat = MagStats.Names.Pow,
            SmallestStat = MagStats.Names.Pow,
            LargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var varaha03 = new EvolutionCondition(Names.Varaha)
        {
            Tier = tier2,
            RequiredClass = Classes.Ranger,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Skyly, SectionIDs.Purplenum, SectionIDs.Redria, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Mind,
            SecondLargestStat = MagStats.Names.Pow,
            ThirdLargestStat = MagStats.Names.Dex,
            SmallestStat = MagStats.Names.Dex,
            SecondLargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var varaha04 = new EvolutionCondition(Names.Varaha)
        {
            Tier = tier2,
            RequiredClass = Classes.Ranger,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Bluefull, SectionIDs.Pinkal, SectionIDs.Oran, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Dex,
            SecondLargestStat = MagStats.Names.Mind,
            ThirdLargestStat = MagStats.Names.Pow,
            SmallestStat = MagStats.Names.Pow,
            LargestStatAllowedToBeEqual = true,
            SecondLargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var varaha05 = new EvolutionCondition(Names.Varaha)
        {
            Tier = tier2,
            RequiredClass = Classes.Ranger,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Bluefull, SectionIDs.Pinkal, SectionIDs.Oran, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Pow,
            SecondLargestStat = MagStats.Names.Mind,
            ThirdLargestStat = MagStats.Names.Dex,
            SmallestStat = MagStats.Names.Dex,
            LargestStatAllowedMustBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        var yaksa = new EvolutionCondition(Names.Yaksa)
        {
            Tier = tier2,
            RequiredClass = Classes.Hunter,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill,SectionIDs.Bluefull, SectionIDs.Pinkal, SectionIDs.Oran, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = true,
            LargestStat = MagStats.Names.Dex,
            SecondLargestStat = MagStats.Names.Mind,
            ThirdLargestStat = MagStats.Names.Pow,
            SmallestStat = MagStats.Names.Pow,
            SecondLargestStatAllowedToBeEqual = true,
            IsPowImportant = true,
            IsDexImportant = true,
            IsMindImportant = true,
            IsDefImportant = false,
            StatComparisonGroupsRequired = false
        };

        return new List<EvolutionCondition>
        {
            andhaka,
            apsaras01,
            apsaras02,
            bana01,
            bana02,
            bana03,
            bhirava01,
            bhirava02,
            bhirava03,
            bhirava04,
            durga,
            garuda01,
            garuda02,
            ila01,
            ila02,
            kabanda01,
            kabanda02,
            kabanda03,
            kaitabha01,
            kaitabha02,
            kama01,
            kama02,
            kama03,
            kama04,
            kama05,
            kumara01,
            kumara02,
            madhu,
            marica,
            naga01,
            naga02,
            naga03,
            nandin,
            naraka,
            ravana,
            ribhava,
            sita,
            soma,
            ushasu,
            varaha01,
            varaha02,
            varaha03,
            varaha04,
            varaha05,
            yaksa
        };
    }

    private static List<EvolutionCondition> GetTier4EvolutionConditions()
    {
        const int tier3 = 3;

        var bhima01 = new EvolutionCondition(Names.Bhima)
        {
            Tier = tier3,
            RequiredGender = Gender.Female,
            RequiredClass = Classes.Force,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Purplenum, SectionIDs.Oran},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = false,
            StatComparisonGroupsRequired = true,
            StatComparison01 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Def,
                Stat2 = MagStats.Names.Mind
            },
            StatComparison02 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Pow,
                Stat2 = MagStats.Names.Dex
            }
        };

        var bhima02 = new EvolutionCondition(Names.Bhima)
        {
            Tier = tier3,
            RequiredGender = Gender.Female,
            RequiredClass = Classes.Force,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Skyly, SectionIDs.Pinkal, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = false,
            StatComparisonGroupsRequired = true,
            StatComparison01 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Def,
                Stat2 = MagStats.Names.Pow
            },
            StatComparison02 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Dex,
                Stat2 = MagStats.Names.Mind
            }
        };

        var deva =  new EvolutionCondition(Names.Deva)
        {
            Tier = tier3,
            RequiredGender = Gender.Male,
            RequiredClass = Classes.Hunter,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Bluefull, SectionIDs.Redria, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = false,
            StatComparisonGroupsRequired = true,
            StatComparison01 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Def,
                Stat2 = MagStats.Names.Dex
            },
            StatComparison02 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Pow,
                Stat2 = MagStats.Names.Mind
            }
        };

        var diwari = new EvolutionCondition(Names.Diwari)
        {
            Tier = tier3,
            RequiredGender = Gender.Female,
            RequiredClass = Classes.Ranger,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Skyly, SectionIDs.Pinkal, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = false,
            StatComparisonGroupsRequired = true,
            StatComparison01 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Def,
                Stat2 = MagStats.Names.Pow
            },
            StatComparison02 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Dex,
                Stat2 = MagStats.Names.Mind
            }
        };

        var nidra01 = new EvolutionCondition(Names.Nidra)
        {
            Tier = tier3,
            RequiredGender = Gender.Male,
            RequiredClass = Classes.Force,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Bluefull, SectionIDs.Redria, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = false,
            StatComparisonGroupsRequired = true,
            StatComparison01 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Def,
                Stat2 = MagStats.Names.Dex
            },
            StatComparison02 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Pow,
                Stat2 = MagStats.Names.Mind
            }
        };

        var nidra02 = new EvolutionCondition(Names.Nidra)
        {
            Tier = tier3,
            RequiredGender = Gender.Male,
            RequiredClass = Classes.Force,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Purplenum, SectionIDs.Oran},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = false,
            StatComparisonGroupsRequired = true,
            StatComparison01 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Def,
                Stat2 = MagStats.Names.Mind
            },
            StatComparison02 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Pow,
                Stat2 = MagStats.Names.Dex
            }
        };

        var nidra03 = new EvolutionCondition(Names.Nidra)
        {
            Tier = tier3,
            RequiredGender = Gender.Male,
            RequiredClass = Classes.Force,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Skyly, SectionIDs.Pinkal, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = false,
            StatComparisonGroupsRequired = true,
            StatComparison01 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Def,
                Stat2 = MagStats.Names.Pow
            },
            StatComparison02 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Dex,
                Stat2 = MagStats.Names.Mind
            }
        };

        var pushan01 = new EvolutionCondition(Names.Pushan)
        {
            Tier = tier3,
            RequiredGender = Gender.Male,
            RequiredClass = Classes.Ranger,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Bluefull, SectionIDs.Redria, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = false,
            StatComparisonGroupsRequired = true,
            StatComparison01 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Def,
                Stat2 = MagStats.Names.Dex
            },
            StatComparison02 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Pow,
                Stat2 = MagStats.Names.Mind
            }
        };

        var pushan02 = new EvolutionCondition(Names.Pushan)
        {
            Tier = tier3,
            RequiredGender = Gender.Male,
            RequiredClass = Classes.Ranger,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Purplenum, SectionIDs.Oran},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = false,
            StatComparisonGroupsRequired = true,
            StatComparison01 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Def,
                Stat2 = MagStats.Names.Mind
            },
            StatComparison02 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Pow,
                Stat2 = MagStats.Names.Dex
            }
        };

        var pushan03 = new EvolutionCondition(Names.Pushan)
        {
            Tier = tier3,
            RequiredGender = Gender.Male,
            RequiredClass = Classes.Ranger,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Skyly, SectionIDs.Pinkal, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = false,
            StatComparisonGroupsRequired = true,
            StatComparison01 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Def,
                Stat2 = MagStats.Names.Pow
            },
            StatComparison02 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Dex,
                Stat2 = MagStats.Names.Mind
            }
        };

        var rati01 = new EvolutionCondition(Names.Rati)
        {
            Tier = tier3,
            RequiredGender = Gender.Male,
            RequiredClass = Classes.Hunter,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Purplenum, SectionIDs.Oran},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = false,
            StatComparisonGroupsRequired = true,
            StatComparison01 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Def,
                Stat2 = MagStats.Names.Mind
            },
            StatComparison02 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Pow,
                Stat2 = MagStats.Names.Dex
            }
        };

        var rati02 = new EvolutionCondition(Names.Rati)
        {
            Tier = tier3,
            RequiredGender = Gender.Male,
            RequiredClass = Classes.Hunter,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Skyly, SectionIDs.Pinkal, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = false,
            StatComparisonGroupsRequired = true,
            StatComparison01 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Def,
                Stat2 = MagStats.Names.Pow
            },
            StatComparison02 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Pow,
                Stat2 = MagStats.Names.Mind
            }
        };

        var rukimin01 = new EvolutionCondition(Names.Rukmin)
        {
            Tier = tier3,
            RequiredGender = Gender.Female,
            RequiredClass = Classes.Ranger,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Bluefull, SectionIDs.Redria, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = false,
            StatComparisonGroupsRequired = true,
            StatComparison01 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Def,
                Stat2 = MagStats.Names.Dex
            },
            StatComparison02 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Pow,
                Stat2 = MagStats.Names.Mind
            }
        };

        var rukimin02 = new EvolutionCondition(Names.Rukmin)
        {
            Tier = tier3,
            RequiredGender = Gender.Female,
            RequiredClass = Classes.Ranger,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Purplenum, SectionIDs.Oran},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = false,
            StatComparisonGroupsRequired = true,
            StatComparison01 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Def,
                Stat2 = MagStats.Names.Mind
            },
            StatComparison02 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Pow,
                Stat2 = MagStats.Names.Dex
            }
        };

        var sato = new EvolutionCondition(Names.Sato)
        {
            Tier = tier3,
            RequiredGender = Gender.Female,
            RequiredClass = Classes.Force,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Bluefull, SectionIDs.Redria, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = false,
            StatComparisonGroupsRequired = true,
            StatComparison01 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Def,
                Stat2 = MagStats.Names.Dex
            },
            StatComparison02 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Pow,
                Stat2 = MagStats.Names.Mind
            }
        };

        var savitri01 = new EvolutionCondition(Names.Savitri)
        {
            Tier = tier3,
            RequiredGender = Gender.Female,
            RequiredClass = Classes.Hunter,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Viridia, SectionIDs.Bluefull, SectionIDs.Redria, SectionIDs.Whitill},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = false,
            StatComparisonGroupsRequired = true,
            StatComparison01 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Def,
                Stat2 = MagStats.Names.Dex
            },
            StatComparison02 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Pow,
                Stat2 = MagStats.Names.Mind
            }
        };

        var savitri02 = new EvolutionCondition(Names.Savitri)
        {
            Tier = tier3,
            RequiredGender = Gender.Female,
            RequiredClass = Classes.Hunter,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Greenill, SectionIDs.Purplenum, SectionIDs.Oran},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = false,
            StatComparisonGroupsRequired = true,
            StatComparison01 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Def,
                Stat2 = MagStats.Names.Mind
            },
            StatComparison02 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Pow,
                Stat2 = MagStats.Names.Dex
            }
        };

        var savitri03 = new EvolutionCondition(Names.Savitri)
        {
            Tier = tier3,
            RequiredGender = Gender.Female,
            RequiredClass = Classes.Hunter,
            RequiredSectionId = new List<SectionIDs> {SectionIDs.Skyly, SectionIDs.Pinkal, SectionIDs.Yellowboze},
            AreStatsRequired = true,
            IsBasicStatComparisonRequired = false,
            StatComparisonGroupsRequired = true,
            StatComparison01 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Def,
                Stat2 = MagStats.Names.Pow
            },
            StatComparison02 = new EvolutionCondition.StatComparison
            {
                Stat1 = MagStats.Names.Dex,
                Stat2 = MagStats.Names.Mind
            }
        };

        return new List<EvolutionCondition>
        {
            bhima01,
            bhima02,
            deva,
            diwari,
            nidra01,
            nidra02,
            nidra03,
            pushan01,
            pushan02,
            pushan03,
            rati01,
            rati02,
            rukimin01,
            rukimin02,
            sato,
            savitri01,
            savitri02,
            savitri03
        };
    }
}