/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public partial class FieldReplicator
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Plugin.Builder<FieldReplicator, FieldReplicator.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new FieldReplicator()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(FieldReplicator component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(FieldReplicator.Config config) : base(new FieldReplicator(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(FieldReplicator component)
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
        public FieldReplicator.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.FieldReplicator(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public FieldReplicator.Builder FieldReplicator()
        {
            return this.FieldReplicator(new FieldReplicator());
        }

        /// <summary>
        /// 
        /// </summary>
        public FieldReplicator.Builder FieldReplicator(FieldReplicator component)
        {
            return new FieldReplicator.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public FieldReplicator.Builder FieldReplicator(FieldReplicator.Config config)
        {
            return new FieldReplicator.Builder(new FieldReplicator(config));
        }
    }
}