namespace MagData;

public class FeedTable
{
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

public static class FeedTables
{
    public static FeedTable FeedTable00 = GetFeedTable(0);
    public static FeedTable FeedTable01 = GetFeedTable(1);
    public static FeedTable FeedTable02;
    public static FeedTable FeedTable03;
    public static FeedTable FeedTable04;
    public static FeedTable FeedTable05;
    public static FeedTable FeedTable06;
    public static FeedTable FeedTable07;
    public static FeedTable FeedTable08;

    public static FeedTable GetFeedTable(int tableIndex)
    {
        return tableIndex switch
        {
            0 => FeedTableValues00(),
            1 => FeedTableValues01(),
            _ => throw new ArgumentOutOfRangeException(nameof(tableIndex), tableIndex, null)
        };
    }

    private static FeedTable FeedTableValues00()
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

    private static FeedTable FeedTableValues01()
    {
        var monomate = new FeedTable.ItemData(Items.Monomate, new Stats(5, 10, 0, -1, 0, 0));
        var dimate = new FeedTable.ItemData(Items.Dimate, new Stats(6, 15, 3, -3, 2, 1));
        var trimate = new FeedTable.ItemData(Items.Trimate, new Stats(12, 21, 4, -7, 3, 2));
        var monofluid = new FeedTable.ItemData(Items.Monofluid, new Stats(5, 0, 0, 8, 0, 0));
        var difluid = new FeedTable.ItemData(Items.Difluid, new Stats(7, 0, 3, 13, 2, 1));
        var trifluid = new FeedTable.ItemData(Items.Trifluid, new Stats(7, -7, 6, 19, 3, 2));
        var antidote = new FeedTable.ItemData(Items.Antidote, new Stats(0, 5, 15, 0, 0, 1));
        var antiparalysis = new FeedTable.ItemData(Items.Antiparalysis, new Stats(-1, 0, 14, 5, 2, 0));
        var solAtomizer = new FeedTable.ItemData(Items.SolAtomizer, new Stats(10, 11, 8, 0, -2, 2));
        var moonAtomizer = new FeedTable.ItemData(Items.MoonAtomizer, new Stats(9, 0, 9, 11, 3, -2));
        var starAtomizer = new FeedTable.ItemData(Items.StarAtomizer, new Stats(14, 9, 18, 11, 4, 3));

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

}