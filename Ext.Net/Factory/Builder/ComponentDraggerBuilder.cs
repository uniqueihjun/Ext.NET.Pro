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
    public partial class ComponentDragger
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : DragTracker.Builder<ComponentDragger, ComponentDragger.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ComponentDragger()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ComponentDragger component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ComponentDragger.Config config) : base(new ComponentDragger(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ComponentDragger component)
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
        public ComponentDragger.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ComponentDragger(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ComponentDragger.Builder ComponentDragger()
        {
            return this.ComponentDragger(new ComponentDragger());
        }

        /// <summary>
        /// 
        /// </summary>
        public ComponentDragger.Builder ComponentDragger(ComponentDragger component)
        {
            return new ComponentDragger.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ComponentDragger.Builder ComponentDragger(ComponentDragger.Config config)
        {
            return new ComponentDragger.Builder(new ComponentDragger(config));
        }
    }
}