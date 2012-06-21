/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class TextBoxConverter : StringConverter
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public TextBoxConverter() { }

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

        private object[] GetControls(IContainer container)
        {
            ComponentCollection components = container.Components;
            ArrayList controls = new ArrayList();
            foreach (IComponent component in components)
            {
                if (component is TextBox && !component.GetType().Equals(typeof(TextField)))
                {
                    Control c = (Control)component;
                    if (c.ID.IsNotEmpty())
                    {
                        controls.Add(string.Copy(c.ID));
                    }
                }
            }
            controls.Sort(Comparer.Default);
            controls.Insert(0, "Default");

            return controls.ToArray();
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