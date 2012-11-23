/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace Ext.Net
{
    // REFERENCE: http://msdn2.microsoft.com/en-us/library/ayybcxe5.aspx
    class ObjectArrayConverter : TypeConverter
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
                return true;

            return base.CanConvertFrom(context, sourceType);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value == null)
                return null;

            if (value is string)
            {
                string[] list = ((string)value).Split(',');
                object[] items = new object[list.Length];

                for(int i = 0; i < list.Length; i++)
                {
                    items[i] = (object)list[i];
                }

                return items;
            }

            return base.ConvertFrom(context, culture, value);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value is string[] && destinationType == typeof(string))
                return string.Join(",", ((string[])value));

            return base.ConvertTo(context, culture, value, destinationType);
        }

    }
}