/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    [ToolboxBitmap(typeof(PortalColumn), "Build.ToolboxIcons.PortalColumn.bmp")]
    [ToolboxData("<{0}:PortalColumn runat=\"server\" StyleSpec=\"padding:10px 0 10px 10px\"><Items><{0}:AnchorLayout ID=\"AnchorLayout1\" runat=\"server\"><{0}:Anchor Horizontal=\"100%\"><{0}:Portlet Title=\"Portlet\" runat=\"server\" /></{0}:Anchor></{0}:AnchorLayout></Items></{0}:PortalColumn>")]
    [Description("")]
    public partial class PortalColumn : Panel
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public PortalColumn() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "portalcolumn";
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
                return "Ext.app.PortalColumn";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string DefaultLayout
        {
            get
            {
                return "anchor";
            }
        }

        /// <summary>
        /// The default xtype of child Components to create in this Container when a child item is specified as a raw configuration object, rather than as an instantiated AbstractComponent. Defaults to 'panel'.
        /// </summary>        
        [ConfigOption]
        [Category("4. AbstractContainer")]
        [DefaultValue("portlet")]
        [NotifyParentProperty(true)]
        [Description("The default xtype of child Components to create in this Container when a child item is specified as a raw configuration object, rather than as an instantiated AbstractComponent. Defaults to 'panel'.")]
        public override string DefaultType
        {
            get
            {
                return this.State.Get<string>("DefaultType", "portlet");
            }
            set
            {
                this.State.Set("DefaultType", value);
            }
        }

        /// <summary>
        /// True to use height:'auto', false to use fixed height (defaults to false).
        /// </summary>
        [ConfigOption]
        [Category("3. AbstractComponent")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("True to use height:'auto', false to use fixed height (defaults to false).")]
        public override bool AutoHeight
        {
            get
            {
                return this.State.Get<bool>("AutoHeight", true);
            }
            set
            {
                this.State.Set("AutoHeight", value);
            }
        }
    }
}