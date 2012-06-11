/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class Box : StateManagedItem
    {
        private int x = int.MinValue;
        private int y = int.MinValue;
        private int width = int.MinValue;
        private int height = int.MinValue;
        private string strWidth;
        private string strHeight;

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption]
        [DefaultValue(int.MinValue)]
		[Description("")]
        public int X
        {
            get { return x; }
            set { x = value; }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption]
        [DefaultValue(int.MinValue)]
		[Description("")]
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption]
        [DefaultValue(int.MinValue)]
		[Description("")]
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption]
        [DefaultValue(int.MinValue)]
		[Description("")]
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("width")]
        [DefaultValue(int.MinValue)]
		[Description("")]
        public string StrWidth
        {
            get { return strWidth; }
            set { strWidth = value; }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("height")]
        [DefaultValue(null)]
		[Description("")]
        public string StrHeight
        {
            get { return strHeight; }
            set { strHeight = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Serialize()
        {
            return new ClientConfig().Serialize(this, true);
        }
    }
}