namespace MagData;

public class Mags
{
    private static List<Mag>? MagList { get; set; }

    private static List<Mag> GetMags()
    {
        var magList = new List<Mag>();

        magList.Add(new Mag(Names.Mag, GetMagStats(0), GetFeedTable(0), GetEvolutionConditions(Names.Mag)));

        magList.Add(new Mag(Names.Varuna, GetMagStats(1), GetFeedTable(1), GetEvolutionConditions(Names.Varuna)));
        magList.Add(new Mag(Names.Kalki, GetMagStats(1), GetFeedTable(1), GetEvolutionConditions(Names.Kalki)));
        magList.Add(new Mag(Names.Vritra, GetMagStats(1), GetFeedTable(1), GetEvolutionConditions(Names.Vritra)));

        magList.Add(new Mag(Names.Rudra, GetMagStats(2), GetFeedTable(2), GetEvolutionConditions(Names.Rudra)));
        magList.Add(new Mag(Names.Marutah, GetMagStats(2), GetFeedTable(2), GetEvolutionConditions(Names.Marutah)));
        magList.Add(new Mag(Names.Vayu, GetMagStats(2), GetFeedTable(4), GetEvolutionConditions(Names.Vayu)));
        magList.Add(new Mag(Names.Surya, GetMagStats(2), GetFeedTable(3), GetEvolutionConditions(Names.Surya)));
        magList.Add(new Mag(Names.Mitra, GetMagStats(2), GetFeedTable(3), GetEvolutionConditions(Names.Mitra)));
        magList.Add(new Mag(Names.Tapas, GetMagStats(2), GetFeedTable(3), GetEvolutionConditions(Names.Tapas)));
        magList.Add(new Mag(Names.Sumba, GetMagStats(2), GetFeedTable(2), GetEvolutionConditions(Names.Sumba)));
        magList.Add(new Mag(Names.Ashvinau, GetMagStats(2), GetFeedTable(2), GetEvolutionConditions(Names.Ashvinau)));
        magList.Add(new Mag(Names.Namuci, GetMagStats(2), GetFeedTable(2), GetEvolutionConditions(Names.Namuci)));

        magList.Add(new Mag(Names.Andhaka, GetMagStats(3), GetFeedTable(6), GetEvolutionConditions(Names.Andhaka)));
        magList.Add(new Mag(Names.Apsaras, GetMagStats(3), GetFeedTable(4), GetEvolutionConditions(Names.Apsaras)));
        magList.Add(new Mag(Names.Bana, GetMagStats(3), GetFeedTable(6), GetEvolutionConditions(Names.Bana)));
        magList.Add(new Mag(Names.Bhirava, GetMagStats(3), GetFeedTable(4), GetEvolutionConditions(Names.Bhirava)));
        magList.Add(new Mag(Names.Durga, GetMagStats(3), GetFeedTable(5), GetEvolutionConditions(Names.Durga)));
        magList.Add(new Mag(Names.Garuda, GetMagStats(3), GetFeedTable(5), GetEvolutionConditions(Names.Garuda)));
        magList.Add(new Mag(Names.Ila, GetMagStats(3), GetFeedTable(5), GetEvolutionConditions(Names.Ila)));
        magList.Add(new Mag(Names.Kabanda, GetMagStats(3), GetFeedTable(6), GetEvolutionConditions(Names.Kabanda)));
        magList.Add(new Mag(Names.Kaitabha, GetMagStats(3), GetFeedTable(4), GetEvolutionConditions(Names.Kaitabha)));
        magList.Add(new Mag(Names.Kama, GetMagStats(3), GetFeedTable(4), GetEvolutionConditions(Names.Kama)));
        magList.Add(new Mag(Names.Kumara, GetMagStats(3), GetFeedTable(4), GetEvolutionConditions(Names.Kumara)));
        magList.Add(new Mag(Names.Madhu, GetMagStats(3), GetFeedTable(6), GetEvolutionConditions(Names.Madhu)));
        magList.Add(new Mag(Names.Marica, GetMagStats(3), GetFeedTable(6), GetEvolutionConditions(Names.Marica)));
        magList.Add(new Mag(Names.Naga, GetMagStats(3), GetFeedTable(6), GetEvolutionConditions(Names.Naga)));
        magList.Add(new Mag(Names.Nandin, GetMagStats(3), GetFeedTable(5), GetEvolutionConditions(Names.Nandin)));
        magList.Add(new Mag(Names.Naraka, GetMagStats(3), GetFeedTable(6), GetEvolutionConditions(Names.Naraka)));
        magList.Add(new Mag(Names.Ravana, GetMagStats(3), GetFeedTable(6), GetEvolutionConditions(Names.Ravana)));
        magList.Add(new Mag(Names.Ribhava, GetMagStats(3), GetFeedTable(5), GetEvolutionConditions(Names.Ribhava)));
        magList.Add(new Mag(Names.Sita, GetMagStats(3), GetFeedTable(5), GetEvolutionConditions(Names.Sita)));
        magList.Add(new Mag(Names.Soma, GetMagStats(3), GetFeedTable(5), GetEvolutionConditions(Names.Soma)));
        magList.Add(new Mag(Names.Ushasu, GetMagStats(3), GetFeedTable(4), GetEvolutionConditions(Names.Ushasu)));
        magList.Add(new Mag(Names.Varaha, GetMagStats(3), GetFeedTable(4), GetEvolutionConditions(Names.Varaha)));
        magList.Add(new Mag(Names.Yaksa, GetMagStats(3), GetFeedTable(5), GetEvolutionConditions(Names.Yaksa)));

        magList.Add(new Mag(Names.Bhima, GetMagStats(4), GetFeedTable(6), GetEvolutionConditions(Names.Bhima)));
        magList.Add(new Mag(Names.Deva, GetMagStats(4), GetFeedTable(5), GetEvolutionConditions(Names.Deva)));
        magList.Add(new Mag(Names.Diwari, GetMagStats(4), GetFeedTable(7), GetEvolutionConditions(Names.Diwari)));
        magList.Add(new Mag(Names.Nidra, GetMagStats(4), GetFeedTable(7), GetEvolutionConditions(Names.Nidra)));
        magList.Add(new Mag(Names.Pushan, GetMagStats(4), GetFeedTable(6), GetEvolutionConditions(Names.Pushan)));
        magList.Add(new Mag(Names.Rati, GetMagStats(4), GetFeedTable(6), GetEvolutionConditions(Names.Rati)));
        magList.Add(new Mag(Names.Rukmin, GetMagStats(4), GetFeedTable(5), GetEvolutionConditions(Names.Rukmin)));
        magList.Add(new Mag(Names.Sato, GetMagStats(4), GetFeedTable(5), GetEvolutionConditions(Names.Sato)));
        magList.Add(new Mag(Names.Savitri, GetMagStats(4), GetFeedTable(7), GetEvolutionConditions(Names.Savitri)));

        return magList;
    }

    private static void Initialize()
    {
        if (MagList != null)
        {
            return;
        }

        MagList = GetMags();
    }

    private static MagStats GetMagStats(int tier)
    {
        return new MagStats(tier);
    }

    private static FeedTable GetFeedTable(int index)
    {
        return FeedTables.GetFeedTable(index);
    }

    private static List<EvolutionCondition> GetEvolutionConditions(Names magName)
    {
        return EvolutionConditions.GetEvolutionConditionsForMag(magName);
    }

    public static Mag GetMag(Names name)
    {
        Initialize();

        var result = MagList?.Find(x => x.Name == name);

        if (result == null)
        {
            throw new Exception($"Mag {name} not found.");
        }

        return result;
    }
}