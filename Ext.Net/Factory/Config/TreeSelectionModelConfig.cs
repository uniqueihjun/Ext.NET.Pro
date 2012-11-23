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
    public partial class TreeSelectionModel
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public TreeSelectionModel(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit TreeSelectionModel.Config Conversion to TreeSelectionModel
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TreeSelectionModel(TreeSelectionModel.Config config)
        {
            return new TreeSelectionModel(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : RowSelectionModel.Config 
        { 
			/*  Implicit TreeSelectionModel.Config Conversion to TreeSelectionModel.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator TreeSelectionModel.Builder(TreeSelectionModel.Config config)
			{
				return new TreeSelectionModel.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool pruneRemoved = false;

			/// <summary>
			/// Prune records when they are removed from the store from the selection.
			/// </summary>
			[DefaultValue(false)]
			public override bool PruneRemoved 
			{ 
				get
				{
					return this.pruneRemoved;
				}
				set
				{
					this.pruneRemoved = value;
				}
			}

        }
    }
}