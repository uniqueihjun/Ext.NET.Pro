/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class SplitCommand : GridCommand
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SplitCommand() { }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("xtype")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        protected internal override string XType
        {
            get
            {
                return "splitbutton";
            }
        }
    }
}