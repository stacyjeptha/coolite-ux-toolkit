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

using System;
using System.Reflection;
using System.Text;
using Coolite.Ext.Web;
using Coolite.Utilities;
using Newtonsoft.Json;
using JsonReader=Newtonsoft.Json.JsonReader;

namespace Coolite.Ext.UX
{
    public class MapPropertiesJsonConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value)
        {
            if (value != null)
            {
                bool isControls = value is MapControls;
                PropertyInfo[] properties = value.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                StringBuilder sb = new StringBuilder();
                foreach (PropertyInfo property in properties)
                {
                    ClientConfigAttribute attr = ClientConfig.GetClientConfigAttribute(property);

                    if (attr != null && property.PropertyType == typeof(bool))
                    {
                        object prValue = property.GetValue(value, null);
                        object defaultValue = ReflectionUtils.GetDefaultValue(property);
                        if((bool)prValue)
                        {
                            if(!isControls)
                            {
                                if(!(bool)defaultValue)
                                {
                                    sb.Append(string.Concat("'enable", property.Name, "',")); 
                                }
                            }
                            else
                            {
                                sb.Append(string.Concat("'", property.Name,"',"));
                            }
                        }
                        else
                        {
                            if (!isControls)
                            {
                                if ((bool)defaultValue)
                                {
                                    sb.Append(string.Concat("'disable", property.Name, "',"));
                                }
                            }
                        }
                    }
                }

                if(sb.Length > 0)
                {
                    sb.Remove(sb.Length - 1, 1);
                    writer.WriteStartArray();
                    writer.WriteRaw(sb.ToString());
                    writer.WriteEndArray();
                    return;
                }
            }
            writer.WriteRaw("[]");
        }

        public override object ReadJson(JsonReader reader, Type objectType)
        {
            throw new System.NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(MapConfiguration).IsAssignableFrom(objectType) || typeof(MapControls).IsAssignableFrom(objectType);
        }
    }
}
