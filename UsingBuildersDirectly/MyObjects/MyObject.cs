using Builders.UsingBuildersDirectly.MyObjects.Builders;
using Builders.UsingBuildersDirectly.MyObjects.InsideObjects;
using Builders.UsingBuildersDirectly.MyObjects.ValueObjects;

namespace Builders.UsingBuildersDirectly.MyObjects;

public class MyObject
{
    public string Property1 { get; private set; }
    public string Property2 { get; private set; }
    public string Property3 { get; private set; }
    public string Property4 { get; private set; }
    public string Property5 { get; private set; }
    public string Property6 { get; private set; }
    public InsideObject InsideObject { get; private set; }
    public IEnumerable<ValueObject> ValueObjects { get; private set; }

    public MyObject(IMyObjectOptions options)
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