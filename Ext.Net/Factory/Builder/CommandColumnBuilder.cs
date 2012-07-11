/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class CommandColumn
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ColumnBase.Builder<CommandColumn, CommandColumn.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new CommandColumn()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CommandColumn component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CommandColumn.Config config) : base(new CommandColumn(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(CommandColumn component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// (optional) Specify as false to prevent the user from hiding this column. Defaults to true.
			/// </summary>
            public virtual CommandColumn.Builder Hideable(bool hideable)
            {
                this.ToComponent().Hideable = hideable;
                return this as CommandColumn.Builder;
            }
             
 			// /// <summary>
			// /// 
			// /// </summary>
            // public virtual TBuilder Commands(GridCommandCollection commands)
            // {
            //    this.ToComponent().Commands = commands;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// 
			// /// </summary>
            // public virtual TBuilder GroupCommands(GridCommandCollection groupCommands)
            // {
            //    this.ToComponent().GroupCommands = groupCommands;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// 
			// /// </summary>
            // public virtual TBuilder PrepareToolbar(JFunction prepareToolbar)
            // {
            //    this.ToComponent().PrepareToolbar = prepareToolbar;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// 
			// /// </summary>
            // public virtual TBuilder PrepareGroupToolbar(JFunction prepareGroupToolbar)
            // {
            //    this.ToComponent().PrepareGroupToolbar = prepareGroupToolbar;
            //    return this as TBuilder;
            // }
             
 			/// <summary>
			/// Valid values are \"left\", \"center\" and \"right\" (defaults to \"left\").
			/// </summary>
            public virtual CommandColumn.Builder ButtonAlign(Alignment buttonAlign)
            {
                this.ToComponent().ButtonAlign = buttonAlign;
                return this as CommandColumn.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public CommandColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CommandColumn(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public CommandColumn.Builder CommandColumn()
        {
            return this.CommandColumn(new CommandColumn());
        }

        /// <summary>
        /// 
        /// </summary>
        public CommandColumn.Builder CommandColumn(CommandColumn component)
        {
            return new CommandColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CommandColumn.Builder CommandColumn(CommandColumn.Config config)
        {
            return new CommandColumn.Builder(new CommandColumn(config));
        }
    }
}