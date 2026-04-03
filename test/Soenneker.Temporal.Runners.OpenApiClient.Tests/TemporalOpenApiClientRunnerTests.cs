using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Temporal.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class TemporalOpenApiClientRunnerTests : FixturedUnitTest
{
    public TemporalOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
