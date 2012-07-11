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
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public GroupingSummary(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit GroupingSummary.Config Conversion to GroupingSummary
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GroupingSummary(GroupingSummary.Config config)
        {
            return new GroupingSummary(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Grouping.Config 
        { 
			/*  Implicit GroupingSummary.Config Conversion to GroupingSummary.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator GroupingSummary.Builder(GroupingSummary.Config config)
			{
				return new GroupingSummary.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool showSummaryRow = true;

			/// <summary>
			/// true to add css for column separation lines. Default is false.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool ShowSummaryRow 
			{ 
				get
				{
					return this.showSummaryRow;
				}
				set
				{
					this.showSummaryRow = value;
				}
			}

			private string remoteRoot = "";

			/// <summary>
			/// The name of the property which contains the Array of summary objects. Defaults to undefined. It allows to use server-side calculated summaries.
			/// </summary>
			[DefaultValue("")]
			public virtual string RemoteRoot 
			{ 
				get
				{
					return this.remoteRoot;
				}
				set
				{
					this.remoteRoot = value;
				}
			}

        }
    }
}