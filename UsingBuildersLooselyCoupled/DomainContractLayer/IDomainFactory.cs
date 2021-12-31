namespace Builders.UsingBuildersLooselyCoupled.DomainContractLayer;

public interface IDomainFactory
{
    T GetInstance<T>();
}