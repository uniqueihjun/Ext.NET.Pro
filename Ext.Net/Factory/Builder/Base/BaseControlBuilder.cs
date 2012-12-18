/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Web.UI;
using System.ComponentModel;
using System.Web;
using System;

namespace Ext.Net
{
    /*  Abstract
        -----------------------------------------------------------------------------------------------*/
    public abstract partial class BaseControl
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public partial class Builder<TComponent, TBuilder>
            : ControlBuilder<TComponent, TBuilder>, IXControlBuilder<TComponent>
#if MVC
            , IHtmlString
#endif
            where TComponent : BaseControl
            where TBuilder : BaseControl.Builder<TComponent, TBuilder>
        {
            /// <summary>
            /// 
            /// </summary>
            [Description("")]
            public Builder(TComponent control) : base(control) { }


            /*  Properties
                -----------------------------------------------------------------------------------------------*/

            /// <summary>
            /// An itemId can be used as an alternative way to get a reference to a component when no object reference is available.
            /// </summary>
            /// <param name="itemId">The ItemID to assign to the Component.</param>
            /// <returns>ControlBuilder</returns>
            public virtual TBuilder ItemID(string itemId)
            {
                this.ToComponent().ItemID = itemId;
                return this as TBuilder;
            }

            public virtual TBuilder RegisterAllResources(bool registerAllResources)
            {
                this.ToComponent().RegisterAllResources = registerAllResources;
                return this as TBuilder;
            }

            public virtual TBuilder AutoDataBind(bool autoDataBind)
            {
                this.ToComponent().AutoDataBind = autoDataBind;
                return this as TBuilder;
            }

            public virtual TBuilder IDMode(IDMode idMode)
            {
                this.ToComponent().IDMode = idMode;
                return this as TBuilder;
            }

            public virtual TBuilder LazyMode(LazyMode lazyMode)
            {
                this.ToComponent().LazyMode = lazyMode;
                return this as TBuilder;
            }

            public virtual TBuilder Namespace(string ns)
            {
                this.ToComponent().Namespace = ns;
                return this as TBuilder;
            }

            /*  Methods
                -----------------------------------------------------------------------------------------------*/

            /// <summary>
            /// 
            /// </summary>
            [Description("")]
            public virtual string ToScript()
            {
                return this.ToComponent().ToScript();
            }

            /// <summary>
            /// 
            /// </summary>
            [Description("")]
            public virtual void Render()
            {
                this.ToComponent().Render();
            }

            /// <summary>
            /// 
            /// </summary>
            [Description("")]
            public override void Render(Control control)
            {
                this.ToComponent().Render(control);
            }

            /// <summary>
            /// 
            /// </summary>
            [Description("")]
            public virtual void Render(string element, RenderMode mode)
            {
                this.ToComponent().Render(element, mode);
            }

            /// <summary>
            /// 
            /// </summary>
            [Description("")]
            public virtual void Render(Control control, RenderMode mode)
            {
                this.ToComponent().Render(control, mode);
            }

            /// <summary>
            /// 
            /// </summary>
            [Description("")]
            public virtual void Render(string element, RenderMode mode, bool selfRendering)
            {
                this.ToComponent().Render(element, mode, selfRendering);
            }

            /// <summary>
            /// 
            /// </summary>
            [Description("")]
            public virtual void Render(Control control, RenderMode mode, bool selfRendering)
            {
                this.ToComponent().Render(control, mode, selfRendering);
            }

            /// <summary>
            /// 
            /// </summary>
            [Description("")]
            public virtual void AddTo(string element)
            {
                this.ToComponent().Render(element, RenderMode.AddTo);
            }

            /// <summary>
            /// 
            /// </summary>
            [Description("")]
            public virtual void AddTo(Control control)
            {
                this.ToComponent().Render(control, RenderMode.AddTo);
            }

            /// <summary>
            /// 
            /// </summary>
            [Description("")]
            public virtual void AddTo(string element, bool selfRendering)
            {
                this.ToComponent().Render(element, RenderMode.AddTo, selfRendering);
            }

            /// <summary>
            /// 
            /// </summary>
            [Description("")]
            public virtual void AddTo(Control control, bool selfRendering)
            {
                this.ToComponent().Render(control, RenderMode.AddTo, selfRendering);
            }

            /// <summary>
            /// Adds the script to be be called on the client.
            /// </summary>
            /// <param name="script">The script</param>
            [Description("Adds the script to be be called on the client.")]
            public virtual TBuilder AddScript(string script)
            {
                this.ToComponent().AddScript(script);
                return this as TBuilder;
            }

            /// <summary>
            /// Adds the script to be be called on the client. The script is formatted using the template and args.
            /// </summary>
            /// <param name="template">The script string template</param>
            /// <param name="args">The arguments to use with the template</param>
            [Description("Adds the script to be be called on the client. The script is formatted using the template and args.")]
            public virtual TBuilder AddScript(string template, params object[] args)
            {
                this.ToComponent().AddScript(template, args);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="name"></param>
            /// <param name="value"></param>
            /// <returns></returns>
            public virtual TBuilder Set(string name, object value)
            {
                this.ToComponent().Set(ScriptPosition.Auto, name, value);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="position"></param>
            /// <param name="name"></param>
            /// <param name="value"></param>
            /// <returns></returns>
            public virtual TBuilder Set(ScriptPosition position, string name, object value)
            {
                this.ToComponent().CallTemplate(position, BaseControl.SETEMPLATE, name, value);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="name"></param>
            /// <returns></returns>
            public virtual TBuilder Call(string name)
            {
                this.ToComponent().Call(name, null);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="name"></param>
            /// <param name="args"></param>
            /// <returns></returns>
            public virtual TBuilder Call(string name, params object[] args)
            {
                this.ToComponent().Call(ScriptPosition.Auto, name, args);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="mode"></param>
            /// <param name="name"></param>
            /// <param name="args"></param>
            /// <returns></returns>
            public virtual TBuilder Call(ScriptPosition mode, string name, params object[] args)
            {
                this.ToComponent().CallTemplate(mode, BaseControl.CALLTEMPLATE, name, args);
                return this as TBuilder;
            }

            public virtual TBuilder Control(Action<TComponent> action)
            {
                action(this.ToComponent());
                return this as TBuilder;
            }
#if MVC
            /// <summary>
            /// 
            /// </summary>
            public virtual TBuilder ControlFor(string controlFor)
            {
                this.ToComponent().ControlFor = controlFor;
                return this as TBuilder;
            } 

            /// <summary>
            /// 
            /// </summary>
            public virtual TBuilder ControlFor(string controlFor, bool setID)
            {
                this.ToComponent().IDFromControlFor = setID;
                this.ToComponent().ControlFor = controlFor;
                return this as TBuilder;
            }       

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public string ToHtmlString()
            {
                return this.ToComponent().SelfRender();
            }
#endif            
        }
    }
}