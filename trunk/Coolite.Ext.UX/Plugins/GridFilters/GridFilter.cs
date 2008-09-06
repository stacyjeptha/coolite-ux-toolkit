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
using Coolite.Ext.Web;

namespace Coolite.Ext.UX
{
    public abstract class GridFilter : StateManagedItem
    {
        [ClientConfig]
        [Category("Config Options")]
        [DefaultValue("")]
        [Description("The Store data index of the field this filter represents. The dataIndex does not actually have to exist in the store.")]
        public virtual string DataIndex
        {
            get
            {
                object obj = ViewState["DataIndex"];
                return (obj == null) ? "" : (string)obj;
            }
            set
            {
                this.ViewState["DataIndex"] = value;
            }
        }

        public abstract FilterType Type
        {
            get;
        }
    }

    public class GridFilterCollection : StateManagedCollection<GridFilter>
    {
    }

    public enum FilterType
    {
        Boolean,
        Date,
        List,
        Numeric,
        String
    }
}
