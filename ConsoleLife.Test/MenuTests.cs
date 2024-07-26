using ConsoleLife.Model.Menu;

namespace ConsoleLife.Test;

[TestClass]
public class MenuTests
{
    [TestMethod]
    public void Menu_Should_ReturnString()
    {
        Menu menu = new();
    }

    [TestMethod]
    public void MenuOption_Should_ReturnString()
    {
        MenuOption menuOption = new();
    }
}