using ConsoleLife.Model;
using static ConsoleLife.Builders.ItemBuilder;

namespace ConsoleLife.Data;

public enum ItemNames
{
    Apple,
    Coin,
    Axe,
}

public static class Items
{
    public static List<Item> PreWarm =>
    [
        Name(nameof(ItemNames.Apple)),
        Name(nameof(ItemNames.Coin)),
        Name(nameof(ItemNames.Axe)),
    ];
}
