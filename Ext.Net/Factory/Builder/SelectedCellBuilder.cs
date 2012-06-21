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
    public partial class SelectedCell
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseItem.Builder<SelectedCell, SelectedCell.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new SelectedCell()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SelectedCell component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SelectedCell.Config config) : base(new SelectedCell(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(SelectedCell component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual SelectedCell.Builder RowIndex(int rowIndex)
            {
                this.ToComponent().RowIndex = rowIndex;
                return this as SelectedCell.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual SelectedCell.Builder ColIndex(int colIndex)
            {
                this.ToComponent().ColIndex = colIndex;
                return this as SelectedCell.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual SelectedCell.Builder RecordID(string recordID)
            {
                this.ToComponent().RecordID = recordID;
                return this as SelectedCell.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual SelectedCell.Builder Name(string name)
            {
                this.ToComponent().Name = name;
                return this as SelectedCell.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// 
			/// </summary>
            public virtual SelectedCell.Builder Clear()
            {
                this.ToComponent().Clear();
                return this;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        public SelectedCell.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.SelectedCell(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public SelectedCell.Builder SelectedCell()
        {
            return this.SelectedCell(new SelectedCell());
        }

        /// <summary>
        /// 
        /// </summary>
        public SelectedCell.Builder SelectedCell(SelectedCell component)
        {
            return new SelectedCell.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public SelectedCell.Builder SelectedCell(SelectedCell.Config config)
        {
            return new SelectedCell.Builder(new SelectedCell(config));
        }
    }
}