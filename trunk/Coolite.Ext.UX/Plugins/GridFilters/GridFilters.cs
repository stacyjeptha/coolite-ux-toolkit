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
    [InstanceOf("Ext.grid.GridFilters")]
    [ClientScript(Type = typeof(GridFilters), WebResource = "Coolite.Ext.UX.Plugins.GridFilters.resources.GridFilters.js")]
    [ClientStyle(Type = typeof(GridFilters), WebResource = "Coolite.Ext.UX.Plugins.GridFilters.resources.GridFilters.css")]
    [ToolboxBitmap(typeof(Coolite.Ext.UX.GridFilters), "Plugins.GridFilters.GridFilters.bmp")]
    [ToolboxData("<{0}:GridFilters runat=\"server\" />")]
    [Description("GridFilters plugin used for filter by columns")]
    public class GridFilters : Plugin
    {
        [ClientConfig]
        [Category("Config Options")]
        [DefaultValue(500)]
        [NotifyParentProperty(true)]
        [Description("Number of milisecond to defer store updates since the last filter change.")]
        public int UpdateBuffer
        {
            get
            {
                object obj = this.ViewState["UpdateBuffer"];
                return obj == null ? 500 : (int)obj;
            }
            set
            {
                this.ViewState["UpdateBuffer"] = value;
            }
        }

        [ClientConfig]
        [Category("Config Options")]
        [DefaultValue("gridfilters")]
        [NotifyParentProperty(true)]
        [Description("The url parameter prefix for the filters.")]
        public string ParamPrefix
        {
            get
            {
                object obj = this.ViewState["ParamPrefix"];
                return obj == null ? "gridfilters" : (string)obj;
            }
            set
            {
                this.ViewState["ParamPrefix"] = value;
            }
        }

        [ClientConfig]
        [Category("Config Options")]
        [DefaultValue("ux-filtered-column")]
        [NotifyParentProperty(true)]
        [Description("The css class to be applied to column headers that active filters. Defaults to 'ux-filterd-column'.")]
        public string FilterCls
        {
            get
            {
                object obj = this.ViewState["FilterCls"];
                return obj == null ? "ux-filtered-column" : (string)obj;
            }
            set
            {
                this.ViewState["FilterCls"] = value;
            }
        }

        [ClientConfig]
        [Category("Config Options")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("True to use Ext.data.Store filter functions instead of server side filtering.")]
        public bool Local
        {
            get
            {
                object obj = this.ViewState["Local"];
                return obj == null ? false : (bool)obj;
            }
            set
            {
                this.ViewState["Local"] = value;
            }
        }

        [ClientConfig]
        [Category("Config Options")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("True to automagicly reload the datasource when a filter change happens.")]
        public bool AutoReload
        {
            get
            {
                object obj = this.ViewState["AutoReload"];
                return obj == null ? true : (bool)obj;
            }
            set
            {
                this.ViewState["AutoReload"] = value;
            }
        }

        [ClientConfig]
        [Category("Config Options")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("True to show the filter menus.")]
        public bool ShowMenu
        {
            get
            {
                object obj = this.ViewState["ShowMenu"];
                return obj == null ? true : (bool)obj;
            }
            set
            {
                this.ViewState["ShowMenu"] = value;
            }
        }

        [ClientConfig]
        [Category("Config Options")]
        [DefaultValue("Filters")]
        [NotifyParentProperty(true)]
        [Description("The text displayed for the 'Filters' menu item.")]
        public string FiltersText
        {
            get
            {
                object obj = this.ViewState["FiltersText"];
                return obj == null ? "Filters" : (string)obj;
            }
            set
            {
                this.ViewState["FiltersText"] = value;
            }
        }

        private GridFilterCollection filters;

        [ClientConfig("filters", JsonMode.AlwaysArray)]
        [Category("Config Options")]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public virtual GridFilterCollection Filters
        {
            get
            {
                if (this.filters == null)
                {
                    this.filters = new GridFilterCollection();
                }
                return this.filters;
            }
        }
    }
}
