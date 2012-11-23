/********
 * @version   : 2.1.0 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class RatingColumn
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public RatingColumn(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit RatingColumn.Config Conversion to RatingColumn
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RatingColumn(RatingColumn.Config config)
        {
            return new RatingColumn(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ColumnBase.Config 
        { 
			/*  Implicit RatingColumn.Config Conversion to RatingColumn.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator RatingColumn.Builder(RatingColumn.Config config)
			{
				return new RatingColumn.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string dataIndex = "rating";

			/// <summary>
			/// (optional) The name of the field in the grid's Ext.data.Store's Ext.data.Record definition from which to draw the column's value. If not specified, the column's index is used as an index into the Record's data Array.
			/// </summary>
			[DefaultValue("rating")]
			public override string DataIndex 
			{ 
				get
				{
					return this.dataIndex;
				}
				set
				{
					this.dataIndex = value;
				}
			}

			private bool editable = false;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(false)]
			public virtual bool Editable 
			{ 
				get
				{
					return this.editable;
				}
				set
				{
					this.editable = value;
				}
			}

			private bool allowChange = true;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(true)]
			public virtual bool AllowChange 
			{ 
				get
				{
					return this.allowChange;
				}
				set
				{
					this.allowChange = value;
				}
			}

			private string selectedCls = "rating-selected";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("rating-selected")]
			public virtual string SelectedCls 
			{ 
				get
				{
					return this.selectedCls;
				}
				set
				{
					this.selectedCls = value;
				}
			}

			private string unselectedCls = "rating-unselected";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("rating-unselected")]
			public virtual string UnselectedCls 
			{ 
				get
				{
					return this.unselectedCls;
				}
				set
				{
					this.unselectedCls = value;
				}
			}

			private int maxRating = 5;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(5)]
			public virtual int MaxRating 
			{ 
				get
				{
					return this.maxRating;
				}
				set
				{
					this.maxRating = value;
				}
			}

			private int tickSize = 16;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(16)]
			public virtual int TickSize 
			{ 
				get
				{
					return this.tickSize;
				}
				set
				{
					this.tickSize = value;
				}
			}

			private bool roundToTick = true;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(true)]
			public virtual bool RoundToTick 
			{ 
				get
				{
					return this.roundToTick;
				}
				set
				{
					this.roundToTick = value;
				}
			}

        }
    }
}