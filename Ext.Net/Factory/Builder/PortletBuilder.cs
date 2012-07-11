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
    public partial class Portlet
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Panel.Builder<Portlet, Portlet.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Portlet()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Portlet component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Portlet.Config config) : base(new Portlet(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Portlet component)
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
        public Portlet.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Portlet(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Portlet.Builder Portlet()
        {
            return this.Portlet(new Portlet());
        }

        /// <summary>
        /// 
        /// </summary>
        public Portlet.Builder Portlet(Portlet component)
        {
            return new Portlet.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Portlet.Builder Portlet(Portlet.Config config)
        {
            return new Portlet.Builder(new Portlet(config));
        }
    }
}