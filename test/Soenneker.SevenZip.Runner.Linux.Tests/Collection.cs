using Xunit;

namespace Soenneker.SevenZip.Runner.Linux.Tests;

/// <summary>
/// This class has no code, and is never created. Its purpose is simply
/// to be the place to apply [CollectionDefinition] and all the
/// ICollectionFixture interfaces.
/// </summary>
[CollectionDefinition("Collection")]
public sealed class Collection : ICollectionFixture<Fixture>
{
}
