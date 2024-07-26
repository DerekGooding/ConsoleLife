namespace ConsoleLife.Model.Menu;

internal class MenuOption(string key, string description, Action? action = null, Func<bool>? requirement = null)
{
    public string Key { get; set; } = key;

    public string Description { get; set; } = description;

    public Action Effect { get; set; } = action ?? (static () => { });

    public Func<bool> Requirement { get; set; } = requirement ?? (static () => true );

    public void Invoke() => Effect.Invoke();

    public string Print() => $"{Key} => {Description}";
}
