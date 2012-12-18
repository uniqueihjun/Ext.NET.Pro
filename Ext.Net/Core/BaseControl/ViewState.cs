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
    public partial class BaseControl
    {
        /*  ViewState
            -----------------------------------------------------------------------------------------------*/

        private ControlState state;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        internal protected ControlState State
        {
            get
            {
                if (this.state == null)
                {
                    this.state = new ControlState(this, base.ViewState);
                }

                return this.state;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public virtual bool HasOwnState(string name)
        {
            return this.state != null && this.state.ViewState[name] != null;
        }
    }
}