namespace Resharper.VirtualQuickFix
{
    using JetBrains.ReSharper.Daemon.Stages;
    using JetBrains.ReSharper.Daemon.Stages.Dispatcher;
    using JetBrains.ReSharper.Psi.CSharp.Tree;
    using JetBrains.ReSharper.Psi.Tree;

    [ElementProblemAnalyzer(typeof(IPropertyDeclaration), HighlightingTypes = new[] { typeof(MakePropertyVirtualHighlighting) })]
    public class PropertyShouldBeVirtualProblemAnalyzer : ElementProblemAnalyzer<IPropertyDeclaration>
    {
        protected override void Run(IPropertyDeclaration element, ElementProblemAnalyzerData data, IHighlightingConsumer consumer)
        {
            if (element.ShouldBeVirtual())
            {
                consumer.AddHighlighting(new MakePropertyVirtualHighlighting(element, element.GetFirstTokenIn().GetDocumentRange()), element.GetContainingFile());
            }
        }
    }
}
