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
using System.Web.UI;
using Coolite.Ext.Web;

namespace Coolite.Ext.UX
{
    public class DateFilter : GridFilter
    {
        [ClientConfig(JsonMode.ToLower)]
        [Category("Config Options")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override FilterType Type
        {
            get 
            { 
                return FilterType.Date;
            }
        }

        [ClientConfig]
        [Category("Config Options")]
        [DefaultValue("Before")]
        [NotifyParentProperty(true)]
        [Description("The text displayed for the 'Before' menu item")]
        public string BeforeText
        {
            get
            {
                object obj = this.ViewState["BeforeText"];
                return obj == null ? "Before" : (string)obj;
            }
            set
            {
                this.ViewState["BeforeText"] = value;
            }
        }

        [ClientConfig]
        [Category("Config Options")]
        [DefaultValue("After")]
        [NotifyParentProperty(true)]
        [Description("The text displayed for the 'After' menu item")]
        public string AfterText
        {
            get
            {
                object obj = this.ViewState["AfterText"];
                return obj == null ? "After" : (string)obj;
            }
            set
            {
                this.ViewState["AfterText"] = value;
            }
        }

        [ClientConfig]
        [Category("Config Options")]
        [DefaultValue("On")]
        [NotifyParentProperty(true)]
        [Description("The text displayed for the 'On' menu item")]
        public string OnText
        {
            get
            {
                object obj = this.ViewState["OnText"];
                return obj == null ? "On" : (string)obj;
            }
            set
            {
                this.ViewState["OnText"] = value;
            }
        }

        private DatePickerOptions pickerOptions;

        [ClientConfig("pickerOpts", JsonMode.Object)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        public DatePickerOptions DatePickerOptions
        {
            get
            {
                if(pickerOptions == null)
                {
                    pickerOptions = new DatePickerOptions();
                }

                return pickerOptions;
            }
        }
    }
}
