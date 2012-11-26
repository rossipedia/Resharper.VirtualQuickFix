namespace Resharper.VirtualQuickFix
{
    using System.Windows.Forms;
    using JetBrains.ActionManagement;
    using JetBrains.Application.DataContext;


    [ActionHandler("VirtualQuickFix.About")]
    public class AboutAction : IActionHandler
    {
        public bool Update(IDataContext context, ActionPresentation presentation, DelegateUpdate nextUpdate)
        {
            // return true or false to enable/disable this action
            return true;
        }

        public void Execute(IDataContext context, DelegateExecute nextExecute)
        {
            MessageBox.Show(
              "VirtualQuickFix",
              "Provides a QuickFix and Analyzer for non-virtual public methods and properties\n" +
              "Inspired by Hadi Hariri's original tutorial (http://bross.in/rsharpplugin)",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information);
        }
    }
}
