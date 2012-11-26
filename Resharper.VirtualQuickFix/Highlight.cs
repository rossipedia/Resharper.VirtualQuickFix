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

        public const string MethodToolTip = "Public methods should be virtual";

        public const string MethodQuickFix = "Make method virtual";

        public const string PropertyToolTip = "Public properties should be virtual";

        public const string PropertyQuickFix = "Make property virtual";
    }
}
