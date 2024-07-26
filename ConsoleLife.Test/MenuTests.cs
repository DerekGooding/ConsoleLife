using ConsoleLife.Model.Menu;
using Moq;

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
        var mockService = new Mock<Action>();
        var myClass = new Action(mockService.Object);
        Action action = new(() => { });
        MenuOption menuOption = new("1", "Open Door", myClass);

        menuOption.Invoke();

        mockService.Verify(service => service.Invoke(), Times.Once);
    }

    [TestMethod]
    public void MenuOption_Should_ReturnString()
    {
        MenuOption menuOption = new("1", "Open Door");
        const string expected = "1 => Open Door";

        Assert.AreEqual(expected, menuOption.Print());
    }


}