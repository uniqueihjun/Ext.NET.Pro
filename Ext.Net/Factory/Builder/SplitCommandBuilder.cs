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
    public partial class SplitCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : GridCommand.Builder<SplitCommand, SplitCommand.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new SplitCommand()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SplitCommand component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SplitCommand.Config config) : base(new SplitCommand(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(SplitCommand component)
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
        public SplitCommand.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.SplitCommand(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public SplitCommand.Builder SplitCommand()
        {
            return this.SplitCommand(new SplitCommand());
        }

        /// <summary>
        /// 
        /// </summary>
        public SplitCommand.Builder SplitCommand(SplitCommand component)
        {
            return new SplitCommand.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public SplitCommand.Builder SplitCommand(SplitCommand.Config config)
        {
            return new SplitCommand.Builder(new SplitCommand(config));
        }
    }
}