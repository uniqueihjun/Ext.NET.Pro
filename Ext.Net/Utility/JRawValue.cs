/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using Ext.Net.Utilities;
using System.ComponentModel;

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
    }
}