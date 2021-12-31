namespace Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.ValueObjects.Builders;

public interface IValueObjectBuilder : IValueObject
{
    IValueObjectBuilder WithProperty1(string property1);
    public IValueObjectBuilder WithProperty2(string property2);
    public IValueObject Build();
}