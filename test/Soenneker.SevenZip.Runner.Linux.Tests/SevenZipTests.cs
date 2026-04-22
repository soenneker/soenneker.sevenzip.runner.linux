using Soenneker.Tests.HostedUnit;

namespace Soenneker.SevenZip.Runner.Linux.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class SevenZipTests : HostedUnitTest
{
    public SevenZipTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {
    }
}