namespace Resharper.VirtualQuickFix
{
    using JetBrains.DocumentModel;
    using JetBrains.ReSharper.Daemon;
    using JetBrains.ReSharper.Daemon.Impl;
    using JetBrains.ReSharper.Psi.CSharp;
    using JetBrains.ReSharper.Psi.CSharp.Tree;

    [ConfigurableSeverityHighlighting(Highlight.SeverityId, CSharpLanguage.Name)]
    public class MakePropertyVirtualHighlighting : IHighlightingWithRange
    {
        private readonly IPropertyDeclaration method;

        private readonly DocumentRange range;

        public MakePropertyVirtualHighlighting(IPropertyDeclaration method, DocumentRange range)
        {
            this.method = method;
            this.range = range;
        }

        public bool IsValid()
        {
            return this.Property.IsValid();
        }

        public string ToolTip
        {
            get { return Highlight.PropertyToolTip; }
        }

        public string ErrorStripeToolTip { get { return this.ToolTip; } }

        public int NavigationOffsetPatch { get { return 0; } }

        public IPropertyDeclaration Property
        {
            get { return this.method; }
        }

        public DocumentRange CalculateRange()
        {
            return this.range;
        }
    }
}