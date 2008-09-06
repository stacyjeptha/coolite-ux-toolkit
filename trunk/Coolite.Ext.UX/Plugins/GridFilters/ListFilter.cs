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
using System.Web.UI.WebControls;
using Coolite.Ext.Web;

namespace Coolite.Ext.UX
{
    public class ListFilter : GridFilter
    {
        [ClientConfig(JsonMode.ToLower)]
        [Category("Config Options")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override FilterType Type
        {
            get 
            { 
                return FilterType.List;
            }
        }

        [ClientConfig]
        [Category("Config Options")]
        [DefaultValue("Loading...")]
        [NotifyParentProperty(true)]
        [Description("The loading text displayed when data loading")]
        public string LoadingText
        {
            get
            {
                object obj = this.ViewState["LoadingText"];
                return obj == null ? "Loading..." : (string)obj;
            }
            set
            {
                this.ViewState["LoadingText"] = value;
            }
        }

        [ClientConfig]
        [Category("Config Options")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("If true then the data loading on show")]
        public bool LoadOnShow
        {
            get
            {
                object obj = this.ViewState["LoadOnShow"];
                return obj == null ? true : (bool)obj;
            }
            set
            {
                this.ViewState["LoadOnShow"] = value;
            }
        }

        [ClientConfig(typeof(StringArrayJsonConverter))]
        [TypeConverter(typeof(StringArrayConverter))]
        [DefaultValue(null)]
        [Description("The list of options")]
        public virtual string[] Options
        {
            get
            {
                object obj = this.ViewState["Options"];
                return (obj == null) ? null : (string[])obj;
            }
            set
            {
                this.ViewState["Options"] = value;
            }
        }
    }
}
