﻿/******** 
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
using Coolite.Ext.Web;

namespace Coolite.Ext.UX
{
    public class BooleanFilter : GridFilter
    {
        [ClientConfig(JsonMode.ToLower)]
        [Category("Config Options")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override FilterType Type
        {
            get 
            {
                return FilterType.Boolean;
            }
        }

        [ClientConfig]
        [Category("Config Options")]
        [DefaultValue("Yes")]
        [NotifyParentProperty(true)]
        [Description("The text displayed for the 'Yes' checkbox")]
        public string YesText
        {
            get
            {
                object obj = this.ViewState["YesText"];
                return obj == null ? "Yes" : (string)obj;
            }
            set
            {
                this.ViewState["YesText"] = value;
            }
        }

        [ClientConfig]
        [Category("Config Options")]
        [DefaultValue("No")]
        [NotifyParentProperty(true)]
        [Description("The text displayed for the 'No' checkbox")]
        public string NoText
        {
            get
            {
                object obj = this.ViewState["NoText"];
                return obj == null ? "No" : (string)obj;
            }
            set
            {
                this.ViewState["NoText"] = value;
            }
        }

        [ClientConfig]
        [Category("Config Options")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("The default value of this filter (defaults to false)")]
        public bool DefaultValue
        {
            get
            {
                object obj = this.ViewState["DefaultValue"];
                return obj == null ? false : (bool)obj;
            }
            set
            {
                this.ViewState["DefaultValue"] = value;
            }
        }
    }
}