/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public partial class GroupImageCommand : ImageCommandBase
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public GroupImageCommand() { }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual bool RightAlign
        {
            get
            {
                return this.State.Get<bool>("RightAlign", false);
            }
            set
            {
                this.State.Set("RightAlign", value);
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class GroupImageCommandCollection : BaseItemCollection<GroupImageCommand> { }
}