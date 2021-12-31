using Builders.UsingBuildersDirectly.MyObjects.InsideObjects;
using Builders.UsingBuildersDirectly.MyObjects.ValueObjects;

namespace Builders.UsingBuildersDirectly.MyObjects.Builders;

public interface IMyObjectOptions
{
    string Property1 { get; }
    string Property2 { get; }
    string Property3 { get; }
    string Property4 { get; }
    string Property5 { get; }
    string Property6 { get; }
    InsideObject InsideObject { get; }
    List<ValueObject> ValueObjects { get; }
}