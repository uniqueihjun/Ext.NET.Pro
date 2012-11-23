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
    public partial class GenericPlugin
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Plugin.Builder<GenericPlugin, GenericPlugin.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new GenericPlugin()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GenericPlugin component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GenericPlugin.Config config) : base(new GenericPlugin(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(GenericPlugin component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The JavaScript class name. Used to create a 'new' instance of the object.
			/// </summary>
            public virtual GenericPlugin.Builder InstanceName(string instanceName)
            {
                this.ToComponent().InstanceName = instanceName;
                return this as GenericPlugin.Builder;
            }
             
 			/// <summary>
			/// The file path to the required JavaScript file.
			/// </summary>
            public virtual GenericPlugin.Builder Path(string path)
            {
                this.ToComponent().Path = path;
                return this as GenericPlugin.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public GenericPlugin.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.GenericPlugin(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public GenericPlugin.Builder GenericPlugin()
        {
            return this.GenericPlugin(new GenericPlugin());
        }

        /// <summary>
        /// 
        /// </summary>
        public GenericPlugin.Builder GenericPlugin(GenericPlugin component)
        {
            return new GenericPlugin.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public GenericPlugin.Builder GenericPlugin(GenericPlugin.Config config)
        {
            return new GenericPlugin.Builder(new GenericPlugin(config));
        }
    }
}