/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class ShortcutDefaults
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseItem.Builder<ShortcutDefaults, ShortcutDefaults.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ShortcutDefaults()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ShortcutDefaults component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ShortcutDefaults.Config config) : base(new ShortcutDefaults(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ShortcutDefaults component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual ShortcutDefaults.Builder IconCls(string iconCls)
            {
                this.ToComponent().IconCls = iconCls;
                return this as ShortcutDefaults.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ShortcutDefaults.Builder Name(string name)
            {
                this.ToComponent().Name = name;
                return this as ShortcutDefaults.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ShortcutDefaults.Builder TextCls(string textCls)
            {
                this.ToComponent().TextCls = textCls;
                return this as ShortcutDefaults.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ShortcutDefaults.Builder Handler(string handler)
            {
                this.ToComponent().Handler = handler;
                return this as ShortcutDefaults.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ShortcutDefaults.Builder Hidden(bool hidden)
            {
                this.ToComponent().Hidden = hidden;
                return this as ShortcutDefaults.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ShortcutDefaults.Builder QTitle(string qTitle)
            {
                this.ToComponent().QTitle = qTitle;
                return this as ShortcutDefaults.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ShortcutDefaults.Builder QTip(string qTip)
            {
                this.ToComponent().QTip = qTip;
                return this as ShortcutDefaults.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ShortcutDefaults.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ShortcutDefaults(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ShortcutDefaults.Builder ShortcutDefaults()
        {
            return this.ShortcutDefaults(new ShortcutDefaults());
        }

        /// <summary>
        /// 
        /// </summary>
        public ShortcutDefaults.Builder ShortcutDefaults(ShortcutDefaults component)
        {
            return new ShortcutDefaults.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ShortcutDefaults.Builder ShortcutDefaults(ShortcutDefaults.Config config)
        {
            return new ShortcutDefaults.Builder(new ShortcutDefaults(config));
        }
    }
}