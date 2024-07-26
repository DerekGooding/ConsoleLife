using ConsoleLife.Data;

namespace ConsoleLife.Model;

internal class StatBlock
{
    public List<AttributeHolder> attributes = [.. Attributes.PreWarm.Select(x => new AttributeHolder()
    {
        Attribute = x,
        Current = x.StartingValue,
        Max = x.IsConsumable ? x.StartingValue : null,
    })];

    internal struct AttributeHolder
    {
        public Attribute Attribute { get; set; }
        public int Current { get; set; }
        public int? Max { get; set; }

        public readonly bool IsConsumable => Max != null;
    }
}