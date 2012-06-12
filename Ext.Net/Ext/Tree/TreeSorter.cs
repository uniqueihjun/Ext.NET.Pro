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
    public partial class TreeSorter : StateManagedItem
    {
        /// <summary>
        /// True for case-sensitive sort (defaults to false)
        /// </summary>
        [ConfigOption]
        [Category("1. TreeSorter")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("True for case-sensitive sort (defaults to false)")]
        public virtual bool CaseSensitive
        {
            get
            {
                object obj = this.ViewState["CaseSensitive"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["CaseSensitive"] = value;
            }
        }

        private SortDirection direction = SortDirection.Default;

        /// <summary>
        /// The direction to sort ("asc" or "desc," case-insensitive, defaults to "asc")
        /// </summary>
        [Category("1. TreeSorter")]
        [ConfigOption("dir", JsonMode.ToLower)]
        [DefaultValue(SortDirection.Default)]
        [NotifyParentProperty(true)]
        [Description("The direction to sort (\"asc\" or \"desc\" case-insensitive, defaults to \"asc\")")]
        public SortDirection Direction
        {
            get
            {
                return this.direction;
            }
            set
            {
                this.direction = value;
            }
        }

        /// <summary>
        /// True to sort leaf nodes under non-leaf nodes (defaults to false)
        /// </summary>
        [ConfigOption]
        [Category("1. TreeSorter")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("True to sort leaf nodes under non-leaf nodes (defaults to false)")]
        public virtual bool FolderSort
        {
            get
            {
                object obj = this.ViewState["FolderSort"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["FolderSort"] = value;
            }
        }

        /// <summary>
        /// The attribute used to determine leaf nodes when folderSort = true (defaults to "leaf")
        /// </summary>
        [ConfigOption]
        [Category("1. TreeSorter")]
        [DefaultValue("leaf")]
        [NotifyParentProperty(true)]
        [Description("The attribute used to determine leaf nodes when folderSort = true (defaults to \"leaf\")")]
        public virtual string LeafAttr
        {
            get
            {
                return (string)this.ViewState["LeafAttr"] ?? "leaf";
            }
            set
            {
                this.ViewState["LeafAttr"] = value;
            }
        }

        /// <summary>
        /// The named attribute on the node to sort by (defaults to "text"). Note that this property is only used if no sortType function is specified, otherwise it is ignored.
        /// </summary>
        [ConfigOption]
        [Category("1. TreeSorter")]
        [DefaultValue("text")]
        [NotifyParentProperty(true)]
        [Description("The named attribute on the node to sort by (defaults to \"text\"). Note that this property is only used if no sortType function is specified, otherwise it is ignored.")]
        public virtual string Property
        {
            get
            {
                return (string)this.ViewState["Property"] ?? "text";
            }
            set
            {
                this.ViewState["Property"] = value;
            }
        }

        private JFunction sortType;

        /// <summary>
        /// A custom "casting" function used to convert node values before sorting. The function will be called with a single parameter (the Ext.tree.TreeNode being evaluated) and is expected to return the node's sort value cast to the specific data type required for sorting. This could be used, for example, when a node's text (or other attribute) should be sorted as a date or numeric value. See the class description for example usage. Note that if a sortType is specified, any property config will be ignored.
        /// Parameters:
        ///     e  : the mousedown event
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("1. TreeSorter")]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("A custom \"casting\" function used to convert node values before sorting.")]
        public virtual JFunction SortType
        {
            get
            {
                if (this.sortType == null)
                {
                    this.sortType = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.sortType.Args = new string[] {"property", "node"};
                    }
                }

                return this.sortType;
            }
        }
    }
}