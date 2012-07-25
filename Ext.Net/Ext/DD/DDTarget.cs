/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// A DragDrop implementation that does not move, but can be a drop target. You would get the same result by simply omitting implementation for the event callbacks, but this way we reduce the processing cost of the event listener and the callbacks.
    /// </summary>
    [Meta]
    public partial class DDTarget : DragDrop
    {
        /// <summary>
        /// 
        /// </summary>
        public DDTarget()
        {
        }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.dd.DDTarget";
            }
        }
    }
}