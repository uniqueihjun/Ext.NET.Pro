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
    public partial class DD
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : DragDrop.Builder<DD, DD.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DD()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DD component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DD.Config config) : base(new DD(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DD component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// When set to true, the utility automatically tries to scroll the browser window when a drag and drop element is dragged near the viewport boundary. Defaults to true.
			/// </summary>
            public virtual DD.Builder Scroll(bool scroll)
            {
                this.ToComponent().Scroll = scroll;
                return this as DD.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public DD.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DD(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DD.Builder DD()
        {
            return this.DD(new DD());
        }

        /// <summary>
        /// 
        /// </summary>
        public DD.Builder DD(DD component)
        {
            return new DD.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DD.Builder DD(DD.Config config)
        {
            return new DD.Builder(new DD(config));
        }
    }
}