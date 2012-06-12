/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class SpinnerListeners : ComponentListeners
    {
        private ComponentListener spin;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This field")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("spin", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener Spin
        {
            get
            {
                if (this.spin == null)
                {
                    this.spin = new ComponentListener();
                }

                return this.spin;
            }
        }

        private ComponentListener spinup;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This field")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("spinup", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener SpinUp
        {
            get
            {
                if (this.spinup == null)
                {
                    this.spinup = new ComponentListener();
                }

                return this.spinup;
            }
        }

        private ComponentListener spindown;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This field")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("spindown", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener SpinDown
        {
            get
            {
                if (this.spindown == null)
                {
                    this.spindown = new ComponentListener();
                }

                return this.spindown;
            }
        }
    }
}