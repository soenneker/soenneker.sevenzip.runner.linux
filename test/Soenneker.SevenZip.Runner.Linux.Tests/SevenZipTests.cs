using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.SevenZip.Runner.Linux.Tests;

[Collection("Collection")]
public sealed class SevenZipTests : FixturedUnitTest
{
    public SevenZipTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {
    }
}