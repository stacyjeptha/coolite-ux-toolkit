/******** 
* Copyright (c) 2009 Coolite Inc.

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

* @version:	    0.8.0
* @author:	    Coolite Inc. http://www.coolite.com/
* @date:		2008-05-25
* @copyright:   Copyright (c) 2006-2009, Coolite Inc, or as noted within each 
* 			    applicable file LICENSE.txt file
* @license:	    MIT
* @website:	    http://www.coolite.com/
********/

using System.ComponentModel;
using System.Web.UI;
using Coolite.Ext.Web;
using System.Drawing;

namespace Coolite.Ext.UX
{
    /** It creates a new input text mask.
     * @class InputTextMask is a plugin for Ext.form.TextField, used to add an input mask to the field.
     * Mask Individual Character Usage:
     * 
     * 9 - designates only numeric values
     * L - designates only uppercase letter values
     * l - designates only lowercase letter values
     * A - designates only alphanumeric values
     * X - denotes that a custom client script regular expression is specified
     *
     * All other characters are assumed to be "special" characters used to mask the input component.
     * Example 1:
     *    (999)999-9999 only numeric values can be entered where the the character
     *    position value is 9. Parenthesis and dash are non-editable/mask characters.
     * Example 2:
     *    99L-ll-X[^A-C]X only numeric values for the first two characters,
     *    uppercase values for the third character, lowercase letters for the
     *    fifth/sixth characters, and the last character X[^A-C]X together counts
     *    as the eighth character regular expression that would allow all characters
     *    but "A", "B", and "C". Dashes outside the regular expression are non-editable/mask characters.
    */

    [InstanceOf(ClassName = "Ext.ux.netbox.InputTextMask")]
    [ClientScript(Type = typeof(InputTextMask), WebResource = "Coolite.Ext.UX.Plugins.InputTextMask.resources.InputTextMask.js")]
    [ToolboxBitmap(typeof(Coolite.Ext.UX.InputTextMask), "Build.Resources.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:InputTextMask runat=\"server\" />")]
    [Description("InputTextMask plugin used for mask/regexp operations")]
    public class InputTextMask : Plugin
    {
        [ClientConfig]
        [Category("Config Options")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The InputTextMask")]
        public string Mask
        {
            get
            {
                object obj = this.ViewState["Mask"];
                return obj == null ? "" : (string)obj;
            }
            set
            {
                this.ViewState["Mask"] = value;
            }
        }

        [ClientConfig]
        [Category("Config Options")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("True to clear the mask when the field blurs and the text is invalid. Optional, default is true")]
        public bool ClearWhenInvalid
        {
            get
            {
                object obj = this.ViewState["ClearWhenInvalid"];
                return obj == null ? true : (bool)obj;
            }
            set
            {
                this.ViewState["ClearWhenInvalid"] = value;
            }
        }
    }
}
