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
    public class ElementAnimationProperty
    {
        private object by;
        private object from;
        private object to;
        private string unit;

        /// <summary>
        /// relative change - start at current value, change by this value
        /// </summary>
        [Description("relative change - start at current value, change by this value")]
        public object By
        {
            get
            {
                return this.by;
            }
            set
            {
                this.by = value;
            }
        }

        /// <summary>
        /// ignore current value, start from this value
        /// </summary>
        [Description("ignore current value, start from this value")]
        public object From
        {
            get
            {
                return this.from;
            }
            set
            {
                this.from = value;
            }
        }

        /// <summary>
        /// start at current value, go to this value
        /// </summary>
        [Description("start at current value, go to this value")]
        public object To
        {
            get
            {
                return this.to;
            }
            set
            {
                this.to = value;
            }
        }

        /// <summary>
        /// any allowable unit specification
        /// </summary>
        [Description("any allowable unit specification")]
        public string Unit
        {
            get
            {
                return this.unit;
            }
            set
            {
                this.unit = value;
            }
        }
    }
}