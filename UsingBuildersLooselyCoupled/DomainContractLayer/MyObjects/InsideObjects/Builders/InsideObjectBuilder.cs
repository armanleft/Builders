using Builders.UsingBuildersLooselyCoupled.DomainLayer.MyObjects.InsideObjects;
using Builders.UsingBuildersLooselyCoupled.DomainLayer.MyObjects.InsideObjects.Builders;

namespace Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.InsideObjects.Builders;

public interface IInsideObjectBuilder : IInsideObject
{
    public IInsideObjectBuilder WithProperty2(string property2);
    public IInsideObjectBuilder WithProperty3(string property3);
    public IInsideObjectBuilder WithProperty4(string property4);
    public IInsideObjectBuilder WithProperty5(string property5);
    public IInsideObjectBuilder WithProperty6(string property6);
    public IInsideObject Build();
}