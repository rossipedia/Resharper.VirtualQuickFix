namespace Resharper.VirtualQuickFix
{
    using JetBrains.ReSharper.Feature.Services.Bulbs;
    using JetBrains.ReSharper.Psi.CSharp.Tree;

    [QuickFix]
    public class MakeMethodVirtualQuickFix : MakeVirtualQuickFix<IMethodDeclaration>
    {
        public MakeMethodVirtualQuickFix(MakeVirtualHighlighting<IMethodDeclaration> highlight)
            : base(highlight)
        {
        }
    }
}