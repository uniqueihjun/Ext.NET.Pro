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
    public partial class ButtonGroup
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ButtonGroup(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ButtonGroup.Config Conversion to ButtonGroup
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ButtonGroup(ButtonGroup.Config config)
        {
            return new ButtonGroup(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Panel.Config 
        { 
			/*  Implicit ButtonGroup.Config Conversion to ButtonGroup.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ButtonGroup.Builder(ButtonGroup.Config config)
			{
				return new ButtonGroup.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string defaultType = "Button";

			/// <summary>
			/// The default type of content Container represented by this object as registered in Ext.ComponentMgr. Defaults to 'button' in ButtonGroup
			/// </summary>
			[DefaultValue("Button")]
			public override string DefaultType 
			{ 
				get
				{
					return this.defaultType;
				}
				set
				{
					this.defaultType = value;
				}
			}

			private bool frame = true;

			/// <summary>
			/// True to render the panel with custom rounded borders, false to render with plain 1px square borders (defaults to true).
			/// </summary>
			[DefaultValue(true)]
			public override bool Frame 
			{ 
				get
				{
					return this.frame;
				}
				set
				{
					this.frame = value;
				}
			}

			private int columns = -1;

			/// <summary>
			/// The columns configuration property passed to the configured layout manager. See Ext.layout.TableLayout.columns.
			/// </summary>
			[DefaultValue(-1)]
			public virtual int Columns 
			{ 
				get
				{
					return this.columns;
				}
				set
				{
					this.columns = value;
				}
			}

			private string layout = "table";

			/// <summary>
			/// The layout type to be used in this container.
			/// </summary>
			[DefaultValue("table")]
			public override string Layout 
			{ 
				get
				{
					return this.layout;
				}
				set
				{
					this.layout = value;
				}
			}

        }
    }
}