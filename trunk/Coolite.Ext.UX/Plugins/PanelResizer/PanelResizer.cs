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
    [InstanceOf("Ext.ux.PanelResizer")]
    [ClientScript(Type = typeof(PanelResizer), WebResource = "Coolite.Ext.UX.Plugins.PanelResizer.resources.PanelResizer.js")]
    [ClientStyle(Type = typeof(PanelResizer), WebResource = "Coolite.Ext.UX.Plugins.PanelResizer.resources.css.PanelResizer.css")]
    [ToolboxBitmap(typeof(Coolite.Ext.UX.PanelResizer), "Build.Resources.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:PanelResizer runat=\"server\" />")]
    public class PanelResizer : Plugin
    {
        [ClientConfig]
        [Category("Config Options")]
        [DefaultValue(0)]
        [NotifyParentProperty(true)]
        public int MinHeight
        {
            get
            {
                object obj = this.ViewState["MinHeight"];
                return obj == null ? 0 : (int)obj;
            }
            set
            {
                this.ViewState["MinHeight"] = value;
            }
        }

        [ClientConfig]
        [Category("Config Options")]
        [DefaultValue(10000000)]
        [NotifyParentProperty(true)]
        public int MaxHeight
        {
            get
            {
                object obj = this.ViewState["MaxHeight"];
                return obj == null ? 10000000 : (int)obj;
            }
            set
            {
                this.ViewState["MaxHeight"] = value;
            }
        }
    }
}
