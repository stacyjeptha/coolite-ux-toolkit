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
using System.Web.UI;
using Coolite.Ext.Web;

namespace Coolite.Ext.UX
{
    public class Marker : StateManagedItem
    {
        [ClientConfig]
        [DefaultValue(0.0)]
        [NotifyParentProperty(true)]
        [Description("The latitude coordinate")]
        public double Lat
        {
            get
            {
                object o = this.ViewState["Lat"];
                return o != null ? (double)o : 0.0;
            }
            set
            {
                this.ViewState["Lat"] = value;
            }
        }

        [ClientConfig]
        [DefaultValue(0.0)]
        [NotifyParentProperty(true)]
        [Description("The longitude  coordinate")]
        public double Lng
        {
            get
            {
                object o = this.ViewState["Lng"];
                return o != null ? (double)o : 0.0;
            }
            set
            {
                this.ViewState["Lng"] = value;
            }
        }

        private MarkerOptions markerOptions;

        [ClientConfig("marker",JsonMode.Object)]
        [Category("Config Options")]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [ViewStateMember]
        public MarkerOptions Options
        {
            get
            {
                if (this.markerOptions == null)
                {
                    this.markerOptions = new MarkerOptions();
                    this.markerOptions.TrackViewState();
                }

                return this.markerOptions;
            }
        }

        private MarkerListeners listeners;

        [ClientConfig("listeners", JsonMode.Object)]
        [Category("Events")]
        [Themeable(false)]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Client-side JavaScript EventHandlers")]
        [ViewStateMember]
        public MarkerListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new MarkerListeners();

                    if (this.IsTrackingViewState)
                    {
                        ((IStateManager)this.listeners).TrackViewState();
                    }
                }
                return this.listeners;
            }
        }
    }

    public class MarkerCollection : StateManagedCollection<Marker>
    {
    }
}
