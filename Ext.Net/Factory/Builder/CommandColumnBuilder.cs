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
			/// True to disabled the column header menu containing sort/hide options. Defaults to false.
			/// </summary>
            public virtual CommandColumn.Builder MenuDisabled(bool menuDisabled)
            {
                this.ToComponent().MenuDisabled = menuDisabled;
                return this as CommandColumn.Builder;
            }
             
 			/// <summary>
			/// True to show toolbar for over row only
			/// </summary>
            public virtual CommandColumn.Builder OverOnly(bool overOnly)
            {
                this.ToComponent().OverOnly = overOnly;
                return this as CommandColumn.Builder;
            }
             
 			/// <summary>
			/// Delay before showing over toolbar
			/// </summary>
            public virtual CommandColumn.Builder ShowDelay(int showDelay)
            {
                this.ToComponent().ShowDelay = showDelay;
                return this as CommandColumn.Builder;
            }
             
 			/// <summary>
			/// Delay before hide over toolbar
			/// </summary>
            public virtual CommandColumn.Builder HideDelay(int hideDelay)
            {
                this.ToComponent().HideDelay = hideDelay;
                return this as CommandColumn.Builder;
            }
             
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of CommandColumn.Builder</returns>
            public virtual CommandColumn.Builder Commands(Action<GridCommandCollection> action)
            {
                action(this.ToComponent().Commands);
                return this as CommandColumn.Builder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of CommandColumn.Builder</returns>
            public virtual CommandColumn.Builder GroupCommands(Action<GridCommandCollection> action)
            {
                action(this.ToComponent().GroupCommands);
                return this as CommandColumn.Builder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of CommandColumn.Builder</returns>
            public virtual CommandColumn.Builder PrepareToolbar(Action<JFunction> action)
            {
                action(this.ToComponent().PrepareToolbar);
                return this as CommandColumn.Builder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of CommandColumn.Builder</returns>
            public virtual CommandColumn.Builder PrepareGroupToolbar(Action<JFunction> action)
            {
                action(this.ToComponent().PrepareGroupToolbar);
                return this as CommandColumn.Builder;
            }
			 
 			/// <summary>
			/// Valid values are \"start\", \"center\" and \"end\" (defaults to \"start\").
			/// </summary>
            public virtual CommandColumn.Builder Pack(BoxPack pack)
            {
                this.ToComponent().Pack = pack;
                return this as CommandColumn.Builder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of CommandColumn.Builder</returns>
            public virtual CommandColumn.Builder Listeners(Action<ImageCommandColumnListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as CommandColumn.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of CommandColumn.Builder</returns>
            public virtual CommandColumn.Builder DirectEvents(Action<ImageCommandColumnDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
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