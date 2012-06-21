/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Globalization;

namespace Ext.Net
{
    // REFERENCE: http://msdn2.microsoft.com/en-us/library/ayybcxe5.aspx
    /// <summary>
    /// 
    /// </summary>
    [ToolboxItem(false)]
    [Description("")]
    public partial class GenericConverter : ExpandableObjectConverter
    {
        // Overrides the ConvertTo method of TypeConverter.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <param name="destinationType"></param>
        /// <returns></returns>
        [Description("")]
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                return "";
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}