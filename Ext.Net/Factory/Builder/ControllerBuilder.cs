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
    public partial class Controller
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ControllerBase.Builder<Controller, Controller.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Controller()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Controller component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Controller.Config config) : base(new Controller(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Controller component)
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
        public Controller.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Controller(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Controller.Builder Controller()
        {
            return this.Controller(new Controller());
        }

        /// <summary>
        /// 
        /// </summary>
        public Controller.Builder Controller(Controller component)
        {
            return new Controller.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Controller.Builder Controller(Controller.Config config)
        {
            return new Controller.Builder(new Controller(config));
        }
    }
}