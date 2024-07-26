using static ConsoleLife.Builders.AttributeBuilder;
using Attribute = ConsoleLife.Model.Attribute;

namespace ConsoleLife.Data;

public enum AttributeNames
{
    Health,
    Food,
}

public static class Attributes
{
    public static List<Attribute> PreWarm =>
    [
        Name(nameof(AttributeNames.Health)).Consumable().StartingValue(100),
        Name(nameof(AttributeNames.Food)).Consumable().StartingValue(100),
    ];
}
