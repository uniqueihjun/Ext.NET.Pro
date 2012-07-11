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
    public partial class PortalColumn
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Panel.Builder<PortalColumn, PortalColumn.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new PortalColumn()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(PortalColumn component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(PortalColumn.Config config) : base(new PortalColumn(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(PortalColumn component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public PortalColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.PortalColumn(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public PortalColumn.Builder PortalColumn()
        {
            return this.PortalColumn(new PortalColumn());
        }

        /// <summary>
        /// 
        /// </summary>
        public PortalColumn.Builder PortalColumn(PortalColumn component)
        {
            return new PortalColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public PortalColumn.Builder PortalColumn(PortalColumn.Config config)
        {
            return new PortalColumn.Builder(new PortalColumn(config));
        }
    }
}