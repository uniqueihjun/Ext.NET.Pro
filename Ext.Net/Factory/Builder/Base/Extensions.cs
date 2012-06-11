/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static Element ToElement(this Control self)
        {
            return self.ToElement(false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="chaining"></param>
        /// <returns></returns>
        public static Element ToElement(this Control self, bool chaining)
        {
            if (self is Component)
            {
                return new Element(self as Component, chaining);
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
            if (self is Component)
            {
                ((Component)self).Render();
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