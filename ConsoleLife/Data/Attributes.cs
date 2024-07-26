using static ConsoleLife.Builders.AttributeBuilder;
using Attribute = ConsoleLife.Model.Attribute;

namespace ConsoleLife.Data;

public static class Attributes
{
    public static List<Attribute> PreWarm =>
    [
        Name("Health").Consumable().StartingValue(100),
        Name("Food").Consumable().StartingValue(100),
    ];
}
