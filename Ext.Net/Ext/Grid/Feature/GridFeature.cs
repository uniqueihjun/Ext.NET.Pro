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
    /// A feature is a type of plugin that is specific to the Ext.grid.Panel. It provides several hooks that allows the developer to inject additional functionality at certain points throughout the grid creation cycle. This class provides the base template methods that are available to the developer, it should be extended.
    /// 
    /// There are several built in features that extend this class, for example:
    /// 
    /// Ext.grid.feature.Grouping - Shows grid rows in groups as specified by the Ext.data.Store
    /// Ext.grid.feature.RowBody - Adds a body section for each grid row that can contain markup.
    /// Ext.grid.feature.Summary - Adds a summary row at the bottom of the grid with aggregate totals for a column.
    /// </summary>
    [Meta]
    public abstract partial class GridFeature : LazyObservable
    {
        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [ConfigOption("ftype")]
        [DefaultValue("")]
        [Description("")]
        protected virtual string FType
        {
            get
            {
                return "";
            }
        }

        /// <summary>
        /// Enable a feature
        /// </summary>
        public void Enable()
        {
            this.Call("enable");
        }

        /// <summary>
        /// Disable a feature
        /// </summary>
        public void Disable()
        {
            this.Call("disable");
        }

        private GridPanelBase featureOwner;

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected GridPanelBase FeatureOwner
        {
            get
            {
                return this.featureOwner;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected internal virtual void FeatureAdded()
        {
            this.featureOwner = (GridPanelBase)this.ParentComponent;
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected internal virtual void FeatureRemoved()
        {
        }
    }
}
