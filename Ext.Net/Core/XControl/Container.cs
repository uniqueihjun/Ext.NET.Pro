/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI.HtmlControls;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public partial class XControl
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
        protected virtual HtmlGenericControl CreateHtmlContainer()
        {
            return new HtmlGenericControl((this.DesignMode) ? "div" : "div:body");
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected virtual HtmlGenericControl CreateContainer()
        {
            return new HtmlGenericControl((this.DesignMode) ? "div" : "div:body");
        }
    }
}