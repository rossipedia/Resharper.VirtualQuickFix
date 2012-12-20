namespace Resharper.VirtualQuickFix
{
    using JetBrains.ReSharper.Daemon.Stages;
    using JetBrains.ReSharper.Daemon.Stages.Dispatcher;
    using JetBrains.ReSharper.Psi;
    using JetBrains.ReSharper.Psi.CSharp.Tree;
    using JetBrains.ReSharper.Psi.Tree;

    public abstract class ProblemAnalyzer<T> : ElementProblemAnalyzer<T>
        where T : ITreeNode, IAccessRightsOwner, ICSharpTypeMemberDeclaration, IModifiersOwner
    {
        protected override void Run(T element, ElementProblemAnalyzerData data, IHighlightingConsumer consumer)
        {
            if (!element.ShouldBeVirtual())
            {
                return;
            }

            var range = element.ModifiersList.GetFirstTokenIn().GetDocumentRange();
            var containingFile = element.GetContainingFile();
            var highlighting = new MakeVirtualHighlighting<T>(element, range);
            consumer.AddHighlighting(highlighting, containingFile);
        }
    }
}