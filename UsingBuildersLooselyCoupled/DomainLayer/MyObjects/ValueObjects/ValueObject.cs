using Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.ValueObjects;

namespace Builders.UsingBuildersLooselyCoupled.DomainLayer.MyObjects.ValueObjects;

public class ValueObject : IValueObject
{
    public string Property1 { get; private set; }
    public string Property2 { get; private set; }

    public ValueObject(string property1, string property2)
    {
        Property1 = property1;
        Property2 = property2;
    }
}