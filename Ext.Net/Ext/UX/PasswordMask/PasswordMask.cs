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
    [ToolboxBitmap(typeof(PasswordMask), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:PasswordMask runat=\"server\" />")]
    [Description("")]
    public partial class PasswordMask : Plugin
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public PasswordMask()
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

                baseList.Add(new ClientScriptItem(typeof(PasswordMask), "Ext.Net.Build.Ext.Net.ux.passwordmask.passwordmask.js", "/ux/passwordmask/passwordmask.js"));

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
                return "Ext.net.PasswordMask";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override string PType
        {
            get
            {
                return "passwordmask";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(2000)]
        [Description("")]
        public virtual int Duration
        {
            get
            {
                return this.State.Get<int>("Duration", 2000);
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
        [ConfigOption]
        [DefaultValue('\u25CF')]
        [Description("")]
        public virtual char ReplacementChar
        {
            get
            {
                return this.State.Get<char>("ReplacementChar", '\u25CF');
            }
            set
            {
                this.State.Set("ReplacementChar", value);
            }
        }
    }
}