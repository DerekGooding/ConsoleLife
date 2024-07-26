using ConsoleLife.Model;

namespace ConsoleLife.Builders;

public static class ActivityBuilder
{
    public static ISetCompletionTime Name(string name) => new Builder().Name(name);

    public interface ISetName
    {
        public ISetCompletionTime Name(string name);
    }
    public interface ISetCompletionTime
    {
        public Activity CompletionTime(int timeInSeconds);
        public Activity Instant();
    }


    public class Builder() : ISetName, ISetCompletionTime
    {
        private readonly Activity _activity = new();

        public Activity Instant() => _activity;

        public Activity CompletionTime(int timeInSeconds)
        {
            _activity.SecondsToComplete = timeInSeconds;
            return _activity;
        }

        public ISetCompletionTime Name(string name)
        {
            _activity.Name = name;
            return this;
        }
    }
}
