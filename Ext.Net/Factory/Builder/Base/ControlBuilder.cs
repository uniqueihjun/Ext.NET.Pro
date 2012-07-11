/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /*  Abstract
        -----------------------------------------------------------------------------------------------*/

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TComponent"></typeparam>
    /// <typeparam name="TBuilder"></typeparam>
    public partial class ControlBuilder<TComponent, TBuilder> 
        : IControlBuilder<TComponent>
        where TComponent : Control
        where TBuilder : ControlBuilder<TComponent, TBuilder>
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ControlBuilder(TComponent control)
        {
            this.control = control;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected TComponent control;

        //  Hat Tip to James Newton King
        //  REFERENCE: http://james.newtonking.com/archive/2009/07/28/implicit-conversions-and-linq-to-json.aspx
        /// <summary>
        /// Implicit conversion of a TBuilder object directly into a TComponent. 
        /// </summary>
        public static implicit operator TComponent(ControlBuilder<TComponent, TBuilder> builder)
        {
            return builder.control as TComponent;
        }


        /*  Properties
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Identifier assigned to the server control.
        /// </summary>
        /// <param name="id">The id to assign to the server control.</param>
        /// <returns>ControlBuilder</returns>
        public virtual TBuilder ID(string id)
        {
            this.ToComponent().ID = id;
            return this as TBuilder;
        }


        /*  Methods
            -----------------------------------------------------------------------------------------------*/


        /// <summary>
        /// Get the instance of the underlying Control.
        /// </summary>
        /// <returns>Control</returns>
        public virtual TComponent ToComponent()
        {
            return this.control;
        }

        /// <summary>
        /// Render the Control.
        /// </summary>
        /// <param name="control">A Control in which to render this Builder into.</param>
        public virtual void Render(Control control)
        {
            control.Controls.Add(this.ToComponent());
        }
    }


    /*  Concrete
        -----------------------------------------------------------------------------------------------*/

    /// <summary>
    /// 
    /// </summary>
    public partial class ControlBuilder : ControlBuilder<Control, ControlBuilder>
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ControlBuilder(Control control) : base(control) { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static implicit operator ControlBuilder(Control control)
        {
            return control.ToBuilder();
        }
    }


    /*  Extensions
        -----------------------------------------------------------------------------------------------*/

    public static partial class Extensions
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static ControlBuilder ToBuilder(this Control instance)
        {
            return new ControlBuilder(instance);
        }
    }
}
