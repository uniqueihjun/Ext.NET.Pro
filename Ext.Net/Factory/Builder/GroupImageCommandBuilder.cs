/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class GroupImageCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ImageCommandBase.Builder<GroupImageCommand, GroupImageCommand.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new GroupImageCommand()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GroupImageCommand component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GroupImageCommand.Config config) : base(new GroupImageCommand(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(GroupImageCommand component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual GroupImageCommand.Builder RightAlign(bool rightAlign)
            {
                this.ToComponent().RightAlign = rightAlign;
                return this as GroupImageCommand.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public GroupImageCommand.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.GroupImageCommand(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public GroupImageCommand.Builder GroupImageCommand()
        {
            return this.GroupImageCommand(new GroupImageCommand());
        }

        /// <summary>
        /// 
        /// </summary>
        public GroupImageCommand.Builder GroupImageCommand(GroupImageCommand component)
        {
            return new GroupImageCommand.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public GroupImageCommand.Builder GroupImageCommand(GroupImageCommand.Config config)
        {
            return new GroupImageCommand.Builder(new GroupImageCommand(config));
        }
    }
}