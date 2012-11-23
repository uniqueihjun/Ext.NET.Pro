/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public partial class DesktopModule : StateManagedItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DesktopModule() { }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("id")]
        [Category("2. DesktopModule")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string ModuleID
        {
            get
            {
                return (string)this.ViewState["ModuleID"] ?? "";
            }
            set
            {
                this.ViewState["ModuleID"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [Category("2. DesktopModule")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string WindowID
        {
            get
            {
                return (string)this.ViewState["WindowID"] ?? "";
            }
            set
            {
                this.ViewState["WindowID"] = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("windowID")]
        [DefaultValue("")]
		[Description("")]
        protected string WindowProxy
        {
            get
            {
                if (this.WindowID.IsEmpty())
                {
                    return "";
                }
                Control control = ControlUtils.FindControl(this.Owner, this.WindowID, true);

                if (control != null)
                {
                    return control.ClientID;
                }
                
                throw new InvalidOperationException("The DesktopWindow with the ID of '{0}' was not found".FormatWith(this.WindowID));
            }
        }
        
        private MenuItem launcher;

        /// <summary>
        /// 
        /// </summary>
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("")]
        public MenuItem Launcher
        {
            get
            {
                if (this.launcher == null)
                {
                    this.launcher = new MenuItem();
                }

                return this.launcher;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [DefaultValue("")]
        [ConfigOption("launcher",JsonMode.Raw)]
		[Description("")]
        protected string LauncherProxy
        {
            get
            {
                if (this.launcher.Text.IsEmpty())
                {
                    return "";
                }

                return "{".ConcatWith(this.Launcher.ClientID, "_ClientInit}");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("2. DesktopModule")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual bool AutoRun
        {
            get
            {
                object obj = this.ViewState["AutoRun"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["AutoRun"] = value;
            }
        }

    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class DesktopModulesCollection : StateManagedCollection<DesktopModule> { }
}