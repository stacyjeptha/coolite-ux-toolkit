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
    public class MapControls : StateManagedItem
    {
        [ClientConfig]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("Creates a control with buttons to pan in four directions, and zoom in and zoom out.")]
        public bool GSmallMapControl
        {
            get
            {
                object o = this.ViewState["GSmallMapControl"];
                return o != null ? (bool)o : false;
            }
            set
            {
                this.ViewState["GSmallMapControl"] = value;
            }
        }

        [ClientConfig]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("Creates a control with buttons to pan in four directions, and zoom in and zoom out, and a zoom slider.")]
        public bool GLargeMapControl
        {
            get
            {
                object o = this.ViewState["GLargeMapControl"];
                return o != null ? (bool)o : false;
            }
            set
            {
                this.ViewState["GLargeMapControl"] = value;
            }
        }

        [ClientConfig]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("Creates a control with buttons to zoom in and zoom out.")]
        public bool GSmallZoomControl
        {
            get
            {
                object o = this.ViewState["GSmallZoomControl"];
                return o != null ? (bool)o : false;
            }
            set
            {
                this.ViewState["GSmallZoomControl"] = value;
            }
        }

        [ClientConfig]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("Creates a control that displays the map scale.")]
        public bool GScaleControl
        {
            get
            {
                object o = this.ViewState["GScaleControl"];
                return o != null ? (bool)o : false;
            }
            set
            {
                this.ViewState["GScaleControl"] = value;
            }
        }

        [ClientConfig]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("Creates a standard map type control for selecting and switching between supported map types via buttons.")]
        public bool GMapTypeControl
        {
            get
            {
                object o = this.ViewState["GMapTypeControl"];
                return o != null ? (bool)o : false;
            }
            set
            {
                this.ViewState["GMapTypeControl"] = value;
            }
        }

        [ClientConfig]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("Creates a drop-down map type control for switching between supported map types.")]
        public bool GMenuMapTypeControl
        {
            get
            {
                object o = this.ViewState["GMenuMapTypeControl"];
                return o != null ? (bool)o : false;
            }
            set
            {
                this.ViewState["GMenuMapTypeControl"] = value;
            }
        }

        [ClientConfig]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("Creates a 'nested' map type control for selecting and switching between supported map types via buttons and nested checkboxes.")]
        public bool GHierarchicalMapTypeControl
        {
            get
            {
                object o = this.ViewState["GHierarchicalMapTypeControl"];
                return o != null ? (bool)o : false;
            }
            set
            {
                this.ViewState["GHierarchicalMapTypeControl"] = value;
            }
        }

        [ClientConfig]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("Creates a collapsible overview mini-map in the corner of the main map for reference location and navigation (through dragging). The GOverviewMapControl creates an overview map with a one-pixel black border.")]
        public bool GOverviewMapControl
        {
            get
            {
                object o = this.ViewState["GOverviewMapControl"];
                return o != null ? (bool)o : false;
            }
            set
            {
                this.ViewState["GOverviewMapControl"] = value;
            }
        }
    }
}
