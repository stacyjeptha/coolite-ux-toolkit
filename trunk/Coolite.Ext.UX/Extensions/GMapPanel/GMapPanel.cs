/******** 
* Copyright (c) 2009 Coolite Inc.

* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:

* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.

* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.

* @version:	    0.8.0
* @author:	    Coolite Inc. http://www.coolite.com/
* @date:		2008-05-25
* @copyright:   Copyright (c) 2006-2009, Coolite Inc, or as noted within each 
* 			    applicable file LICENSE.txt file
* @license:	    MIT
* @website:	    http://www.coolite.com/
********/

using System.ComponentModel;
using System.Drawing;
using System.Web;
using System.Web.UI;
using Coolite.Ext.Web;

namespace Coolite.Ext.UX
{
    [Designer(typeof(EmptyDesigner))]
    [DefaultProperty("")]
    [Xtype("gmappanel")]
    [InstanceOf(ClassName = "Ext.ux.GMapPanel")]
    [ClientScript(Type = typeof(GMapPanel), WebResource = "Coolite.Ext.UX.Extensions.GMapPanel.resources.GMapPanel.js")]
    [ToolboxBitmap(typeof(Coolite.Ext.UX.GMapPanel), "Extension.GMapPanel.GMapPanel.bmp")]
    [ToolboxData("<{0}:GMapPanel runat=\"server\" Title=\"Google Map\" Height=\"300\"></{0}:GMapPanel>")]
    [Description("GMap Panel")]
    public class GMapPanel : GMapPanelBase
    {
        protected override void OnBeforeClientInit(Observable sender)
        {
            base.OnBeforeClientInit(sender);

            string apiKey = HttpContext.Current.Items["GMapApiKey"] as string;
            this.ScriptManager.RegisterClientScriptInclude("GMapApiKey", string.Format(this.APIBaseUrl, apiKey ?? this.APIKey));
        }
    }
}
