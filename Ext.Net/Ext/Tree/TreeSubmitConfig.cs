/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class TreeSubmitConfig : BaseItem
    {
        /// <summary>
        /// Serialize node with children
        /// </summary>
        [ConfigOption]
        [Category("2. TreeSubmitConfig")]
        [DefaultValue(false)]
        [Description("Serialize node with children")]
        public virtual bool WithChildren
        {
            get
            {
                return this.State.Get<bool>("WithChildren", false);
            }
            set
            {
                this.State.Set("WithChildren", value);
            }
        }

        /// <summary>
        /// Disable automatic submit
        /// </summary>
        [ConfigOption]
        [Category("2. TreeSubmitConfig")]
        [DefaultValue(false)]
        [Description("Disable automatic submit")]
        public virtual bool DisableAutomaticSubmit
        {
            get
            {
                return this.State.Get<bool>("DisableAutomaticSubmit", false);
            }
            set
            {
                this.State.Set("DisableAutomaticSubmit", value);
            }
        }

        /// <summary>
        /// True to encode node's text
        /// </summary>
        [ConfigOption]
        [Category("2. TreeSubmitConfig")]
        [DefaultValue(false)]
        [Description("True to encode node's text")]
        public virtual bool Encode
        {
            get
            {
                return this.State.Get<bool>("Encode", false);
            }
            set
            {
                this.State.Set("Encode", value);
            }
        }

        /// <summary>
        /// The attr to use for the path (defaults to the node's id)
        /// </summary>
        [ConfigOption]
        [Category("3. TreeSubmitConfig")]
        [DefaultValue("id")]
        [NotifyParentProperty(true)]
        [Description("The attr to use for the path (defaults to the node's id)")]
        public virtual string PathAttribute
        {
            get
            {
                return this.State.Get<string>("PathAttribute", "id");
            }
            set
            {
                this.State.Set("PathAttribute", value);
            }
        }

        private JFunction nodeFilter;

        /// <summary>
        /// Node filter functon, return false to exclude the node
        /// Parameters:
        ///    node - filter node
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("3. TreeSubmitConfig")]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("Node filter functon, return false to exclude the node")]
        public virtual JFunction NodeFilter
        {
            get
            {
                if (this.nodeFilter == null)
                {
                    this.nodeFilter = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.nodeFilter.Args = new string[] {"node"};
                    }
                }

                return this.nodeFilter;
            }
        }

        private JFunction attributeFilter;

        /// <summary>
        /// Attribute filter functon, return false to exclude the attribute
        /// Parameters:
        ///    attrName - attribute's name
        ///    attrValue - attribute's value
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("3. TreeSubmitConfig")]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("Attribute filter functon, return false to exclude the attribute")]
        public virtual JFunction AttributeFilter
        {
            get
            {
                if (this.attributeFilter == null)
                {
                    this.attributeFilter = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.attributeFilter.Args = new string[] {"attrName", "attrValue"};
                    }
                }

                return this.attributeFilter;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public override bool IsDefault
        {
            get
            {
                return (this.PathAttribute.IsEmpty() || this.PathAttribute == "id") && 
                        !this.WithChildren &&
                        !this.DisableAutomaticSubmit &&
                        this.NodeFilter.IsDefault &&
                        AttributeFilter.IsDefault &&
                        !this.Encode;
            }
        }
    }
}