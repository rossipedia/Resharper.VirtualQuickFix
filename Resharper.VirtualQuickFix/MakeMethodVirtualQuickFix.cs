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
    public class MakeMethodVirtualQuickFix : QuickFixBase
    {
        private readonly MakeMethodVirtualHighlighting highlight;

        public MakeMethodVirtualQuickFix(MakeMethodVirtualHighlighting highlight)
        {
            this.highlight = highlight;
        }

        protected override Action<ITextControl> ExecutePsiTransaction(ISolution solution, IProgressIndicator progress)
        {
            this.highlight.Method.SetVirtual(true);
            return null;
        }

        public override string Text
        {
            get { return Highlight.MethodQuickFix; }
        }

        public override bool IsAvailable(IUserDataHolder cache)
        {
            return this.highlight.Method.IsValid();
        }
    }
}