using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Web.UI;

[assembly: AssemblyVersion("0.8.0.*")]
[assembly: TagPrefix("Coolite.Ext.UX", "ux")]

[assembly: AssemblyTitle("Coolite UX Toolkit")]
[assembly: AssemblyDescription("User Extensions for the Coolite Toolkit")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Coolite Inc.")]
[assembly: AssemblyProduct("Coolite Toolkit for ASP.NET")]
[assembly: AssemblyCopyright("Copyright © 2004-2009 Coolite Inc. or as noted")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: AllowPartiallyTrustedCallers]
[assembly: CLSCompliant(true)]
[assembly: ComVisible(false)]


/*  Extensions
    -----------------------------------------------------------------------------------------------*/

// GMapPanel
[assembly: WebResource("Coolite.Ext.UX.Extensions.GMapPanel.resources.GMapPanel.js", "text/javascript")]


/*  Plugins
    -----------------------------------------------------------------------------------------------*/

// InputTextMask
[assembly: WebResource("Coolite.Ext.UX.Plugins.InputTextMask.resources.InputTextMask.js", "text/javascript")]