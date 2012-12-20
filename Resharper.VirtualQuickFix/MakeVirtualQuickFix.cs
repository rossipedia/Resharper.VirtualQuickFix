namespace Resharper.VirtualQuickFix
{
    using System;

    using JetBrains.Application.Progress;
    using JetBrains.ProjectModel;
    using JetBrains.ReSharper.Intentions.Extensibility;
    using JetBrains.ReSharper.Psi.Tree;
    using JetBrains.TextControl;
    using JetBrains.Util;

    public abstract class MakeVirtualQuickFix<T> : QuickFixBase
        where T : ITreeNode, IModifiersOwnerDeclaration
    {
        private readonly MakeVirtualHighlighting<T> highlight;

        protected MakeVirtualQuickFix(MakeVirtualHighlighting<T> highlight)
        {
            this.highlight = highlight;
        }

        public override string Text
        {
            get { return Highlight.QuickFix; }
        }

        public override bool IsAvailable(IUserDataHolder cache)
        {
            return this.highlight.Declaration.IsValid();
        }

        protected override Action<ITextControl> ExecutePsiTransaction(ISolution solution, IProgressIndicator progress)
        {
            this.highlight.Declaration.SetVirtual(true);
            return null;
        }
    }
}