/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public abstract partial class ToolbarItem : BoxComponentBase, IToolbarItem
    {
        private ToolbarBase toolbar;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ToolbarBase Toolbar
        {
            get
            {
                if (this.toolbar == null)
                {
                    this.toolbar = (ToolbarBase)ReflectionUtils.GetTypeOfParent(this, typeof(ToolbarBase));
                }
                
                return this.toolbar;
            }
        }

        /*  Public Methods
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Disable this component.
        /// </summary>
        [Meta]
        [Description("Disable this component.")]
        public virtual void Disable()
        {
            this.Call("disable");
        }

        /// <summary>
        /// Enable this component.
        /// </summary>
        [Meta]
        [Description("Enable this component.")]
        public virtual void Enable()
        {
            this.Call("enable");
        }
    }
}