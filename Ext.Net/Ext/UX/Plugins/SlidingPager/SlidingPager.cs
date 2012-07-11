/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;
using System.Drawing;

namespace Ext.Net
{
    [ToolboxItem(false)]
    [ToolboxBitmap(typeof(SlidingPager), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:SlidingPager runat=\"server\" />")]
    public partial class SlidingPager : Plugin
    {
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

                baseList.Add(new ClientScriptItem(typeof(SlidingPager), "Ext.Net.Build.Ext.Net.ux.plugins.slidingpager.slidingpager.js", "/ux/plugins/slidingpager/slidingpager.js"));

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
                return "Ext.ux.SlidingPager";
            }
        }

        /// <summary>
        /// Override this function to apply custom tip text
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("3. SlidingPager")]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("Override this function to apply custom tip text")]
        public virtual JFunction GetText
        {
            get
            {
                object obj = ViewState["GetText"];
                return (obj == null) ? null : (JFunction)obj;
            }
            set
            {
                this.ViewState["GetText"] = value;
            }
        }
    }
}
