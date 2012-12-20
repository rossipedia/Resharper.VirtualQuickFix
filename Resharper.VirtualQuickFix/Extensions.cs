// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Extensions.cs" company="Whitestone TEC">
//   (c) Whitestone, TEC. All rights reserved.
// </copyright>
// <summary>
//   The extensions.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Resharper.VirtualQuickFix
{
    using JetBrains.ReSharper.Psi;
    using JetBrains.ReSharper.Psi.CSharp.Tree;

    /// <summary>The extensions.</summary>
    public static class Extensions
    {
        /// <summary>Determines if a method declaration should be marked as virtual</summary>
        /// <param name="declaration">The declaration.</param>
        /// <returns><c>True</c> if the method should be virtualized, otherwise <c>false</c>.</returns>
        public static bool ShouldBeVirtual<T>(this T declaration)
            where T : IAccessRightsOwner, ICSharpTypeMemberDeclaration, IModifiersOwner
        {
            return declaration.GetAccessRights() == AccessRights.PUBLIC
                   && !declaration.GetContainingTypeDeclaration().IsSealed
                   && !(declaration.IsStatic || declaration.IsVirtual || declaration.IsOverride);
        }
    }
}