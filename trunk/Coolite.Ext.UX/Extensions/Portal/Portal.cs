/******** 
 * This file is part of the Coolite UX Toolkit.

 * The Coolite UX Toolkit is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.

 * The Coolite UX Toolkit is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Lesser General Public License for more details.

 * You should have received a copy of the GNU Lesser General Public License
 * along with the Coolite Toolkit.  If not, see <http://www.gnu.org/licenses/>.
 */

/*
* @version:		0.6.0 Preview-1
* @author:		Coolite Inc. http://www.coolite.com/
* @date:		2008-08-05
* @copyright:	Copyright (c) 2006-2008, Coolite Inc, or as noted within each 
* 				applicable file LICENSE.txt file
* @license:		LGPL 3.0 License
* @website:		http://www.coolite.com/
 ********/

using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using Coolite.Ext.Web;

namespace Coolite.Ext.UX
{
    [Xtype("portal")]
    [InstanceOf("Ext.ux.Portal")]
    [ClientScript(Type = typeof(Portal), WebResource = "Coolite.Ext.UX.Extensions.Portal.resources.portal.js")]
    [ClientStyle(Type = typeof(Portal), WebResource = "Coolite.Ext.UX.Extensions.Portal.resources.css.portal.css")]
    [Designer(typeof(EmptyDesigner))]
    [ToolboxBitmap(typeof(Coolite.Ext.UX.Portal), "Extensions.Portal.Portal.bmp")]
    [ToolboxData("<{0}:Portal runat=\"server\" Title=\"Portal\"><Content><ext:ColumnLayout runat=\"server\"><ext:LayoutColumn ColumnWidth=\".33\"><ux:PortalColumn runat=\"server\"StyleSpec=\"padding:10px 0 10px 10px\"><Content><ext:AnchorLayout runat=\"server\"><ext:Anchor Horizontal=\"100%\"><ux:Portlet runat=\"server\" Title=\"Portlet 1\"/></ext:Anchor><ext:Anchor Horizontal=\"100%\"><ux:Portlet runat=\"server\" Title=\"Portlet 2\"/></ext:Anchor></ext:AnchorLayout></Content></ux:PortalColumn></ext:LayoutColumn><ext:LayoutColumn ColumnWidth=\".33\"><ux:PortalColumn runat=\"server\"StyleSpec=\"padding:10px 0 10px 10px\"><Content><ext:AnchorLayout runat=\"server\"><ext:Anchor Horizontal=\"100%\"><ux:Portlet runat=\"server\" Title=\"Portlet 3\"/></ext:Anchor></ext:AnchorLayout></Content></ux:PortalColumn></ext:LayoutColumn><ext:LayoutColumn ColumnWidth=\".33\"><ux:PortalColumn runat=\"server\" StyleSpec=\"padding:10px\"><Content><ext:AnchorLayout runat=\"server\"><ext:Anchor Horizontal=\"100%\"><ux:Portlet Title=\"Portlet 4\" runat=\"server\" /></ext:Anchor></ext:AnchorLayout></Content></ux:PortalColumn></ext:LayoutColumn></ext:ColumnLayout></Content></{0}:Portal>")]
    [Description("Portlet")]
    public class Portal : ContentPanel { }

    [Xtype("portalcolumn")]
    [InstanceOf("Ext.ux.PortalColumn")]
    [ToolboxBitmap(typeof(Coolite.Ext.UX.PortalColumn), "Extensions.Portal.PortalColumn.bmp")]
    [ToolboxData("<{0}:PortalColumn runat=\"server\" StyleSpec=\"padding:10px 0 10px 10px\"><Content><ext:AnchorLayout ID=\"AnchorLayout1\" runat=\"server\"><ext:Anchor Horizontal=\"100%\"><ux:Portlet Title=\"Portlet\" runat=\"server\" /></ext:Anchor></ext:AnchorLayout></Content></{0}:PortalColumn>")]
    [Description("Portlet")]
    public class PortalColumn : ContentPanel { }

    [Xtype("portlet")]
    [InstanceOf("Ext.ux.Portlet")]
    [ToolboxBitmap(typeof(Coolite.Ext.UX.Portlet), "Extensions.Portal.Portlet.bmp")]
    [ToolboxData("<{0}:Portlet runat=\"server\" Title=\"Portlet\" />")]
    [Description("Portlet")]
    public class Portlet : ContentPanel { }
}