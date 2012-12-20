using JetBrains.ReSharper.Daemon;
using Resharper.VirtualQuickFix;

[assembly: RegisterConfigurableSeverity(
    Highlight.SeverityId,
    null,
    HighlightingGroupIds.BestPractice,
    "Member should be made virtual",
    "Public properties/methods should be virtual",
    Severity.SUGGESTION,
    false)]

namespace Resharper.VirtualQuickFix
{
    public static class Highlight
    {
        public const string SeverityId = "VirtualQuickFixCanBeVirtual";

        public const string ToolTip = "Public methods/properties should be virtual";

        public const string QuickFix = "Make member virtual";
    }
}
