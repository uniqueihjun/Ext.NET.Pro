/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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

                baseList.Add(new ClientScriptItem(typeof(SlidingPager), "Ext.Net.Build.Ext.Net.ux.slidingpager.slidingpager.js", "/ux/slidingpager/slidingpager.js"));

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

        private JFunction getTipText;

        /// <summary>
        /// Override this function to apply custom tip text
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("3. SlidingPager")]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("Override this function to apply custom tip text")]
        public virtual JFunction GetTipText
        {
            get
            {
                if (this.getTipText == null)
                {
                    this.getTipText = new JFunction();
                    if (!this.DesignMode)
                    {
                        this.getTipText.Args = new string[] { "thumb" };
                    }
                }

                return this.getTipText;
            }
        }
    }
}
