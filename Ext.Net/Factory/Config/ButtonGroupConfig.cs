/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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

        }
    }
}