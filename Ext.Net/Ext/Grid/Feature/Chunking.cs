/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    public partial class Chunking : GridFeature
    {
        /// <summary>
        /// 
        /// </summary>
        public Chunking()
        { 
        }
        
        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.grid.feature.Chunking";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [ConfigOption("ftype")]
        [DefaultValue("")]
        [Description("")]
        protected override string FType
        {
            get
            {
                return "chunking";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(20)]
        [Description("")]
        public virtual int ChunkSize
        {
            get
            {
                return this.State.Get<int>("ChunkSize", 20);
            }
            set
            {
                this.State.Set("ChunkSize", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(0)]
        [Description("")]
        public virtual int RowHeight
        {
            get
            {
                return this.State.Get<int>("RowHeight", 0);
            }
            set
            {
                this.State.Set("RowHeight", value);
            }
        }
    }
}
