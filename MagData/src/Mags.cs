namespace MagData;

public class Mags
{
    private static List<Mag>? MagList { get; set; }

    private static List<Mag> GetMags()
    {
        var magList = new List<Mag>();

        magList.Add(new Mag(Names.Mag, Classes.None, new MagStats(0), FeedTables.GetFeedTable(0)));

        magList.Add(new Mag(Names.Varuna, Classes.Hunter, new MagStats(1), FeedTables.GetFeedTable(1)));
        magList.Add(new Mag(Names.Kalki, Classes.Ranger, new MagStats(1), FeedTables.GetFeedTable(1)));
        magList.Add(new Mag(Names.Vritra, Classes.Force, new MagStats(1), FeedTables.GetFeedTable(1)));

        magList.Add(new Mag(Names.Rudra, Classes.None, new MagStats(2), FeedTables.GetFeedTable(2)));
        magList.Add(new Mag(Names.Marutah, Classes.None, new MagStats(2), FeedTables.GetFeedTable(2)));
        magList.Add(new Mag(Names.Vayu, Classes.None, new MagStats(2), FeedTables.GetFeedTable(4)));
        magList.Add(new Mag(Names.Surya, Classes.None, new MagStats(2), FeedTables.GetFeedTable(3)));
        magList.Add(new Mag(Names.Mitra, Classes.None, new MagStats(2), FeedTables.GetFeedTable(3)));
        magList.Add(new Mag(Names.Tapas, Classes.None, new MagStats(2), FeedTables.GetFeedTable(3)));
        magList.Add(new Mag(Names.Sumba, Classes.None, new MagStats(2), FeedTables.GetFeedTable(2)));
        magList.Add(new Mag(Names.Ashvinau, Classes.None, new MagStats(2), FeedTables.GetFeedTable(2)));
        magList.Add(new Mag(Names.Namuci, Classes.None, new MagStats(2), FeedTables.GetFeedTable(2)));

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