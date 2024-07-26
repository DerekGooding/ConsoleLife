namespace ConsoleLife.Model;

public class Item
{
    public string Name { get; set; } = string.Empty;
    public Action Effect { get; set; } = () => { };

    public void Use() => Effect.Invoke();
}
