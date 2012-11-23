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
        new public partial class Config : CellCommandColumn.Config 
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
			
			private bool menuDisabled = true;

			/// <summary>
			/// True to disabled the column header menu containing sort/hide options. Defaults to false.
			/// </summary>
			[DefaultValue(true)]
			public override bool MenuDisabled 
			{ 
				get
				{
					return this.menuDisabled;
				}
				set
				{
					this.menuDisabled = value;
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
			        
			private ImageCommandColumnListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public ImageCommandColumnListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new ImageCommandColumnListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private ImageCommandColumnDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public ImageCommandColumnDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new ImageCommandColumnDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}