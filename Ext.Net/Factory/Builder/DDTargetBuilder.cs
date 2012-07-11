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
    public partial class DDTarget
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : DragDrop.Builder<DDTarget, DDTarget.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DDTarget()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DDTarget component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DDTarget.Config config) : base(new DDTarget(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DDTarget component)
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
        public DDTarget.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DDTarget(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DDTarget.Builder DDTarget()
        {
            return this.DDTarget(new DDTarget());
        }

        /// <summary>
        /// 
        /// </summary>
        public DDTarget.Builder DDTarget(DDTarget component)
        {
            return new DDTarget.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DDTarget.Builder DDTarget(DDTarget.Config config)
        {
            return new DDTarget.Builder(new DDTarget(config));
        }
    }
}