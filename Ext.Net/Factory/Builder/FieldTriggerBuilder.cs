/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FieldTrigger
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseItem.Builder<FieldTrigger, FieldTrigger.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new FieldTrigger()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(FieldTrigger component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(FieldTrigger.Config config) : base(new FieldTrigger(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(FieldTrigger component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// A trigger tag
			/// </summary>
            public virtual FieldTrigger.Builder Tag(string tag)
            {
                this.ToComponent().Tag = tag;
                return this as FieldTrigger.Builder;
            }
             
 			/// <summary>
			/// True to hide the trigger element and display only the base text field (defaults to false).
			/// </summary>
            public virtual FieldTrigger.Builder HideTrigger(bool hideTrigger)
            {
                this.ToComponent().HideTrigger = hideTrigger;
                return this as FieldTrigger.Builder;
            }
             
 			/// <summary>
			/// A CSS class to apply to the trigger.
			/// </summary>
            public virtual FieldTrigger.Builder TriggerCls(string triggerCls)
            {
                this.ToComponent().TriggerCls = triggerCls;
                return this as FieldTrigger.Builder;
            }
             
 			/// <summary>
			/// The icon to use in the trigger. See also, IconCls to set an icon with a custom Css class.
			/// </summary>
            public virtual FieldTrigger.Builder Icon(TriggerIcon icon)
            {
                this.ToComponent().Icon = icon;
                return this as FieldTrigger.Builder;
            }
             
 			/// <summary>
			/// A css class which sets a background image to be used as the icon for this button.
			/// </summary>
            public virtual FieldTrigger.Builder IconCls(string iconCls)
            {
                this.ToComponent().IconCls = iconCls;
                return this as FieldTrigger.Builder;
            }
             
 			/// <summary>
			/// Quick tip.
			/// </summary>
            public virtual FieldTrigger.Builder Qtip(string qtip)
            {
                this.ToComponent().Qtip = qtip;
                return this as FieldTrigger.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public FieldTrigger.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.FieldTrigger(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public FieldTrigger.Builder FieldTrigger()
        {
            return this.FieldTrigger(new FieldTrigger());
        }

        /// <summary>
        /// 
        /// </summary>
        public FieldTrigger.Builder FieldTrigger(FieldTrigger component)
        {
            return new FieldTrigger.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public FieldTrigger.Builder FieldTrigger(FieldTrigger.Config config)
        {
            return new FieldTrigger.Builder(new FieldTrigger(config));
        }
    }
}