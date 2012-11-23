/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class JRawValue
    {
        /// <summary>
		/// 
		/// </summary>
		[Description("")]
        public JRawValue() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public JRawValue(object value)
        {
            this.Value = value;
        }

        private object value;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual object Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string ToString()
        {
            if (this.Value is string)
            {
                return JSON.Serialize(this.Value).Chop("\"").Replace("\\\"", "\"");
            }

            return JSON.Serialize(this.Value).Chop("\"");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static JRawValue From(object value)
        {
            return new JRawValue(value);
        }

        public static JRawValue Null
        {
            get
            {
                return new JRawValue("null");
            }
        }
    }
}