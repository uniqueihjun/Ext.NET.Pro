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
    public abstract partial class CellCommandColumn
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : ColumnBase.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool rightCommandAlign = true;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(true)]
			public virtual bool RightCommandAlign 
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
        
			private ImageCommandCollection commands = null;

			/// <summary>
			/// 
			/// </summary>
			public ImageCommandCollection Commands
			{
				get
				{
					if (this.commands == null)
					{
						this.commands = new ImageCommandCollection();
					}
			
					return this.commands;
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