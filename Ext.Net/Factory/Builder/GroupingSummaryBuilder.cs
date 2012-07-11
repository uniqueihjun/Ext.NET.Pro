/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class GroupingSummary
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Grouping.Builder<GroupingSummary, GroupingSummary.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new GroupingSummary()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GroupingSummary component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GroupingSummary.Config config) : base(new GroupingSummary(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(GroupingSummary component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// true to add css for column separation lines. Default is false.
			/// </summary>
            public virtual GroupingSummary.Builder ShowSummaryRow(bool showSummaryRow)
            {
                this.ToComponent().ShowSummaryRow = showSummaryRow;
                return this as GroupingSummary.Builder;
            }
             
 			/// <summary>
			/// The name of the property which contains the Array of summary objects. Defaults to undefined. It allows to use server-side calculated summaries.
			/// </summary>
            public virtual GroupingSummary.Builder RemoteRoot(string remoteRoot)
            {
                this.ToComponent().RemoteRoot = remoteRoot;
                return this as GroupingSummary.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public GroupingSummary.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.GroupingSummary(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public GroupingSummary.Builder GroupingSummary()
        {
            return this.GroupingSummary(new GroupingSummary());
        }

        /// <summary>
        /// 
        /// </summary>
        public GroupingSummary.Builder GroupingSummary(GroupingSummary component)
        {
            return new GroupingSummary.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public GroupingSummary.Builder GroupingSummary(GroupingSummary.Config config)
        {
            return new GroupingSummary.Builder(new GroupingSummary(config));
        }
    }
}