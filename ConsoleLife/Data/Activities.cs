using ConsoleLife.Model;
using static ConsoleLife.Builders.ActivityBuilder;

namespace ConsoleLife.Data;

public enum ActivityNames
{
    Idle,
    Explore,
}

public static class Activities
{
    public static List<Activity> PreWarm =>
    [
        Name(nameof(ActivityNames.Idle)).Instant(),
        Name(nameof(ActivityNames.Explore)).CompletionTime(5),
    ];
}
