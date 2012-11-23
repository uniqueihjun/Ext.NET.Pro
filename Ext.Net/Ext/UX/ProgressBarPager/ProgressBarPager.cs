/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;
using System.Drawing;

namespace Ext.Net
{
    [Meta]
    [ToolboxItem(false)]
    [ToolboxBitmap(typeof(ProgressBarPager), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:ProgressBarPager runat=\"server\" />")]
    public partial class ProgressBarPager : Plugin
    {
        /// <summary>
        /// 
        /// </summary>
        public ProgressBarPager()
        {
        }
        
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

                baseList.Add(new ClientScriptItem(typeof(ProgressBarPager), "Ext.Net.Build.Ext.Net.ux.progressbarpager.progressbarpager.js", "/ux/progressbarpager/progressbarpager.js"));

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
                return "Ext.ux.ProgressBarPager";
            }
        }

        /// <summary>
        /// The default progress bar width.  Default is 225.
        /// </summary>
        [ConfigOption("width")]
        [Category("3. ProgressBarPager")]
        [DefaultValue(255)]
        [NotifyParentProperty(true)]
        [Description("The default progress bar width.  Default is 225.")]
        public virtual int ProgBarWidth
        {
            get
            {
                return this.State.Get<int>("ProgBarWidth", 255);
            }
            set
            {
                this.State.Set("ProgBarWidth", value);
            }
        }

        /// <summary>
        /// The text to display while the store is loading.  Default is 'Loading...'
        /// </summary>
        [ConfigOption]
        [Category("3. ProgressBarPager")]
        [Localizable(true)]
        [DefaultValue("Loading...")]
        [NotifyParentProperty(true)]
        [Description("The text to display while the store is loading.  Default is 'Loading...'")]
        public virtual string DefaultText
        {
            get
            {
                return this.State.Get<string>("DefaultText", "Loading...");
            }
            set
            {
                this.State.Set("DefaultText", value);
            }
        }

        //private Fx defaultAnimCfg;

        //// <summary>
        ///// The text to display while the store is loading.  Default is 'Loading...'
        ///// </summary>
        //[ClientConfig(JsonMode.Object)]
        //[Category("3. ProgressBarPager")]
        //[NotifyParentProperty(true)]
        //[Description("The text to display while the store is loading.  Default is 'Loading...'")]
        //[PersistenceMode(PersistenceMode.InnerProperty)]
        //public virtual Fx DefaultAnimCfg
        //{
        //    get
        //    {
        //        return this.State.Get<Fx>("DefaultAnimCfg", null);
        //    }
        //    set
        //    {
        //        this.State.Set("DefaultAnimCfg", value);
        //    }
        //}
    }
}
