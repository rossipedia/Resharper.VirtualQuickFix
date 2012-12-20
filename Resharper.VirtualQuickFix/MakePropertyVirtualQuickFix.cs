namespace Resharper.VirtualQuickFix
{
    using JetBrains.ReSharper.Feature.Services.Bulbs;
    using JetBrains.ReSharper.Psi.CSharp.Tree;

    [QuickFix]
    public class MakePropertyVirtualQuickFix : MakeVirtualQuickFix<IPropertyDeclaration>
    {
        public MakePropertyVirtualQuickFix(MakeVirtualHighlighting<IPropertyDeclaration> highlight)
            : base(highlight)
        {
        }
    }
}