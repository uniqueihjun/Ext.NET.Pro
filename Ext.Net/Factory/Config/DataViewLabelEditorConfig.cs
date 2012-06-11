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
    public partial class DataViewLabelEditor
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public DataViewLabelEditor(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit DataViewLabelEditor.Config Conversion to DataViewLabelEditor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataViewLabelEditor(DataViewLabelEditor.Config config)
        {
            return new DataViewLabelEditor(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Plugin.Config 
        { 
			/*  Implicit DataViewLabelEditor.Config Conversion to DataViewLabelEditor.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator DataViewLabelEditor.Builder(DataViewLabelEditor.Config config)
			{
				return new DataViewLabelEditor.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string dataIndex = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string DataIndex 
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

			private string labelSelector = "";

			/// <summary>
			/// x-editable
			/// </summary>
			[DefaultValue("")]
			public virtual string LabelSelector 
			{ 
				get
				{
					return this.labelSelector;
				}
				set
				{
					this.labelSelector = value;
				}
			}

        }
    }
}