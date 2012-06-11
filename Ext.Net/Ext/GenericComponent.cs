/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [ToolboxItem(false)]
    [ToolboxData("<{0}:GenericComponent runat=\"server\" />")]
    [Description("A generic AbstractComponent.")]
    public partial class GenericComponent<T> : ComponentBase where T : ComponentBase, new()
    {
        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string XType
        {
            get
            {
                return this.GenericXType ?? "";
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
                return this.GenericInstanceOf ?? "";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [DefaultValue(null)]
        public virtual string GenericXType
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [DefaultValue(null)]
        [Description("")]
        public virtual string GenericInstanceOf
        {
            get;
            set;
        }

        private T component;

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.UnrollObject)]
        [DefaultValue(null)]
        [Description("")]
        public virtual T Component
        {
            get
            {
                if (this.component == null)
                {
                    this.component = new T();
                    this.component.ID = this.ID;
                    this.component.IsProxy = true;
                    this.component.PreventRenderTo = true;
                }

                return this.component;
            }
        }
    }
}