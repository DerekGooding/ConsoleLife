namespace ConsoleLife.Model;

internal class Game
{
    public List<Person> Persons { get; } = [];

    public Game()
    {
        Persons.Add(new Person());
    }

    public void Start()
    {

    }
}
