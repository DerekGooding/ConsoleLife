using ConsoleLife.Data;

namespace ConsoleLife.Test;

[TestClass]
public class DataIntegrityTests
{
    public static IEnumerable<object[]> ActivityNamesData()
    {
        foreach (var item in Enum.GetValues(typeof(ActivityNames)))
            yield return new object[] { item };
    }

    public static IEnumerable<object[]> AttributeNamesData()
    {
        foreach (var item in Enum.GetValues(typeof(AttributeNames)))
            yield return new object[] { item };
    }

    [DataTestMethod]
    [DynamicData(nameof(AttributeNamesData), DynamicDataSourceType.Method)]
    [TestMethod]
    public void Attribute_Enum_ShouldPairWithPrewarm(AttributeNames item)
    {
        var expect = Attributes.PreWarm[(int)item].Name;

        Assert.AreEqual(expect, item.ToString());
    }

    [DataTestMethod]
    [DynamicData(nameof(ActivityNamesData), DynamicDataSourceType.Method)]
    [TestMethod]
    public void Activity_Enum_ShouldPairWithPrewarm(ActivityNames item)
    {
        var expect = Activities.PreWarm[(int)item].Name;

        Assert.AreEqual(expect, item.ToString());
    }

    [TestMethod]
    public void Attribute_Enum_ShouldHaveSameLength()
    {
        var expect = Enum.GetValues(typeof(AttributeNames)).Length;
        var actual = Attributes.PreWarm.Count;

        Assert.AreEqual(expect, actual);
    }

    [TestMethod]
    public void Activity_Enum_ShouldHaveSameLength()
    {
        var expect = Enum.GetValues(typeof(ActivityNames)).Length;
        var actual = Activities.PreWarm.Count;

        Assert.AreEqual(expect, actual);
    }

}