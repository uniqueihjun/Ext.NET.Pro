/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class Html
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static BuilderFactory X()
        {
            return Ext.Net.X.Builder;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public partial class Extensions
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static BuilderFactory X(this Page self)
        {
            return Ext.Net.X.Builder;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static BuilderFactory X(this UserControl self)
        {
            return Ext.Net.X.Builder;
        }

        /// <new date="2010-01-04" owner="geoff" key="Control">
        /// Added new .ToElement() Extension Method to Control which enables the easy explicit conversion
        /// of Control objects into Ext.Net.Element objects. Once converted into an Element, effect can be run against
        /// the Element, including .Show(), .Hide() and many other Animations. Method chaining default is "true".
        /// </new>
        public static Element ToElement(this Control self)
        {
            return self.ToElement(false);
        }

        /// <new date="2010-01-30" owner="geoff" key="Control">
        /// Added extra chaining parameter to .ToElement() Extension Method. Default is "true".
        /// </new>
        public static Element ToElement(this Control self, bool chaining)
        {
            if (self is AbstractComponent)
            {
                return new Element(self as AbstractComponent, chaining);
            }

            Element el = Element.Fly(self);
            el.Chaining = chaining;

            return el;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static void Update(this Control self)
        {
            if (self is AbstractComponent)
            {
                ((AbstractComponent)self).Render();
                return;
            }

            Control parent = self.Parent;
            int index = parent.Controls.IndexOf(self);

            LiteralControl start = new LiteralControl("<Ext.Net.Direct.Update id=\"{0}\">".FormatWith(self.ClientID));
            LiteralControl end = new LiteralControl("</Ext.Net.Direct.Update>");

            parent.Controls.AddAt(index, start);
            parent.Controls.AddAt(index + 2, end);

            HttpContext.Current.Items["Ext.Net.Direct.Update"] = true;
        }
    }
}