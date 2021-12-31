namespace Builders.UsingBuildersDirectly.MyObjects.ValueObjects;

public class ValueObject
{
    public string Property1 { get; private set; }
    public string Property2 { get; private set; }

    public ValueObject(string property1, string property2)
    {
        Property1 = property1;
        Property2 = property2;
    }
}