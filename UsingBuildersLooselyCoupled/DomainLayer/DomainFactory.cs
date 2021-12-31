using Builders.UsingBuildersLooselyCoupled.DomainContractLayer;
using Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.Builders;
using Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.InsideObjects.Builders;
using Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.ValueObjects.Builders;
using Builders.UsingBuildersLooselyCoupled.DomainLayer.MyObjects.Builders;
using Builders.UsingBuildersLooselyCoupled.DomainLayer.MyObjects.InsideObjects.Builders;
using Builders.UsingBuildersLooselyCoupled.DomainLayer.MyObjects.ValueObjects.Builders;

public class DomainFactory : IDomainFactory
{
    public T GetInstance<T>()
    {
        if (typeof(T) == typeof(IMyObjectBuilder))
        {
            return (T)(IMyObjectBuilder)new MyObjectBuilder();
        }

        if (typeof(T) == typeof(IInsideObjectBuilder))
        {
            return (T)(IInsideObjectBuilder)new InsideObjectBuilder();
        }

        if (typeof(T) == typeof(IValueObjectBuilder))
        {
            return (T)(IValueObjectBuilder)new ValueObjectBuilder();
        }
        else
            throw new NotImplementedException($"Creation of {typeof(T)} interface is not supported yet.");
    }
}