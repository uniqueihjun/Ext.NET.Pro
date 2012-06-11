/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.HtmlControls;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ControlConverter : StringConverter
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ControlConverter() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            if ((context == null) || (context.Container == null))
            {
                return null;
            }

            object[] controls = this.GetControls(context.Container);

            if (controls != null)
            {
                return new TypeConverter.StandardValuesCollection(controls);
            }

            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="container"></param>
        /// <returns></returns>
        protected virtual object[] GetControls(IContainer container)
        {
            ComponentCollection components = container.Components;
            ArrayList controls = new ArrayList();

            foreach (IComponent component in components)
            {
                if (component is System.Web.UI.Control)
                {
                    Control c = (Control)component;

                    if (c.ID.IsNotEmpty() && this.CheckType(c))
                    {
                        controls.Add(string.Copy(c.ID));
                    }
                }
            }

            controls.Sort(Comparer.Default);

            return controls.ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        protected virtual bool CheckType(Control c)
        {
            return (!this.Types.Contains(c.GetType()));
        }

        private List<Type> types;
        private List<Type> Types
        {
            get
            {
                if (this.types == null)
                {
                    this.types = new List<Type>();
                    this.types.Add(typeof(HtmlForm));
                    this.types.Add(typeof(ResourceManager));
                    this.types.Add(typeof(HtmlInputHidden));
                    this.types.Add(typeof(Hidden));
                    this.types.Add(typeof(Page));
                }

                return this.types;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return false;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }
    }
}