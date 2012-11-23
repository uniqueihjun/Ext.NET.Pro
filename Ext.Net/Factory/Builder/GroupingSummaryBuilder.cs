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
    public partial class GroupingSummary
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TGroupingSummary, TBuilder> : Grouping.Builder<TGroupingSummary, TBuilder>
            where TGroupingSummary : GroupingSummary
            where TBuilder : Builder<TGroupingSummary, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TGroupingSummary component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// true to add css for column separation lines. Default is false.
			/// </summary>
            public virtual TBuilder ShowSummaryRow(bool showSummaryRow)
            {
                this.ToComponent().ShowSummaryRow = showSummaryRow;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The name of the property which contains the Array of summary objects. Defaults to undefined. It allows to use server-side calculated summaries.
			/// </summary>
            public virtual TBuilder RemoteRoot(string remoteRoot)
            {
                this.ToComponent().RemoteRoot = remoteRoot;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : GroupingSummary.Builder<GroupingSummary, GroupingSummary.Builder>
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
        }

        /// <summary>
        /// 
        /// </summary>
        public GroupingSummary.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.GroupingSummary(this);
		}
		
		/// <summary>
        /// 
        /// </summary>
        public override IControlBuilder ToNativeBuilder()
		{
			return (IControlBuilder)this.ToBuilder();
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
#if MVC
			return this.GroupingSummary(new GroupingSummary { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.GroupingSummary(new GroupingSummary());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public GroupingSummary.Builder GroupingSummary(GroupingSummary component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new GroupingSummary.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public GroupingSummary.Builder GroupingSummary(GroupingSummary.Config config)
        {
#if MVC
			return new GroupingSummary.Builder(new GroupingSummary(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new GroupingSummary.Builder(new GroupingSummary(config));
#endif			
        }
    }
}