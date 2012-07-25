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
    public partial class DataViewDraggable
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public DataViewDraggable(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit DataViewDraggable.Config Conversion to DataViewDraggable
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataViewDraggable(DataViewDraggable.Config config)
        {
            return new DataViewDraggable(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Plugin.Config 
        { 
			/*  Implicit DataViewDraggable.Config Conversion to DataViewDraggable.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator DataViewDraggable.Builder(DataViewDraggable.Config config)
			{
				return new DataViewDraggable.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string ghostCls = "";

			/// <summary>
			/// The CSS class added to the outermost element of the created ghost proxy
			/// </summary>
			[DefaultValue("")]
			public virtual string GhostCls 
			{ 
				get
				{
					return this.ghostCls;
				}
				set
				{
					this.ghostCls = value;
				}
			}

			private XTemplate ghostTpl = null;

			/// <summary>
			/// The template used in the ghost DataView
			/// </summary>
			[DefaultValue(null)]
			public virtual XTemplate GhostTpl 
			{ 
				get
				{
					return this.ghostTpl;
				}
				set
				{
					this.ghostTpl = value;
				}
			}

			private DragZone dDConfig = null;

			/// <summary>
			/// Config object that is applied to the internally created DragZone
			/// </summary>
			[DefaultValue(null)]
			public virtual DragZone DDConfig 
			{ 
				get
				{
					return this.dDConfig;
				}
				set
				{
					this.dDConfig = value;
				}
			}

        }
    }
}