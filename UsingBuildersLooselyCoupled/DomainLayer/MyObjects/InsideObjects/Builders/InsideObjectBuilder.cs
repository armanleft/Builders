using Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.InsideObjects;
using Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.InsideObjects.Builders;

namespace Builders.UsingBuildersLooselyCoupled.DomainLayer.MyObjects.InsideObjects.Builders;

public class InsideObjectBuilder : IInsideObjectBuilder
{
    #region Properties

    public string Property1 { get; private set; }
    public string Property2 { get; private set; }
    public string Property3 { get; private set; }
    public string Property4 { get; private set; }
    public string Property5 { get; private set; }
    public string Property6 { get; private set; }

    #endregion

    #region Constructors

    public InsideObjectBuilder()
    {
        Property1 = "This Property Has Some Default Value";
    }

    #endregion

    #region With Methods

    public IInsideObjectBuilder WithProperty2(string property2)
    {
        Property2 = property2;
        return this;
    }

    public IInsideObjectBuilder WithProperty3(string property3)
    {
        Property3 = property3;
        return this;
    }

    public IInsideObjectBuilder WithProperty4(string property4)
    {
        Property4 = property4;
        return this;
    }

    public IInsideObjectBuilder WithProperty5(string property5)
    {
        Property5 = property5;
        return this;
    }

    public IInsideObjectBuilder WithProperty6(string property6)
    {
        Property6 = property6;
        return this;
    }

    #endregion

    #region Build Methods

    public IInsideObject Build()
    {
        return new InsideObject(this);
    }

    #endregion
}