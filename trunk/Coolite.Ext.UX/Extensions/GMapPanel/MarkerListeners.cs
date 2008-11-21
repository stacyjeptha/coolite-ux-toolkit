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
    public class MarkerListeners : StateManagedItem
    {
        [ClientConfig(JsonMode.Raw)]
        [Category("Config Options")]
        [DefaultValue(null)]
        [Description("Fires when this marker is clicked.")]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public virtual JFunction Click
        {
            get
            {
                object obj = ViewState["Click"];
                return (obj == null) ? null : (JFunction)obj;
            }
            set
            {
                this.ViewState["Click"] = value;
            }
        }
    }
}
