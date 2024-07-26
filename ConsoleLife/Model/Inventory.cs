namespace ConsoleLife.Model;

internal class Inventory
{
    public Dictionary<Item, int> Items { get; set; } = [];

    public void AddItem(Item key, int amount)
    {
        if (!Items.TryAdd(key, amount))
            Items[key] += amount;
    }

    public void RemoveItem(Item key, int amount)
    {
        if (!Items.TryGetValue(key, out int value))
            return;
        Items[key] -= amount;

        if (value <= 0)
            Items.Remove(key);
    }

    public bool Has(Item key, int amount) => Items.ContainsKey(key) && Items[key] <= amount;

}