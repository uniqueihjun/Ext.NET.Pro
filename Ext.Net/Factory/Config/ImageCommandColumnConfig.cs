/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class ImageCommandColumn
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ImageCommandColumn(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ImageCommandColumn.Config Conversion to ImageCommandColumn
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageCommandColumn(ImageCommandColumn.Config config)
        {
            return new ImageCommandColumn(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Column.Config 
        { 
			/*  Implicit ImageCommandColumn.Config Conversion to ImageCommandColumn.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ImageCommandColumn.Builder(ImageCommandColumn.Config config)
			{
				return new ImageCommandColumn.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool hideable = true;

			/// <summary>
			/// (optional) Specify as false to prevent the user from hiding this column. Defaults to true.
			/// </summary>
			[DefaultValue(true)]
			public override bool Hideable 
			{ 
				get
				{
					return this.hideable;
				}
				set
				{
					this.hideable = value;
				}
			}

			private bool rightCommandAlign = false;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(false)]
			public override bool RightCommandAlign 
			{ 
				get
				{
					return this.rightCommandAlign;
				}
				set
				{
					this.rightCommandAlign = value;
				}
			}
        
			private GroupImageCommandCollection groupCommands = null;

			/// <summary>
			/// 
			/// </summary>
			public GroupImageCommandCollection GroupCommands
			{
				get
				{
					if (this.groupCommands == null)
					{
						this.groupCommands = new GroupImageCommandCollection();
					}
			
					return this.groupCommands;
				}
			}
			        
			private JFunction prepareGroupCommand = null;

			/// <summary>
			/// 
			/// </summary>
			public JFunction PrepareGroupCommand
			{
				get
				{
					if (this.prepareGroupCommand == null)
					{
						this.prepareGroupCommand = new JFunction();
					}
			
					return this.prepareGroupCommand;
				}
			}
			        
			private JFunction prepareGroupCommands = null;

			/// <summary>
			/// 
			/// </summary>
			public JFunction PrepareGroupCommands
			{
				get
				{
					if (this.prepareGroupCommands == null)
					{
						this.prepareGroupCommands = new JFunction();
					}
			
					return this.prepareGroupCommands;
				}
			}
			        
			private JFunction prepareCommand = null;

			/// <summary>
			/// 
			/// </summary>
			public JFunction PrepareCommand
			{
				get
				{
					if (this.prepareCommand == null)
					{
						this.prepareCommand = new JFunction();
					}
			
					return this.prepareCommand;
				}
			}
			        
			private JFunction prepareCommands = null;

			/// <summary>
			/// 
			/// </summary>
			public JFunction PrepareCommands
			{
				get
				{
					if (this.prepareCommands == null)
					{
						this.prepareCommands = new JFunction();
					}
			
					return this.prepareCommands;
				}
			}
			
        }
    }
}