using ConsoleLife.Model;

namespace ConsoleLife.Builders;

public static class ActivityBuilder
{
    public static Activity SetName(string name) => new Builder().SetName(name);
    public class Builder()
    {
        private Activity _activity = new();
        public Activity SetName(string name)
        {
            _activity.Name = name;
            return _activity;
        }
    }
}
