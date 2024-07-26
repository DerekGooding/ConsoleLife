using Attribute = ConsoleLife.Model.Attribute;

namespace ConsoleLife.Builders;

public static class AttributeBuilder
{
    public static ISetConsumable Name(string name) => new Builder().Name(name);

    public interface ISetName
    {
        public ISetConsumable Name(string name);
    }
    public interface ISetConsumable
    {
        public ISetStartingValue Consumable();
        public Attribute StartingValue(int value);
    }
    public interface ISetStartingValue
    {
        public Attribute StartingValue(int value);
    }


    public class Builder() : ISetName, ISetConsumable, ISetStartingValue
    {
        private readonly Attribute _attribute = new();

        public ISetConsumable Name(string name)
        {
            _attribute.Name = name;
            return this;
        }


        public ISetStartingValue Consumable()
        {
            _attribute.IsConsumable = true;
            return this;
        }


        public Attribute StartingValue(int value)
        {
            _attribute.StartingValue = value;
            return _attribute;
        }
    }
}
