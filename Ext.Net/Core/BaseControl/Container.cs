/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
        /*  Container
            -----------------------------------------------------------------------------------------------*/

        private bool cancelRenderToParameter;

        internal bool CancelRenderToParameter
        {
            get
            {
                return this.cancelRenderToParameter;
            }
            set
            {
                this.cancelRenderToParameter = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected virtual bool RemoveContainer
        {
            get
            {
                return this.TopDynamicControl;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected virtual ContentContainer CreateContainer()
        {
            return new ContentContainer();
        }
    }
}