/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class SelectedListItem
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : StateManagedItem.Builder<SelectedListItem, SelectedListItem.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new SelectedListItem()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SelectedListItem component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SelectedListItem.Config config) : base(new SelectedListItem(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(SelectedListItem component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual SelectedListItem.Builder Value(string value)
            {
                this.ToComponent().Value = value;
                return this as SelectedListItem.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual SelectedListItem.Builder Index(int index)
            {
                this.ToComponent().Index = index;
                return this as SelectedListItem.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public SelectedListItem.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.SelectedListItem(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public SelectedListItem.Builder SelectedListItem()
        {
            return this.SelectedListItem(new SelectedListItem());
        }

        /// <summary>
        /// 
        /// </summary>
        public SelectedListItem.Builder SelectedListItem(SelectedListItem component)
        {
            return new SelectedListItem.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public SelectedListItem.Builder SelectedListItem(SelectedListItem.Config config)
        {
            return new SelectedListItem.Builder(new SelectedListItem(config));
        }
    }
}