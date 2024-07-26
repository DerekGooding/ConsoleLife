namespace ConsoleLife.Model.Menu;

internal class Menu(List<MenuOption>? options = null)
{
    public List<MenuOption> Options = options ?? [];

    public string Print() => string.Join('\n', Options.Where(x => x.Requirement.Invoke()).Select(x => x.Print()));
}
