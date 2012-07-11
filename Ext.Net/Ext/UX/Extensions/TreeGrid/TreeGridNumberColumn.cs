/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class TreeGridNumberColumn : TreeGridColumn
    {
		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("xtype")]
		[Description("")]
        public string XType
        {
            get
            {
                return "numbercolumn";
            }
        }
        
        /// <summary>
        /// A formatting string as used by Ext.util.Format.number to format a numeric value for this Column (defaults to '0,000.00').
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("6. ListView")]
        [DefaultValue("0,000.00")]
        [Description("A formatting string as used by Ext.util.Format.number to format a numeric value for this Column (defaults to '0,000.00').")]
        public virtual string Format
        {
            get
            {
                object obj = this.ViewState["Format"];
                return (obj == null) ? "0,000.00" : (string)obj;
            }
            set
            {
                this.ViewState["Format"] = value;
            }
        }

    }
}