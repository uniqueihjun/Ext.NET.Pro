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
    public partial class SortInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseItem.Builder<SortInfo, SortInfo.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new SortInfo()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SortInfo component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SortInfo.Config config) : base(new SortInfo(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(SortInfo component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Internal UI Event. Fired before the view is refreshed.
			/// </summary>
            public virtual SortInfo.Builder Field(string field)
            {
                this.ToComponent().Field = field;
                return this as SortInfo.Builder;
            }
             
 			/// <summary>
			/// The direction to sort (\"asc\" or \"desc\")
			/// </summary>
            public virtual SortInfo.Builder Direction(SortDirection direction)
            {
                this.ToComponent().Direction = direction;
                return this as SortInfo.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public SortInfo.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.SortInfo(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public SortInfo.Builder SortInfo()
        {
            return this.SortInfo(new SortInfo());
        }

        /// <summary>
        /// 
        /// </summary>
        public SortInfo.Builder SortInfo(SortInfo component)
        {
            return new SortInfo.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public SortInfo.Builder SortInfo(SortInfo.Config config)
        {
            return new SortInfo.Builder(new SortInfo(config));
        }
    }
}