using Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects;
using Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.InsideObjects;
using Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.ValueObjects;

namespace Builders.UsingBuildersLooselyCoupled.DomainLayer.MyObjects;

public class MyObject: IMyObject
{
    public string Property1 { get; private set; }
    public string Property2 { get; private set; }
    public string Property3 { get; private set; }
    public string Property4 { get; private set; }
    public string Property5 { get; private set; }
    public string Property6 { get; private set; }
    public IInsideObject InsideObject { get; private set; }
    public IEnumerable<IValueObject> ValueObjects { get; private set; }

    public MyObject(IMyObject options)
    {
        Property1 = options.Property1;
        Property2 = options.Property2;
        Property3 = options.Property3;
        Property4 = options.Property4;
        Property5 = options.Property5;
        Property6 = options.Property6;
        InsideObject = options.InsideObject;
        ValueObjects = options.ValueObjects;
    }
}