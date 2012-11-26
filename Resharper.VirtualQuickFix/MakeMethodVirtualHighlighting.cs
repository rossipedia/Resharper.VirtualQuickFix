namespace Resharper.VirtualQuickFix
{
    using JetBrains.DocumentModel;
    using JetBrains.ReSharper.Daemon;
    using JetBrains.ReSharper.Daemon.Impl;
    using JetBrains.ReSharper.Psi.CSharp;
    using JetBrains.ReSharper.Psi.CSharp.Tree;

    [ConfigurableSeverityHighlighting(Highlight.SeverityId, CSharpLanguage.Name)]
    public class MakeMethodVirtualHighlighting : IHighlightingWithRange
    {
        private readonly IMethodDeclaration method;

        private readonly DocumentRange range;

        public MakeMethodVirtualHighlighting(IMethodDeclaration method, DocumentRange range)
        {
            this.method = method;
            this.range = range;
        }

        public bool IsValid()
        {
            return this.Method.IsValid();
        }

        public string ToolTip
        {
            get { return Highlight.MethodToolTip; }
        }

        public string ErrorStripeToolTip { get { return this.ToolTip; } }

        public int NavigationOffsetPatch { get { return 0; } }

        public IMethodDeclaration Method
        {
            get { return this.method; }
        }

        public DocumentRange CalculateRange()
        {
            return this.range;
        }
    }
}