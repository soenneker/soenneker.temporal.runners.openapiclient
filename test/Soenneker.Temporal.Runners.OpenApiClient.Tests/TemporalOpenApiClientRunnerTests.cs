using Soenneker.Tests.HostedUnit;

namespace Soenneker.Temporal.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class TemporalOpenApiClientRunnerTests : HostedUnitTest
{
    public TemporalOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
