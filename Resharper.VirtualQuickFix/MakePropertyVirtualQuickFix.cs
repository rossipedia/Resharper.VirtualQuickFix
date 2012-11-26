namespace Resharper.VirtualQuickFix
{
    using System;

    using JetBrains.Application.Progress;
    using JetBrains.ProjectModel;
    using JetBrains.ReSharper.Feature.Services.Bulbs;
    using JetBrains.ReSharper.Intentions.Extensibility;
    using JetBrains.TextControl;
    using JetBrains.Util;

    [QuickFix]
    public class MakePropertyVirtualQuickFix : QuickFixBase
    {
        private readonly MakePropertyVirtualHighlighting highlight;

        public MakePropertyVirtualQuickFix(MakePropertyVirtualHighlighting highlight)
        {
            this.highlight = highlight;
        }

        protected override Action<ITextControl> ExecutePsiTransaction(ISolution solution, IProgressIndicator progress)
        {
            this.highlight.Property.SetVirtual(true);
            return null;
        }

        public override string Text
        {
            get { return Highlight.PropertyQuickFix; }
        }

        public override bool IsAvailable(IUserDataHolder cache)
        {
            return this.highlight.Property.IsValid();
        }
    }
}