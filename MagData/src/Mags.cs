namespace MagData;

public class Mags
{
    private static List<Mag> MagList { get; set; } = GetMags();

    private static List<Mag> GetMags()
    {
        var magList = new List<Mag>();

        magList.Add(new Mag(Names.Mag, Classes.None, new Stats(0), FeedTables.GetFeedTable(0)));

        magList.Add(new Mag(Names.Varuna, Classes.Hunter, new Stats(1), FeedTables.GetFeedTable(1)));
        magList.Add(new Mag(Names.Kalki, Classes.Ranger, new Stats(1), FeedTables.GetFeedTable(1)));
        magList.Add(new Mag(Names.Vritra, Classes.Force, new Stats(1), FeedTables.GetFeedTable(1)));

        return magList;
    }

    public static Mag GetMag(Names name)
    {
        var result = MagList.Find(x => x.Name == name);

        if (result == null)
        {
            throw new Exception($"Mag {name} not found.");
        }

        return result;
    }
}