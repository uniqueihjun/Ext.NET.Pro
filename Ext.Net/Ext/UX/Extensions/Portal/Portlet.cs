/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [ToolboxBitmap(typeof(Portlet), "Build.ToolboxIcons.Portlet.bmp")]
    [ToolboxData("<{0}:Portlet runat=\"server\" Title=\"Portlet\" />")]
    [Description("")]
    public partial class Portlet : Panel
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Portlet() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "portlet";
            }
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
                return "Ext.ux.Portlet";
            }
        }
        
        /// <summary>
        /// True to make the panel collapsible and have the expand/collapse toggle button automatically rendered into the header tool button area, false to keep the panel statically sized with no button (defaults to false).
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. Portlet")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("True to make the panel collapsible and have the expand/collapse toggle button automatically rendered into the header tool button area, false to keep the panel statically sized with no button (defaults to false).")]
        public override bool Collapsible
        {
            get
            {
                object obj = this.ViewState["Collapsible"];
                return (obj == null) ? true : (bool)obj;
            }
            set
            {
                this.ViewState["Collapsible"] = value;
            }
        }

        /// <summary>
        /// True to enable dragging of this Panel (defaults to false).
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. Portlet")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("True to enable dragging of this Panel (defaults to false).")]
        public override bool Draggable
        {
            get
            {
                object obj = this.ViewState["Draggable"];
                return (obj == null) ? true : (bool)obj;
            }
            set
            {
                this.ViewState["Draggable"] = value;
            }
        }
    }
}