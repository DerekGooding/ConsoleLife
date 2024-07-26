using ConsoleLife.Model;

namespace ConsoleLife.Test;

[TestClass]
public class GameTests
{
    [TestMethod]
    public void Game_ShouldCreate()
    {
        Game game = new();

        Assert.IsNotNull(game);
    }

}