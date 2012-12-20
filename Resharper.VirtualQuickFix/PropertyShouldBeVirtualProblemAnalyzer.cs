namespace Resharper.VirtualQuickFix
{
    using JetBrains.ReSharper.Daemon.Stages.Dispatcher;
    using JetBrains.ReSharper.Psi.CSharp.Tree;

    [ElementProblemAnalyzer(typeof(IPropertyDeclaration), HighlightingTypes = new[] { typeof(MakeVirtualHighlighting<IPropertyDeclaration>) })]
    public class PropertyShouldBeVirtualProblemAnalyzer : ProblemAnalyzer<IPropertyDeclaration>
    {
    }
}
