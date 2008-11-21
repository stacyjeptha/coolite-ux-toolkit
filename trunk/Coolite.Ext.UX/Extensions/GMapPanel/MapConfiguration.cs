/******** 
* Copyright (c) 2008 Coolite Inc.

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

* @version:	    0.7.0
* @author:	    Coolite Inc. http://www.coolite.com/
* @date:		2008-11-21
* @copyright:   Copyright (c) 2006-2008, Coolite Inc, or as noted within each 
* 			    applicable file LICENSE.txt file
* @license:	    MIT
* @website:	    http://www.coolite.com/
********/

using System.ComponentModel;
using Coolite.Ext.Web;

namespace Coolite.Ext.UX
{
    public class MapConfiguration : StateManagedItem
    {
        [ClientConfig]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("Enables the dragging of the map (enabled by default).")]
        public bool Dragging
        {
            get
            {
                object o = this.ViewState["Dragging"];
                return o != null ? (bool)o : true;
            }
            set
            {
                this.ViewState["Dragging"] = value;
            }
        }

        [ClientConfig]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("Enables info window operations on the map (enabled by default).")]
        public bool InfoWindow
        {
            get
            {
                object o = this.ViewState["InfoWindow"];
                return o != null ? (bool)o : true;
            }
            set
            {
                this.ViewState["InfoWindow"] = value;
            }
        }

        [ClientConfig]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("Enables double click to zoom in and out (disabled by default).")]
        public bool DoubleClickZoom
        {
            get
            {
                object o = this.ViewState["DoubleClickZoom"];
                return o != null ? (bool)o : false;
            }
            set
            {
                this.ViewState["DoubleClickZoom"] = value;
            }
        }

        [ClientConfig]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("Enables continuous smooth zooming for select browsers (disabled by default).")]
        public bool ContinuousZoom
        {
            get
            {
                object o = this.ViewState["ContinuousZoom"];
                return o != null ? (bool)o : false;
            }
            set
            {
                this.ViewState["ContinuousZoom"] = value;
            }
        }

        [ClientConfig]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("Enables the GoogleBar, an integrated search control, to the map. When enabled, this control takes the place of the default Powered By Google logo. Note that this control is not enabled by default.")]
        public bool GoogleBar
        {
            get
            {
                object o = this.ViewState["GoogleBar"];
                return o != null ? (bool)o : false;
            }
            set
            {
                this.ViewState["GoogleBar"] = value;
            }
        }

        [ClientConfig]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("Enables zooming using a mouse's scroll wheel. Note: scroll wheel zoom is disabled by default.")]
        public bool ScrollWheelZoom
        {
            get
            {
                object o = this.ViewState["ScrollWheelZoom"];
                return o != null ? (bool)o : false;
            }
            set
            {
                this.ViewState["ScrollWheelZoom"] = value;
            }
        }
    }
}
