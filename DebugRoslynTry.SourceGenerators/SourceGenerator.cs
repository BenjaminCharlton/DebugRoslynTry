using Microsoft.CodeAnalysis;

namespace DebugRoslynTry.SourceGenerators;

[Generator]
public class SourceGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        // Just return. Don't want to be too ambitious!
    }
}