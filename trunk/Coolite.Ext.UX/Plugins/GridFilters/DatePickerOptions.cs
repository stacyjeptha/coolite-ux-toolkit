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

using System;
using System.ComponentModel;
using System.Web.UI;
using Coolite.Ext.Web;

namespace Coolite.Ext.UX
{
    [ToolboxItem(false)]
    [InstanceOf("")]
    public class DatePickerOptions : DatePicker
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override bool AutoPostBack
        {
            get { return base.AutoPostBack; }
            set { base.AutoPostBack = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override bool CausesValidation
        {
            get { return base.CausesValidation; }
            set { base.CausesValidation = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string ValidationGroup
        {
            get { return base.ValidationGroup; }
            set { base.ValidationGroup = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override DateTime SelectedDate
        {
            get { return base.SelectedDate; }
            set { base.SelectedDate = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [ClientConfig(JsonMode.Ignore)]
        public override bool ConstrainToViewport
        {
            get { return base.ConstrainToViewport; }
            set { base.ConstrainToViewport = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [ClientConfig(JsonMode.Ignore)]
        public override string ApplyTo
        {
            get { return base.ApplyTo; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [ClientConfig(JsonMode.Ignore)]
        public override string ClientID
        {
            get { return base.ClientID; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [ClientConfig(JsonMode.Ignore)]
        public override string ID
        {
            get { return base.ID; }
            set { base.ID = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [ClientConfig(JsonMode.Ignore)]
        public override string RenderTo
        {
            get { return base.RenderTo; }
        }

        protected override void Render(HtmlTextWriter writer)
        {
            
        }

        protected override void OnPreRender(EventArgs e)
        {
            
        }
    }
}
