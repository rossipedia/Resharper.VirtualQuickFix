namespace Resharper.VirtualQuickFix
{
    using JetBrains.ReSharper.Psi;
    using JetBrains.ReSharper.Psi.CSharp.Tree;

    /// <summary>The extensions.</summary>
    public static class Extensions
    {
        /// <summary>The should be virtual.</summary>
        /// <param name="declaration">The declaration.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public static bool ShouldBeVirtual(this IMethodDeclaration declaration)
        {
            return declaration.GetAccessRights() == AccessRights.PUBLIC
                && !declaration.IsStatic
                && !declaration.IsVirtual
                && !declaration.IsOverride;
        }

        /// <summary>The should be virtual.</summary>
        /// <param name="declaration">The declaration.</param>
        /// <returns>The <see cref="bool" />.</returns>
        public static bool ShouldBeVirtual(this IPropertyDeclaration declaration)
        {
            return declaration.GetAccessRights() == AccessRights.PUBLIC
                && !declaration.GetContainingTypeDeclaration().IsSealed
                && !declaration.IsStatic
                && !declaration.IsVirtual
                && !declaration.IsOverride;
        }
    }
}
