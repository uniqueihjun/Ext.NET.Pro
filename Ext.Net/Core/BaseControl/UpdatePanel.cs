/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Text;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public partial class BaseControl
    {
        /*  UpdatePanel
            -----------------------------------------------------------------------------------------------*/
        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("")]
        public virtual bool IsInUpdatePanelRefresh
        {
            get
            {
                if (this.MyUpdatePanel != null)
                {
                    return this.ResourceManager.UpdatePanelIDsToRefresh.Contains(this.MyUpdatePanel.UniqueID);
                }

                return false;
            }
        }

        Control myUpdatePanel = null;

		/// <summary>
		/// 
		/// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Description("")]
        public virtual Control MyUpdatePanel
        {
            get
            {
                if (this.myUpdatePanel == null)
                {
                    this.myUpdatePanel = ReflectionUtils.GetTypeOfParent(this, "System.Web.UI.UpdatePanel");
                }

                return this.myUpdatePanel;
            }
        }

    }
}