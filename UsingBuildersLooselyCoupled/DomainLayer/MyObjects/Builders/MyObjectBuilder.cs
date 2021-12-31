using Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects;
using Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.Builders;
using Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.InsideObjects;
using Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.ValueObjects;

namespace Builders.UsingBuildersLooselyCoupled.DomainLayer.MyObjects.Builders;

public class MyObjectBuilder : IMyObjectBuilder
{
    #region Properties And Fields

    public string Property1 { get; private set; }
    public string Property2 { get; private set; }
    public string Property3 { get; private set; }
    public string Property4 { get; private set; }
    public string Property5 { get; private set; }
    public string Property6 { get; private set; }
    public IInsideObject InsideObject { get; private set; }
    public IEnumerable<IValueObject> ValueObjects => _ValueObjects;

    public List<IValueObject> _ValueObjects;

    #endregion

    #region Constructors

    public MyObjectBuilder()
    {
        _ValueObjects = new List<IValueObject>();
    }

    #endregion

    #region With Methods

    public IMyObjectBuilder WithProperty1(string property1)
    {
        Property1 = property1;
        return this;
    }

    public IMyObjectBuilder WithProperty2(string property2)
    {
        Property2 = property2;
        return this;
    }

    public IMyObjectBuilder WithProperty3(string property3)
    {
        Property3 = property3;
        return this;
    }

    public IMyObjectBuilder WithProperty4(string property4)
    {
        Property4 = property4;
        return this;
    }

    public IMyObjectBuilder WithProperty5(string property5)
    {
        Property5 = property5;
        return this;
    }

    public IMyObjectBuilder WithProperty6(string property6)
    {
        Property6 = property6;
        return this;
    }

    public IMyObjectBuilder WithInsideObject(IInsideObject insideObject)
    {
        InsideObject = insideObject;
        return this;
    }

    public IMyObjectBuilder AddValueObject(IValueObject anotherObject)
    {
        _ValueObjects.Add(anotherObject);
        return this;
    }

    #endregion

    #region Build Methods

    public IMyObject Build()
    {
        return new MyObject(this);
    }

    #endregion
}