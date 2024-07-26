using ConsoleLife.Data;

namespace ConsoleLife.Model;

internal class Person
{
    public Activity CurrentActivity => Plan.Count != 0 ? Plan[0] : Activities.PreWarm[(int)ActivityNames.Idle];

    public List<Activity> Plan { get; } = [];

    public StatBlock StatBlock { get; } = new();

    public Inventory Inventory { get; } = new();
}
