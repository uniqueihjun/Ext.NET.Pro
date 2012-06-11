/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public Grouping(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit Grouping.Config Conversion to Grouping
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Grouping(Grouping.Config config)
        {
            return new Grouping(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : GridFeature.Config 
        { 
			/*  Implicit Grouping.Config Conversion to Grouping.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator Grouping.Builder(Grouping.Config config)
			{
				return new Grouping.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private int depthToIndent = 17;

			/// <summary>
			/// True to enable drag and drop reorder of columns.
			/// </summary>
			[DefaultValue(17)]
			public virtual int DepthToIndent 
			{ 
				get
				{
					return this.depthToIndent;
				}
				set
				{
					this.depthToIndent = value;
				}
			}

			private bool enableGroupingMenu = true;

			/// <summary>
			/// True to enable the grouping control in the header menu (defaults to true)
			/// </summary>
			[DefaultValue(true)]
			public virtual bool EnableGroupingMenu 
			{ 
				get
				{
					return this.enableGroupingMenu;
				}
				set
				{
					this.enableGroupingMenu = value;
				}
			}

			private bool enableNoGroups = true;

			/// <summary>
			/// True to allow the user to turn off grouping (defaults to true)
			/// </summary>
			[DefaultValue(true)]
			public virtual bool EnableNoGroups 
			{ 
				get
				{
					return this.enableNoGroups;
				}
				set
				{
					this.enableNoGroups = value;
				}
			}

			private string groupByText = "";

			/// <summary>
			/// Text displayed in the grid header menu for grouping by header (defaults to 'Group By This Field').
			/// </summary>
			[DefaultValue("")]
			public virtual string GroupByText 
			{ 
				get
				{
					return this.groupByText;
				}
				set
				{
					this.groupByText = value;
				}
			}

			private string groupHeaderTplString = "";

			/// <summary>
			/// A string Template snippet, an array of strings (optionally followed by an object containing Template methods) to be used to construct a Template, or a Template instance. Defaults to: \"{columnName}: {name}\"
			/// </summary>
			[DefaultValue("")]
			public virtual string GroupHeaderTplString 
			{ 
				get
				{
					return this.groupHeaderTplString;
				}
				set
				{
					this.groupHeaderTplString = value;
				}
			}

			private bool hideGroupedHeader = false;

			/// <summary>
			/// True to hide the header that is currently grouped (defaults to false)
			/// </summary>
			[DefaultValue(false)]
			public virtual bool HideGroupedHeader 
			{ 
				get
				{
					return this.hideGroupedHeader;
				}
				set
				{
					this.hideGroupedHeader = value;
				}
			}

			private string showGroupsText = "";

			/// <summary>
			/// Text displayed in the grid header for enabling/disabling grouping (defaults to 'Show in Groups').
			/// </summary>
			[DefaultValue("")]
			public virtual string ShowGroupsText 
			{ 
				get
				{
					return this.showGroupsText;
				}
				set
				{
					this.showGroupsText = value;
				}
			}

			private bool startCollapsed = false;

			/// <summary>
			/// True to start all groups collapsed (defaults to false)
			/// </summary>
			[DefaultValue(false)]
			public virtual bool StartCollapsed 
			{ 
				get
				{
					return this.startCollapsed;
				}
				set
				{
					this.startCollapsed = value;
				}
			}

        }
    }
}