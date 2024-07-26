using ConsoleLife.Model.Menu;

namespace ConsoleLife.Test;

[TestClass]
public class MenuTests
{
    [TestMethod]
    public void Menu_Should_ReturnString()
    {
        Menu menu = new();

        menu.Options.Add(new("1", "Open Door"));
        menu.Options.Add(new("2", "Close Door"));

        const string expected = "1 => Open Door\n2 => Close Door";

        Assert.AreEqual(expected, menu.Print());
    }

    [TestMethod]
    public void Menu_Should_ReturnOnlyIfRequirementMet()
    {
        Menu menu = new();

        menu.Options.Add(new("1", "Open Door"));
        menu.Options.Add(new("2", "Close Door") { Requirement = () => false });

        const string expected = "1 => Open Door";

        Assert.AreEqual(expected, menu.Print());
    }

    [TestMethod]
    public void Menu_Should_InvokeChoice()
    {
        Menu menu = new();

    }

    [TestMethod]
    public void MenuOption_Should_ReturnString()
    {
        MenuOption menuOption = new("1", "Open Door");
        const string expected = "1 => Open Door";

        Assert.AreEqual(expected, menuOption.Print());
    }


}