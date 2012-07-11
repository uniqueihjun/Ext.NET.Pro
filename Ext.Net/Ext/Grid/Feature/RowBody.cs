/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// The rowbody feature enhances the grid's markup to have an additional tr -> td -> div which spans the entire width of the original row.
    ///
    /// This is useful to to associate additional information with a particular record in a grid.
    /// 
    /// Rowbodies are initially hidden unless you override getAdditionalData.
    /// 
    /// Will expose additional events on the gridview with the prefix of 'rowbody'. For example: 'rowbodyclick', 'rowbodydblclick', 'rowbodycontextmenu'.
    /// </summary>
    [Meta]
    public partial class RowBody : GridFeature
    {
        /// <summary>
        /// 
        /// </summary>
        public RowBody()
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
                return "Ext.grid.feature.RowBody";
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
                return "rowbody";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string RowBodyHiddenCls
        {
            get
            {
                return this.State.Get<string>("RowBodyHiddenCls", "");
            }
            set
            {
                this.State.Set("RowBodyHiddenCls", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string RowBodyTrCls
        {
            get
            {
                return this.State.Get<string>("RowBodyTrCls", "");
            }
            set
            {
                this.State.Set("RowBodyTrCls", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string RowBodyTdCls
        {
            get
            {
                return this.State.Get<string>("RowBodyTdCls", "");
            }
            set
            {
                this.State.Set("RowBodyTdCls", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string RowBodyDivCls
        {
            get
            {
                return this.State.Get<string>("RowBodyDivCls", "");
            }
            set
            {
                this.State.Set("RowBodyDivCls", value);
            }
        }

        private JFunction getAdditionalData;

        /// <summary>
        /// Provide additional data to the prepareData call within the grid view. The rowbody feature adds 3 additional variables into the grid view's template. These are rowBodyCls, rowBodyColspan, and rowBody.
        /// 
        /// Parameters
        /// data : Object
        /// The data for this particular record.
        /// idx : Number
        /// The row index for this record.
        /// record : Ext.data.Model
        /// The record instance
        /// orig : Object
        /// The original result from the prepareData call to massage.
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("")]
        public virtual JFunction GetAdditionalData
        {
            get
            {
                if (this.getAdditionalData == null)
                {
                    this.getAdditionalData = new JFunction();
                    if (!this.DesignMode)
                    {
                        this.getAdditionalData.Args = new string[] { "data", "idx", "record", "orig" };
                    }
                }

                return this.getAdditionalData;
            }
        }
    }
}
