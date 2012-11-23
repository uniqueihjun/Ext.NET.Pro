/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class Dom : ScriptClass
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static implicit operator Dom(Element element)
        {
            return element.GetDom();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static implicit operator Dom(Control control)
        {
            return control.ToElement().GetDom();
        }


        /*  Ctor
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public Dom(Element element)
        {
            this.element = element;
        }

        private Element element = null;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual Element Element
        {
            get
            {
                return this.element;
            }
        }


        /*  Overrides
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public override string InstanceOf
        {
            get
            {
                return this.Element.InstanceOf + ".dom";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public override string ToScript()
        {
            return "";
        }
    }
}