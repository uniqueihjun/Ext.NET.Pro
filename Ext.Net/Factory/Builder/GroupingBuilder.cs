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
    public partial class Grouping
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : GridFeature.Builder<Grouping, Grouping.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Grouping()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Grouping component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Grouping.Config config) : base(new Grouping(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Grouping component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// True to enable drag and drop reorder of columns.
			/// </summary>
            public virtual Grouping.Builder DepthToIndent(int depthToIndent)
            {
                this.ToComponent().DepthToIndent = depthToIndent;
                return this as Grouping.Builder;
            }
             
 			/// <summary>
			/// True to enable the grouping control in the header menu (defaults to true)
			/// </summary>
            public virtual Grouping.Builder EnableGroupingMenu(bool enableGroupingMenu)
            {
                this.ToComponent().EnableGroupingMenu = enableGroupingMenu;
                return this as Grouping.Builder;
            }
             
 			/// <summary>
			/// True to allow the user to turn off grouping (defaults to true)
			/// </summary>
            public virtual Grouping.Builder EnableNoGroups(bool enableNoGroups)
            {
                this.ToComponent().EnableNoGroups = enableNoGroups;
                return this as Grouping.Builder;
            }
             
 			/// <summary>
			/// Text displayed in the grid header menu for grouping by header (defaults to 'Group By This Field').
			/// </summary>
            public virtual Grouping.Builder GroupByText(string groupByText)
            {
                this.ToComponent().GroupByText = groupByText;
                return this as Grouping.Builder;
            }
             
 			/// <summary>
			/// A string Template snippet, an array of strings (optionally followed by an object containing Template methods) to be used to construct a Template, or a Template instance. Defaults to: \"{columnName}: {name}\"
			/// </summary>
            public virtual Grouping.Builder GroupHeaderTplString(string groupHeaderTplString)
            {
                this.ToComponent().GroupHeaderTplString = groupHeaderTplString;
                return this as Grouping.Builder;
            }
             
 			/// <summary>
			/// True to hide the header that is currently grouped (defaults to false)
			/// </summary>
            public virtual Grouping.Builder HideGroupedHeader(bool hideGroupedHeader)
            {
                this.ToComponent().HideGroupedHeader = hideGroupedHeader;
                return this as Grouping.Builder;
            }
             
 			/// <summary>
			/// Text displayed in the grid header for enabling/disabling grouping (defaults to 'Show in Groups').
			/// </summary>
            public virtual Grouping.Builder ShowGroupsText(string showGroupsText)
            {
                this.ToComponent().ShowGroupsText = showGroupsText;
                return this as Grouping.Builder;
            }
             
 			/// <summary>
			/// True to start all groups collapsed (defaults to false)
			/// </summary>
            public virtual Grouping.Builder StartCollapsed(bool startCollapsed)
            {
                this.ToComponent().StartCollapsed = startCollapsed;
                return this as Grouping.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Grouping.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Grouping(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Grouping.Builder Grouping()
        {
            return this.Grouping(new Grouping());
        }

        /// <summary>
        /// 
        /// </summary>
        public Grouping.Builder Grouping(Grouping component)
        {
            return new Grouping.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Grouping.Builder Grouping(Grouping.Config config)
        {
            return new Grouping.Builder(new Grouping(config));
        }
    }
}