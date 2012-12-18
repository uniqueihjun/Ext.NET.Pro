/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    [ToolboxBitmap(typeof(DataViewLabelEditor), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:DataViewLabelEditor runat=\"server\" />")]
    [Description("")]
    public partial class DataViewLabelEditor : Plugin
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public DataViewLabelEditor() { }

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

                baseList.Add(new ClientScriptItem(typeof(DataViewLabelEditor), "Ext.Net.Build.Ext.Net.ux.view.LabelEditor.js", "/ux/view/LabelEditor.js"));

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
                return "Ext.ux.DataView.LabelEditor";
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
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string DataIndex
        {
            get
            {
                return this.State.Get<string>("DataIndex", "");
            }
            set
            {
                this.State.Set("DataIndex", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("x-editable")]
        public virtual string LabelSelector
        {
            get
            {
                return this.State.Get<string>("LabelSelector", "x-editable");
            }
            set
            {
                this.State.Set("LabelSelector", value);
            }
        }
    }
}