/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    [ToolboxItem(false)]
    [ToolboxBitmap(typeof(DataViewAnimated), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:DataViewAnimated runat=\"server\" />")]
    [Description("")]
    public partial class DataViewAnimated : Plugin
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public DataViewAnimated() { }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 1;

                baseList.Add(new ClientScriptItem(typeof(DataViewDragSelector), "Ext.Net.Build.Ext.Net.ux.view.Animated.js", "/ux/view/Animated.js"));

                return baseList;
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
                return "Ext.ux.DataView.Animated";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override System.Type RequiredOwnerType
        {
            get
            {
                return typeof(AbstractDataView);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(750)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual int Duration
        {
            get
            {
                return this.State.Get<int>("Duration", 750);
            }
            set
            {
                this.State.Set("Duration", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("idProperty")]
        [DefaultValue("id")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string IDProperty
        {
            get
            {
                return this.State.Get<string>("IDProperty", "id");
            }
            set
            {
                this.State.Set("IDProperty", value);
            }
        }
    }
}