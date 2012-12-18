/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Web.UI;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class SingleItemStateCollection<T> : SingleItemCollection<T>, IStateManager where T : IStateManager
    {
        private bool isTrackingViewState;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void LoadViewState(object state)
        {
            if (state != null && this.Count > 0)
            {
                this[0].LoadViewState(state);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public object SaveViewState()
        {
            return this.Count > 0 ? this[0].SaveViewState() : null;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void TrackViewState()
        {
            this.isTrackingViewState = true;

            if (this.Count > 0)
            {
                this[0].TrackViewState();
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool IsTrackingViewState
        {
            get { return isTrackingViewState; }
        }
    }
}