/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public abstract partial class ScriptClass : IScriptable, IResourceManager
    {
        /*  IScriptable
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public virtual string InstanceOf
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public abstract string ToScript();

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public virtual void Render()
        {
            this.AddScript(this.ToScript());
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public virtual void Call(string name)
        {
            this.Call(name, null);
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public virtual void Call(string name, params object[] args)
        {
            string tpl = this.InstanceOf.IsEmpty() ? "{1}({2});" : "{0}.{1}({2});";
            this.CallTemplate(tpl, name, args);
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public virtual void Set(string name, object value)
        {
            string tpl = this.InstanceOf.IsEmpty() ? "{1}={2};" : "{0}.{1}={2};";
            this.CallTemplate(tpl, name, value);
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("Adds the script to be be called on the client. The script is formatted using the template and args.")]
        public virtual void AddScript(string template, params object[] args)
        {
            this.AddScript(string.Format(template, args));
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public virtual void AddScript(string script)
        {
            if (this.Page != null && this.ResourceManager != null)
            {
                this.ResourceManager.AddScript(script);

                return;
            }

            ResourceManager.AddInstanceScript(script);
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected virtual void CallTemplate(string template, string name, params object[] args)
        {
            string s = this.FormatArgs(args);

            this.AddScript(template, this.InstanceOf, name, s);
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected virtual string FormatCall(string name, params object[] args)
        {
            return "{0}.{1}({2});".FormatWith(this.InstanceOf, name, this.FormatArgs(args));
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected virtual string FormatCallTemplate(string template, string name, params object[] args)
        {
            return template.FormatWith(this.InstanceOf, name, this.FormatArgs(args));
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected virtual string FormatArgs(object[] args)
        {
            StringBuilder sb = new StringBuilder();

            if (args != null && args.Length > 0)
            {
                foreach (object arg in args)
                {
                    if (arg is string)
                    {
                        sb.AppendFormat("{0},", TokenUtils.ParseAndNormalize(arg.ToString(), this.ResourceManager));
                    }
                    else
                    {
                        sb.AppendFormat("{0},", JSON.Serialize(arg));
                    }
                }
            }

            return sb.ToString().LeftOfRightmostOf(',');
        }


        /*  IResourceManager
            -----------------------------------------------------------------------------------------------*/

        private Page page;

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public virtual Page Page
        {
            get
            {
                if (this.page == null && this.ResourceManager != null)
                {
                    this.page = this.ResourceManager.Page;
                }

                return this.page;
            }
        }

        private ResourceManager resourceManager;

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public virtual ResourceManager ResourceManager
        {
            get
            {
                if (this.resourceManager == null)
                {
                    this.resourceManager = ResourceManager.GetInstance();
                }

                return this.resourceManager;
            }
        }
    }
}