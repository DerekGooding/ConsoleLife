using ConsoleLife.Model;
using static ConsoleLife.Builders.ActivityBuilder;

namespace ConsoleLife.Data;

public static class Activities
{
    public static List<Activity> PreWarm =>
    [
        Name("Idle").Instant(),
        Name("Explore").CompletionTime(5),
    ];
}
