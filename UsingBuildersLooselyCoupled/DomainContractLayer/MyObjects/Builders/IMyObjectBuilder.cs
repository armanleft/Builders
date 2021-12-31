using Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.InsideObjects;
using Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.ValueObjects;

namespace Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.Builders;

public interface IMyObjectBuilder : IMyObject
{
    IMyObjectBuilder WithProperty1(string property1);
    IMyObjectBuilder WithProperty2(string property2);
    IMyObjectBuilder WithProperty3(string property3);
    IMyObjectBuilder WithProperty4(string property4);
    IMyObjectBuilder WithProperty5(string property5);
    IMyObjectBuilder WithProperty6(string property6);
    IMyObjectBuilder WithInsideObject(IInsideObject insideObject);
    IMyObjectBuilder AddValueObject(IValueObject anotherObject);
    public IMyObject Build();
}