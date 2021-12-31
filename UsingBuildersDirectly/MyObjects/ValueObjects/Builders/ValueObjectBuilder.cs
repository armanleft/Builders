namespace Builders.UsingBuildersDirectly.MyObjects.ValueObjects.Builders;

public class ValueObjectBuilder
{
    public string Property1 { get; private set; }
    public string Property2 { get; private set; }

    public ValueObjectBuilder WithProperty1(string property1)
    {
        Property1 = property1;
        return this;
    }

    public ValueObjectBuilder WithProperty2(string property2)
    {
        Property2 = property2;
        return this;
    }

    public ValueObject Build()
    {
        return new ValueObject(Property1, Property2);
    }
}