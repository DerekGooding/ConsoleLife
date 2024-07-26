using ConsoleLife.Model;

namespace ConsoleLife.Builders;

public static class ItemBuilder
{
    public static Item Name(string name) => new Builder().Name(name);

    public interface ISetName
    {
        public Item Name(string name);
    }

    public class Builder() : ISetName
    {
        private readonly Item _item = new();

        public Item Name(string name)
        {
            _item.Name = name;
            return _item;
        }
    }
}
