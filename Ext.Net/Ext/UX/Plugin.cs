/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web.UI.WebControls;
using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// Base Class for all AbstractComponent Plugins. Add plugin to a AbstractComponent using the .Plugins property or &lt;Plugins> node.
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [Description("Base Class for all AbstractComponent Plugins. Add plugin to a AbstractComponent using the .Plugins property or <Plugins> node.")]
    public abstract partial class Plugin : LazyObservable, INoneContentable, IVirtual 
    {
        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual bool Singleton
        {
            get
            {
                return this.State.Get<bool>("Singleton", false);
            }
            set
            {
                this.State.Set("Singleton", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string PluginId
        {
            get
            {
                return this.State.Get<string>("PluginId", "");
            }
            set
            {
                this.State.Set("PluginId", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [ConfigOption("ptype")]
        [DefaultValue("")]
        [Description("")]
        public virtual string PType
        {
            get
            {
                return "";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual Type RequiredOwnerType
        {
            get
            {
                return typeof(BaseControl);
            }
        }

        private AbstractComponent pluginOwner;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected AbstractComponent PluginOwner
        {
            get
            {
                return this.pluginOwner;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected internal virtual void PluginAdded()
        {
            this.pluginOwner = this.ParentComponent;
            if (!this.RequiredOwnerType.IsAssignableFrom(this.pluginOwner.GetType()))
            {
                throw new Exception(this.GetType().Name + " plugin requires " + this.RequiredOwnerType.Name);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected internal virtual void PluginRemoved()
        {
        }
    }
}