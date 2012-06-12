/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class SelectedRow
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : StateManagedItem.Builder<SelectedRow, SelectedRow.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new SelectedRow()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SelectedRow component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SelectedRow.Config config) : base(new SelectedRow(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(SelectedRow component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual SelectedRow.Builder RecordID(string recordID)
            {
                this.ToComponent().RecordID = recordID;
                return this as SelectedRow.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual SelectedRow.Builder RowIndex(int rowIndex)
            {
                this.ToComponent().RowIndex = rowIndex;
                return this as SelectedRow.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public SelectedRow.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.SelectedRow(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public SelectedRow.Builder SelectedRow()
        {
            return this.SelectedRow(new SelectedRow());
        }

        /// <summary>
        /// 
        /// </summary>
        public SelectedRow.Builder SelectedRow(SelectedRow component)
        {
            return new SelectedRow.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public SelectedRow.Builder SelectedRow(SelectedRow.Config config)
        {
            return new SelectedRow.Builder(new SelectedRow(config));
        }
    }
}