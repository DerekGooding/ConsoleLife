using ConsoleLife.Data;

namespace ConsoleLife.Test;

[TestClass]
public class DataIntegrityTests
{
    public static IEnumerable<object[]> ActivityNamesData()
    {
        foreach (var item in Enum.GetValues(typeof(ActivityNames))) yield return new object[] { item };
    }

    public static IEnumerable<object[]> AttributeNamesData()
    {
        foreach (var item in Enum.GetValues(typeof(AttributeNames))) yield return new object[] { item };
    }

    [DataTestMethod]
    [DynamicData(nameof(AttributeNamesData), DynamicDataSourceType.Method)]
    [TestMethod]
    public void Attribute_Enum_ShouldPairWithPrewarm(AttributeNames item)
        => Assert.AreEqual(Attributes.PreWarm[(int)item].Name, item.ToString());

    [DataTestMethod]
    [DynamicData(nameof(ActivityNamesData), DynamicDataSourceType.Method)]
    [TestMethod]
    public void Activity_Enum_ShouldPairWithPrewarm(ActivityNames item)
        => Assert.AreEqual(Activities.PreWarm[(int)item].Name, item.ToString());

}