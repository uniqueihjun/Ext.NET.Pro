/********
 * @version   : 1.6.0 - Ext.NET Pro License
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
    public partial class LockingGridView
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public LockingGridView(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit LockingGridView.Config Conversion to LockingGridView
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LockingGridView(LockingGridView.Config config)
        {
            return new LockingGridView(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : GridView.Config 
        { 
			/*  Implicit LockingGridView.Config Conversion to LockingGridView.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator LockingGridView.Builder(LockingGridView.Config config)
			{
				return new LockingGridView.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string lockText = "Lock";

			/// <summary>
			/// The text displayed in the \"Lock\" menu item
			/// </summary>
			[DefaultValue("Lock")]
			public virtual string LockText 
			{ 
				get
				{
					return this.lockText;
				}
				set
				{
					this.lockText = value;
				}
			}

			private string unlockText = "Unlock";

			/// <summary>
			/// The text displayed in the \"Unlock\" menu item
			/// </summary>
			[DefaultValue("Unlock")]
			public virtual string UnlockText 
			{ 
				get
				{
					return this.unlockText;
				}
				set
				{
					this.unlockText = value;
				}
			}

			private int rowBorderWidth = 1;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(1)]
			public virtual int RowBorderWidth 
			{ 
				get
				{
					return this.rowBorderWidth;
				}
				set
				{
					this.rowBorderWidth = value;
				}
			}

			private int lockedBorderWidth = 1;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(1)]
			public virtual int LockedBorderWidth 
			{ 
				get
				{
					return this.lockedBorderWidth;
				}
				set
				{
					this.lockedBorderWidth = value;
				}
			}

			private bool syncHeights = false;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(false)]
			public virtual bool SyncHeights 
			{ 
				get
				{
					return this.syncHeights;
				}
				set
				{
					this.syncHeights = value;
				}
			}

        }
    }
}