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
    public partial class PresenceValidation
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractValidation.Builder<PresenceValidation, PresenceValidation.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new PresenceValidation()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(PresenceValidation component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(PresenceValidation.Config config) : base(new PresenceValidation(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(PresenceValidation component)
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
        public PresenceValidation.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.PresenceValidation(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public PresenceValidation.Builder PresenceValidation()
        {
            return this.PresenceValidation(new PresenceValidation());
        }

        /// <summary>
        /// 
        /// </summary>
        public PresenceValidation.Builder PresenceValidation(PresenceValidation component)
        {
            return new PresenceValidation.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public PresenceValidation.Builder PresenceValidation(PresenceValidation.Config config)
        {
            return new PresenceValidation.Builder(new PresenceValidation(config));
        }
    }
}