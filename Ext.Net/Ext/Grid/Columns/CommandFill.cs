/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    [Description("")]
    public partial class CommandFill : GridCommandBase
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public CommandFill() { }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("xtype")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        protected internal virtual string XType
        {
            get
            {
                return "tbfill";
            }
        }
    }
}