/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [Description("")]
    public partial class PageProxy : DataProxy
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public PageProxy() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.net.PageProxy";
            }
        }

        private int total;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [DefaultValue(0)]
        [Description("")]
        public int Total
        {
            get
            {
                return this.total;   
            }
            set
            {
                this.total = value;
            }
        }
    }
}
