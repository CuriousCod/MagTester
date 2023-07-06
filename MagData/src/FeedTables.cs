using System.Text.Json;

namespace MagData;

public class FeedTable
{
    public int Index => FeedTables.TableIndex(this); // TODO Optimize this
    public List<ItemData> ItemFeedData { get; set; }
    public FeedTable(List<ItemData> itemFeedData)
    {
        ItemFeedData = itemFeedData;
    }

    public class ItemData
    {
        public Items Item { get; set; }
        public Stats Stats { get; set; }

        public ItemData(Items item, Stats stats)
        {
            Item = item;
            Stats = stats;
        }
    }

    public ItemData GetItemData(Items item)
    {
        var result = ItemFeedData.Find(x => x.Item == item);

        if (result == null)
        {
            throw new Exception($"Item {item} not found in feed table.");
        }

        return result;
    }
}

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

    private static FeedTable DefaultFeedTable()
    {
        var monomate = new FeedTable.ItemData(Items.Monomate, new Stats(5, 40, 5, 0, 3, 3));
        var dimate = new FeedTable.ItemData(Items.Dimate, new Stats(10, 45, 5, 0, 3, 3));
        var trimate = new FeedTable.ItemData(Items.Trimate, new Stats(15, 50, 10, 0, 4, 4));
        var monofluid = new FeedTable.ItemData(Items.Monofluid, new Stats(5, 0, 5, 40, 3, 3));
        var difluid = new FeedTable.ItemData(Items.Difluid, new Stats(10, 0, 5, 45, 3, 3));
        var trifluid = new FeedTable.ItemData(Items.Trifluid, new Stats(15, 0, 10, 50, 4, 4));
        var antidote = new FeedTable.ItemData(Items.Antidote, new Stats(5, 10, 40, 0, 3, 3));
        var antiparalysis = new FeedTable.ItemData(Items.Antiparalysis, new Stats(5, 0, 44, 10, 3, 3));
        var solAtomizer = new FeedTable.ItemData(Items.SolAtomizer, new Stats(15, 30, 15, 25, 4, 1));
        var moonAtomizer = new FeedTable.ItemData(Items.MoonAtomizer, new Stats(15, 25, 15, 30, 4, 1));
        var starAtomizer = new FeedTable.ItemData(Items.StarAtomizer, new Stats(25, 25, 25, 25, 6, 5));

        var itemData = new List<FeedTable.ItemData>
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
            return tableIndex == 0 ? DefaultFeedTable() : new FeedTable(new List<FeedTable.ItemData>());
        }

        return tableIndex switch
        {
            0 => _feedTablesList[0],
            1 => _feedTablesList[1],
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