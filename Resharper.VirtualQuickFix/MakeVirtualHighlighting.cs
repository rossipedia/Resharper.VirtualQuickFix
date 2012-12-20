namespace Resharper.VirtualQuickFix
{
    using JetBrains.DocumentModel;
    using JetBrains.ReSharper.Daemon;
    using JetBrains.ReSharper.Daemon.Impl;
    using JetBrains.ReSharper.Psi.CSharp;
    using JetBrains.ReSharper.Psi.Tree;

    [ConfigurableSeverityHighlighting(Highlight.SeverityId, CSharpLanguage.Name)]
    public class MakeVirtualHighlighting<T> : IHighlightingWithRange
        where T : ITreeNode, IModifiersOwnerDeclaration

    {
        private readonly T declaration;

        private readonly DocumentRange range;

        public MakeVirtualHighlighting(T declaration, DocumentRange range)
        {
            this.declaration = declaration;
            this.range = range;
        }

        public bool IsValid()
        {
            return this.Declaration.IsValid();
        }

        public string ToolTip
        {
            get { return Highlight.ToolTip; }
        }

        public string ErrorStripeToolTip { get { return this.ToolTip; } }

        public int NavigationOffsetPatch { get { return 0; } }

        public T Declaration
        {
            get { return this.declaration; }
        }

        public DocumentRange CalculateRange()
        {
            return this.range;
        }
    }
}