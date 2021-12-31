using Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.InsideObjects;
using Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.ValueObjects;

namespace Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects;

public interface IMyObject
{
    string Property1 { get; }
    string Property2 { get; }
    string Property3 { get; }
    string Property4 { get; }
    string Property5 { get; }
    string Property6 { get; }
    IInsideObject InsideObject { get; }
    IEnumerable<IValueObject> ValueObjects { get; }
}