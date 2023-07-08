using System.Text.Json;

namespace MagData;

public class FeedTable
{
    public int Index => FeedTables.TableIndex(this); // TODO Optimize this
    public List<Items.Data> ItemFeedData { get; set; }
    public FeedTable(List<Items.Data> itemFeedData)
    {
        ItemFeedData = itemFeedData;
    }

    public Items.Data GetItemData(Items.Names names)
    {
        var result = ItemFeedData.Find(x => x.Names == names);

        if (result == null)
        {
            throw new Exception($"Item {names} not found in feed table.");
        }

        return result;
    }
}

/// <summary>
/// Serializable container for FeedTables
/// </summary>
public class FeedTablesContainer
{
    public List<FeedTable> FeedTables { get; set; }
}

public static class FeedTables
{
    private static List<FeedTable> _feedTablesList = new();

    private static List<FeedTable> GetFeedTables()
    {
        const string feedTablesFile = "resources/FeedTables.json";
        try
        {
            var feedTablesJson = File.ReadAllText(feedTablesFile);
            var feedTablesContainer = JsonSerializer.Deserialize<FeedTablesContainer>(feedTablesJson);
            return feedTablesContainer?.FeedTables ?? new List<FeedTable>();
        }
        catch (IOException e)
        {
            return new List<FeedTable>();
        }
    }

    /// <summary>
    /// Backup feed table in case the definition file is missing
    /// </summary>
    /// <returns></returns>
    private static FeedTable DefaultFeedTable()
    {
        var monomate = new Items.Data(Items.Names.Monomate, new Items.Stats(5, 40, 5, 0, 3, 3));
        var dimate = new Items.Data(Items.Names.Dimate, new Items.Stats(10, 45, 5, 0, 3, 3));
        var trimate = new Items.Data(Items.Names.Trimate, new Items.Stats(15, 50, 10, 0, 4, 4));
        var monofluid = new Items.Data(Items.Names.Monofluid, new Items.Stats(5, 0, 5, 40, 3, 3));
        var difluid = new Items.Data(Items.Names.Difluid, new Items.Stats(10, 0, 5, 45, 3, 3));
        var trifluid = new Items.Data(Items.Names.Trifluid, new Items.Stats(15, 0, 10, 50, 4, 4));
        var antidote = new Items.Data(Items.Names.Antidote, new Items.Stats(5, 10, 40, 0, 3, 3));
        var antiparalysis = new Items.Data(Items.Names.Antiparalysis, new Items.Stats(5, 0, 44, 10, 3, 3));
        var solAtomizer = new Items.Data(Items.Names.SolAtomizer, new Items.Stats(15, 30, 15, 25, 4, 1));
        var moonAtomizer = new Items.Data(Items.Names.MoonAtomizer, new Items.Stats(15, 25, 15, 30, 4, 1));
        var starAtomizer = new Items.Data(Items.Names.StarAtomizer, new Items.Stats(25, 25, 25, 25, 6, 5));

        var itemData = new List<Items.Data>
        {
            monomate,
            dimate,
            trimate,
            monofluid,
            difluid,
            trifluid,
            antidote,
            antiparalysis,
            solAtomizer,
            moonAtomizer,
            starAtomizer,
        };

        return new FeedTable(itemData);
    }

    public static FeedTable GetFeedTable(int tableIndex)
    {
        if (_feedTablesList.Count == 0)
        {
            _feedTablesList = GetFeedTables();
        }

        if (_feedTablesList.Count == 0)
        {
            return tableIndex == 0 ? DefaultFeedTable() : new FeedTable(new List<Items.Data>());
        }

        return tableIndex switch
        {
            0 => _feedTablesList[0],
            1 => _feedTablesList[1],
            2 => _feedTablesList[2],
            3 => _feedTablesList[3],
            4 => _feedTablesList[4],
            5 => _feedTablesList[5],
            6 => _feedTablesList[6],
            7 => _feedTablesList[7],
            _ => throw new ArgumentOutOfRangeException(nameof(tableIndex), tableIndex, null)
        };
    }

    public static bool SetFeedTables(List<FeedTable> feedTables)
    {
        _feedTablesList = feedTables;
        return true;
    }

    public static int TableIndex(FeedTable feedTable)
    {
        return _feedTablesList.IndexOf(feedTable);
    }
}