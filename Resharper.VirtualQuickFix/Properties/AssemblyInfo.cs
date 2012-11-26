using System.Reflection;
using JetBrains.ActionManagement;
using JetBrains.Application.PluginSupport;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Resharper.VirtualQuickFix")]
[assembly: AssemblyDescription("Adds option for properties/methods to make virtual")]
[assembly: AssemblyCompany("Bryan J. Ross")]
[assembly: AssemblyProduct("Resharper.VirtualQuickFix")]
[assembly: AssemblyCopyright("Copyright © Bryan J. Ross, 2012")]


[assembly: AssemblyVersion("1.0.1.*")]

[assembly: ActionsXml("Resharper.VirtualQuickFix.Actions.xml")]

// The following information is displayed by ReSharper in the Plugins dialog
[assembly: PluginTitle("Make Method / Property Virtual")]
[assembly: PluginDescription("Adds option for properties/methods to make virtual")]
[assembly: PluginVendor("Bryan J. Ross (based on Hadi Hariri's original plugin)")]
