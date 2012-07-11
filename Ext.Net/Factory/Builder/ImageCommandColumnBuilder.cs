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
    public partial class ImageCommandColumn
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Column.Builder<ImageCommandColumn, ImageCommandColumn.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ImageCommandColumn()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ImageCommandColumn component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ImageCommandColumn.Config config) : base(new ImageCommandColumn(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ImageCommandColumn component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// (optional) Specify as false to prevent the user from hiding this column. Defaults to true.
			/// </summary>
            public virtual ImageCommandColumn.Builder Hideable(bool hideable)
            {
                this.ToComponent().Hideable = hideable;
                return this as ImageCommandColumn.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ImageCommandColumn.Builder RightCommandAlign(bool rightCommandAlign)
            {
                this.ToComponent().RightCommandAlign = rightCommandAlign;
                return this as ImageCommandColumn.Builder;
            }
             
 			// /// <summary>
			// /// 
			// /// </summary>
            // public virtual TBuilder GroupCommands(GroupImageCommandCollection groupCommands)
            // {
            //    this.ToComponent().GroupCommands = groupCommands;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// 
			// /// </summary>
            // public virtual TBuilder PrepareGroupCommand(JFunction prepareGroupCommand)
            // {
            //    this.ToComponent().PrepareGroupCommand = prepareGroupCommand;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// 
			// /// </summary>
            // public virtual TBuilder PrepareGroupCommands(JFunction prepareGroupCommands)
            // {
            //    this.ToComponent().PrepareGroupCommands = prepareGroupCommands;
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
        public ImageCommandColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ImageCommandColumn(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageCommandColumn.Builder ImageCommandColumn()
        {
            return this.ImageCommandColumn(new ImageCommandColumn());
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageCommandColumn.Builder ImageCommandColumn(ImageCommandColumn component)
        {
            return new ImageCommandColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageCommandColumn.Builder ImageCommandColumn(ImageCommandColumn.Config config)
        {
            return new ImageCommandColumn.Builder(new ImageCommandColumn(config));
        }
    }
}