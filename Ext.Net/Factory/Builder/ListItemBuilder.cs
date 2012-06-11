/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class ListItem
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : StateManagedItem.Builder<ListItem, ListItem.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ListItem()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ListItem component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ListItem.Config config) : base(new ListItem(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ListItem component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual ListItem.Builder Text(string text)
            {
                this.ToComponent().Text = text;
                return this as ListItem.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ListItem.Builder Value(string value)
            {
                this.ToComponent().Value = value;
                return this as ListItem.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ListItem.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ListItem(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ListItem.Builder ListItem()
        {
            return this.ListItem(new ListItem());
        }

        /// <summary>
        /// 
        /// </summary>
        public ListItem.Builder ListItem(ListItem component)
        {
            return new ListItem.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ListItem.Builder ListItem(ListItem.Config config)
        {
            return new ListItem.Builder(new ListItem(config));
        }
    }
}