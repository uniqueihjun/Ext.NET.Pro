/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Globalization;

using Ext.Net.Utilities;

namespace Ext.Net
{
    // REFERENCE: http://msdn2.microsoft.com/en-us/library/ayybcxe5.aspx
    class DoubleArrayConverter : TypeConverter
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return (sourceType == typeof(string));
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value == null)
            {
                return null;
            }

            if (value is string)
            {
                string[] list = ((string)value).Split(',');
                double[] items = new double[list.Length];

                for(int i = 0; i < list.Length; i++)
                {
                    items[i] = Convert.ToDouble(list[i], System.Globalization.CultureInfo.InvariantCulture);
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
            if (destinationType != typeof(string))
            {
                throw base.GetConvertToException(value, destinationType);
            }
            if (value == null)
            {
                return null;
            }

            return ((double[])value).Join();
        }
    }
}