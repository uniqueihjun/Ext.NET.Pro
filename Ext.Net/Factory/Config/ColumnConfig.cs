/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class Column
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public Column(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit Column.Config Conversion to Column
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Column(Column.Config config)
        {
            return new Column(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ColumnBase.Config 
        { 
			/*  Implicit Column.Config Conversion to Column.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator Column.Builder(Column.Config config)
			{
				return new Column.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string xType = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string XType 
			{ 
				get
				{
					return this.xType;
				}
				set
				{
					this.xType = value;
				}
			}

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