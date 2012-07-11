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
    public partial class CellEditing
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : GridEditing.Builder<CellEditing, CellEditing.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new CellEditing()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CellEditing component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CellEditing.Config config) : base(new CellEditing(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(CellEditing component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of CellEditing.Builder</returns>
            public virtual CellEditing.Builder Listeners(Action<CellEditingListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as CellEditing.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of CellEditing.Builder</returns>
            public virtual CellEditing.Builder DirectEvents(Action<CellEditingDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as CellEditing.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public CellEditing.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CellEditing(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public CellEditing.Builder CellEditing()
        {
            return this.CellEditing(new CellEditing());
        }

        /// <summary>
        /// 
        /// </summary>
        public CellEditing.Builder CellEditing(CellEditing component)
        {
            return new CellEditing.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CellEditing.Builder CellEditing(CellEditing.Config config)
        {
            return new CellEditing.Builder(new CellEditing(config));
        }
    }
}