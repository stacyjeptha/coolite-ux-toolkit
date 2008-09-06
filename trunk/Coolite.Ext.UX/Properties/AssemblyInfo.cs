using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Web.UI;

[assembly: AssemblyVersion("0.6.0.*")]
[assembly: TagPrefix("Coolite.Ext.UX", "ux")]

[assembly: AssemblyTitle("Coolite UX Toolkit")]
[assembly: AssemblyDescription("User Extensions for the Coolite Toolkit")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Coolite Inc.")]
[assembly: AssemblyProduct("Coolite Toolkit for ASP.NET")]
[assembly: AssemblyCopyright("Copyright © 2004-2008 Coolite Inc. or as noted")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: AllowPartiallyTrustedCallers]
[assembly: CLSCompliant(true)]
[assembly: ComVisible(false)]


/*  Extensions
    -----------------------------------------------------------------------------------------------*/

// Portal
[assembly: WebResource("Coolite.Ext.UX.Extensions.Portal.resources.portal.js", "text/javascript")]
[assembly: WebResource("Coolite.Ext.UX.Extensions.Portal.resources.css.portal.css", "text/css", PerformSubstitution = true)]


// GMapPanel
[assembly: WebResource("Coolite.Ext.UX.Extensions.GMapPanel.resources.GMapPanel.js", "text/javascript")]


/*  Plugins
    -----------------------------------------------------------------------------------------------*/

// GridFilters
[assembly: WebResource("Coolite.Ext.UX.Plugins.GridFilters.resources.GridFilters.js", "text/javascript")]
[assembly: WebResource("Coolite.Ext.UX.Plugins.GridFilters.resources.images.GridFilters.css", "text/css", PerformSubstitution = true)]
[assembly: WebResource("Coolite.Ext.UX.Plugins.GridFilters.resources.images.equals.png", "image/png")]
[assembly: WebResource("Coolite.Ext.UX.Plugins.GridFilters.resources.images.find.png", "image/png")]
[assembly: WebResource("Coolite.Ext.UX.Plugins.GridFilters.resources.images.greater_then.png", "image/png")]
[assembly: WebResource("Coolite.Ext.UX.Plugins.GridFilters.resources.images.hd-btn.gif", "image/gif")]
[assembly: WebResource("Coolite.Ext.UX.Plugins.GridFilters.resources.images.header_bg.gif", "image/gif")]
[assembly: WebResource("Coolite.Ext.UX.Plugins.GridFilters.resources.images.less_then.png", "image/png")]
[assembly: WebResource("Coolite.Ext.UX.Plugins.GridFilters.resources.images.sort_filtered_asc.gif", "image/gif")]
[assembly: WebResource("Coolite.Ext.UX.Plugins.GridFilters.resources.images.sort_filtered_desc.gif", "image/gif")]

// InputTextMask
[assembly: WebResource("Coolite.Ext.UX.Plugins.InputTextMask.resources.InputTextMask.js", "text/javascript")]

// PanelResizer
[assembly: WebResource("Coolite.Ext.UX.Plugins.PanelResizer.resources.PanelResizer.js", "text/javascript")]
[assembly: WebResource("Coolite.Ext.UX.Plugins.PanelResizer.resources.css.PanelResizer.css", "text/css", PerformSubstitution = true)]
[assembly: WebResource("Coolite.Ext.UX.Plugins.PanelResizer.resources.images.panelhandle.gif", "image/gif")]

// SliderTip
[assembly: WebResource("Coolite.Ext.UX.Plugins.SliderTip.resources.SliderTip.js", "text/javascript")]

// SlidingPager
[assembly: WebResource("Coolite.Ext.UX.Plugins.SlidingPager.resources.SlidingPager.js", "text/javascript")]

// TabCloseMenu
[assembly: WebResource("Coolite.Ext.UX.Plugins.TabCloseMenu.resources.TabCloseMenu.js", "text/javascript")]