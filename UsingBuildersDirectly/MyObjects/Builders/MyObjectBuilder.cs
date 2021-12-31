using Builders.UsingBuildersDirectly.MyObjects.InsideObjects;
using Builders.UsingBuildersDirectly.MyObjects.ValueObjects;

namespace Builders.UsingBuildersDirectly.MyObjects.Builders;

public class MyObjectBuilder : IMyObjectOptions
{
    #region Properties

    public string Property1 { get; private set; }
    public string Property2 { get; private set; }
    public string Property3 { get; private set; }
    public string Property4 { get; private set; }
    public string Property5 { get; private set; }
    public string Property6 { get; private set; }
    public InsideObject InsideObject { get; private set; }
    public List<ValueObject> ValueObjects { get; private set; }

    #endregion

    #region Constructors

    public MyObjectBuilder()
    {
        ValueObjects = new List<ValueObject>();
    }

    #endregion

    #region With Methods

    public MyObjectBuilder WithProperty1(string property1)
    {
        Property1 = property1;
        return this;
    }

    public MyObjectBuilder WithProperty2(string property2)
    {
        Property2 = property2;
        return this;
    }

    public MyObjectBuilder WithProperty3(string property3)
    {
        Property3 = property3;
        return this;
    }

    public MyObjectBuilder WithProperty4(string property4)
    {
        Property4 = property4;
        return this;
    }

    public MyObjectBuilder WithProperty5(string property5)
    {
        Property5 = property5;
        return this;
    }

    public MyObjectBuilder WithProperty6(string property6)
    {
        Property6 = property6;
        return this;
    }

    public MyObjectBuilder WithInsideObject(InsideObject insideObject)
    {
        InsideObject = insideObject;
        return this;
    }

    public MyObjectBuilder AddValueObject(ValueObject anotherObject)
    {
        ValueObjects.Add(anotherObject);
        return this;
    }

    #endregion

    #region Build Methods

    public MyObject Build()
    {
        return new MyObject(this);
    }

    #endregion
}