using Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.ValueObjects;
using Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.ValueObjects.Builders;

namespace Builders.UsingBuildersLooselyCoupled.DomainLayer.MyObjects.ValueObjects.Builders;

public class ValueObjectBuilder : IValueObjectBuilder
{
    public string Property1 { get; private set; }
    public string Property2 { get; private set; }

    public IValueObjectBuilder WithProperty1(string property1)
    {
        Property1 = property1;
        return this;
    }

    public IValueObjectBuilder WithProperty2(string property2)
    {
        Property2 = property2;
        return this;
    }

    public IValueObject Build()
    {
        return new ValueObject(Property1, Property2);
    }
}