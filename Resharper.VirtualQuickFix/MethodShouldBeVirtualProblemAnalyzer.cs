namespace Resharper.VirtualQuickFix
{
    using JetBrains.ReSharper.Daemon.Stages;
    using JetBrains.ReSharper.Daemon.Stages.Dispatcher;
    using JetBrains.ReSharper.Psi.CSharp.Tree;
    using JetBrains.ReSharper.Psi.Tree;

    [ElementProblemAnalyzer(typeof(IMethodDeclaration), HighlightingTypes = new[] { typeof(MakeMethodVirtualHighlighting) })]
    public class MethodShouldBeVirtualProblemAnalyzer : ElementProblemAnalyzer<IMethodDeclaration>
    {
        protected override void Run(IMethodDeclaration element, ElementProblemAnalyzerData data, IHighlightingConsumer consumer)
        {
            if (element.ShouldBeVirtual())
            {
                consumer.AddHighlighting(new MakeMethodVirtualHighlighting(element, element.GetFirstTokenIn().GetDocumentRange()), element.GetContainingFile());
            }
        }
    }
}
