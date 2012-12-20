namespace Resharper.VirtualQuickFix
{
    using JetBrains.ReSharper.Daemon.Stages.Dispatcher;
    using JetBrains.ReSharper.Psi.CSharp.Tree;

    [ElementProblemAnalyzer(typeof(IMethodDeclaration), HighlightingTypes = new[] { typeof(MakeVirtualHighlighting<IMethodDeclaration>) })]
    public class MethodShouldBeVirtualProblemAnalyzer : ProblemAnalyzer<IMethodDeclaration>
    {
    }
}
