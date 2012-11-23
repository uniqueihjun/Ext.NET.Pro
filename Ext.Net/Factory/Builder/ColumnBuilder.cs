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
    public partial class Column
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ColumnBase.Builder<Column, Column.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Column()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Column component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Column.Config config) : base(new Column(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Column component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual Column.Builder XType(string xType)
            {
                this.ToComponent().XType = xType;
                return this as Column.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual Column.Builder RightCommandAlign(bool rightCommandAlign)
            {
                this.ToComponent().RightCommandAlign = rightCommandAlign;
                return this as Column.Builder;
            }
             
 			// /// <summary>
			// /// 
			// /// </summary>
            // public virtual TBuilder Commands(ImageCommandCollection commands)
            // {
            //    this.ToComponent().Commands = commands;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// 
			// /// </summary>
            // public virtual TBuilder PrepareCommand(JFunction prepareCommand)
            // {
            //    this.ToComponent().PrepareCommand = prepareCommand;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// 
			// /// </summary>
            // public virtual TBuilder PrepareCommands(JFunction prepareCommands)
            // {
            //    this.ToComponent().PrepareCommands = prepareCommands;
            //    return this as TBuilder;
            // }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Column.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Column(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Column.Builder Column()
        {
            return this.Column(new Column());
        }

        /// <summary>
        /// 
        /// </summary>
        public Column.Builder Column(Column component)
        {
            return new Column.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Column.Builder Column(Column.Config config)
        {
            return new Column.Builder(new Column(config));
        }
    }
}