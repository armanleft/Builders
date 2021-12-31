using System.Text.Json;
using Builders.UsingBuildersDirectly.MyObjects.Builders;
using Builders.UsingBuildersDirectly.MyObjects.InsideObjects.Builders;
using Builders.UsingBuildersDirectly.MyObjects.ValueObjects.Builders;
using Builders.UsingBuildersLooselyCoupled.DomainContractLayer;
using Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.Builders;
using Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.InsideObjects.Builders;
using Builders.UsingBuildersLooselyCoupled.DomainContractLayer.MyObjects.ValueObjects.Builders;
using Microsoft.Extensions.DependencyInjection;

var a = new MyObjectBuilder()
    .WithProperty1("property1")
    .WithProperty2("property2")
    .WithProperty3("property3")
    .WithProperty4("property4")
    .WithProperty5("property5")
    .WithProperty6("property6")
    .WithInsideObject(new InsideObjectBuilder()
        .WithProperty2("property2")
        .WithProperty3("property3")
        .WithProperty4("property4")
        .WithProperty5("property5")
        .WithProperty6("property6")
        .Build())
    .AddValueObject(new ValueObjectBuilder()
        .WithProperty1("property1")
        .WithProperty2("property2")
        .Build())
    .AddValueObject(new ValueObjectBuilder()
        .WithProperty1("property1")
        .WithProperty2("property2")
        .Build())
    .Build();

Console.WriteLine(JsonSerializer.Serialize(a));
Console.WriteLine();


var serviceProvider = new ServiceCollection()
    .AddSingleton<IDomainFactory, DomainFactory>()
    .BuildServiceProvider();

var factory = serviceProvider.GetService<IDomainFactory>();

var b = factory.GetInstance<IMyObjectBuilder>()
    .WithProperty1("property1")
    .WithProperty2("property2")
    .WithProperty3("property3")
    .WithProperty4("property4")
    .WithProperty5("property5")
    .WithProperty6("property6")
    .WithInsideObject(factory.GetInstance<IInsideObjectBuilder>()
        .WithProperty2("property2")
        .WithProperty3("property3")
        .WithProperty4("property4")
        .WithProperty5("property5")
        .WithProperty6("property6")
        .Build())
    .AddValueObject(factory.GetInstance<IValueObjectBuilder>()
        .WithProperty1("property1")
        .WithProperty2("property2")
        .Build())
    .AddValueObject(factory.GetInstance<IValueObjectBuilder>()
        .WithProperty1("property1")
        .WithProperty2("property2")
        .Build())
    .Build();

Console.WriteLine(JsonSerializer.Serialize(b));