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
    public partial class BooleanColumn
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public BooleanColumn(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit BooleanColumn.Config Conversion to BooleanColumn
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BooleanColumn(BooleanColumn.Config config)
        {
            return new BooleanColumn(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : CellCommandColumn.Config 
        { 
			/*  Implicit BooleanColumn.Config Conversion to BooleanColumn.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator BooleanColumn.Builder(BooleanColumn.Config config)
			{
				return new BooleanColumn.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string falseText = "false";

			/// <summary>
			/// The string returned by the renderer when the column value is falsey (but not undefined) (defaults to 'false').
			/// </summary>
			[DefaultValue("false")]
			public virtual string FalseText 
			{ 
				get
				{
					return this.falseText;
				}
				set
				{
					this.falseText = value;
				}
			}

			private string trueText = "true";

			/// <summary>
			/// The string returned by the renderer when the column value is not falsey (defaults to 'true').
			/// </summary>
			[DefaultValue("true")]
			public virtual string TrueText 
			{ 
				get
				{
					return this.trueText;
				}
				set
				{
					this.trueText = value;
				}
			}

			private string undefinedText = "&#160;";

			/// <summary>
			/// The string returned by the renderer when the column value is undefined (defaults to ' ').
			/// </summary>
			[DefaultValue("&#160;")]
			public virtual string UndefinedText 
			{ 
				get
				{
					return this.undefinedText;
				}
				set
				{
					this.undefinedText = value;
				}
			}

        }
    }
}