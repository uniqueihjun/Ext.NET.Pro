/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public abstract partial class GridPanelBase : TablePanel, IStore<Store>, INoneContentable
    {
        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(true)]
        [Description("")]
        public virtual bool SelectionSubmit
        {
            get
            {
                return this.State.Get<bool>("SelectionSubmit", true);
            }
            set
            {
                this.State.Set("SelectionSubmit", value);
            }
        }
        
        private ViewCollection<GridView> view;

        /// <summary>
        /// The Ext.grid.View used by the grid. This can be set before a call to render().
        /// </summary>
        [Meta]
        [ConfigOption("viewConfig>View")]
        [Category("7. GridPanel")]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("The Ext.grid.View used by the grid. This can be set before a call to render().")]
        public virtual ViewCollection<GridView> View
        {
            get
            {
                if (this.view == null)
                {
                    this.view = new ViewCollection<GridView>();
                    this.view.AfterItemAdd += this.AfterItemAdd;
                    this.view.AfterItemRemove += this.AfterItemRemove;
                }

                return this.view;
            }
        }

        private GridScrollerCollection verticalScroller;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("verticalScroller>Scroller")]
        [Category("7. GridPanel")]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("")]
        public virtual GridScrollerCollection VerticalScroller
        {
            get
            {
                if (this.verticalScroller == null)
                {
                    this.verticalScroller = new GridScrollerCollection();
                    this.verticalScroller.AfterItemAdd += this.AfterItemAdd;
                    this.verticalScroller.AfterItemRemove += this.AfterItemRemove;
                }

                return this.verticalScroller;
            }
        }

        /// <summary>
        /// Returns a GridPanel's View
        /// </summary>
        public GridView GetView()
        {
            return this.View.View;
        }

        private StoreCollection<Store> store;

        /// <summary>
        /// The Ext.Net.Store the grid should use as its data source (required).
        /// </summary>
        [Meta]
        [ConfigOption("store>Primary", 1)]
        [Category("7. GridPanel")]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("The Ext.Net.Store the grid should use as its data source (required).")]
        public virtual StoreCollection<Store> Store
        {
            get
            {
                if (this.store == null)
                {
                    this.store = new StoreCollection<Store>();
                    this.store.AfterItemAdd += this.AfterStoreAdd;
                    this.store.AfterItemRemove += this.AfterItemRemove;
                }

                return this.store;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        [Description("")]
        protected virtual void AfterStoreAdd(Store item)
        {
            this.Controls.AddAt(0, item);
            this.LazyItems.Insert(0, item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Store GetStore()
        {
            if (this.Store.Primary != null)
            {
                return this.Store.Primary;
            }

            if (this.StoreID.IsNotEmpty())
            {
                return ControlUtils.FindControl<Store>(this, this.StoreID, true);
            }

            return null;
        }

        ItemsCollection<GridFeature> features;

        /// <summary>
        /// An array of grid features
        /// </summary>
        [Meta]
        [ConfigOption(typeof(ItemCollectionJsonConverter))]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("An array of grid features")]
        public virtual ItemsCollection<GridFeature> Features
        {
            get
            {
                if (this.features == null)
                {
                    this.features = new ItemsCollection<GridFeature>();
                    this.features.AfterItemAdd += this.AfterFeatureAdd;
                    this.features.AfterItemRemove += this.AfterFeatureRemove;
                }

                return this.features;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="feature"></param>
        protected virtual void AfterFeatureAdd(GridFeature feature)
        {
            this.Controls.Add(feature);
            this.LazyItems.Add(feature);
            feature.FeatureAdded();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="feature"></param>
        protected virtual void AfterFeatureRemove(GridFeature feature)
        {
            this.Controls.Remove(feature);
            this.LazyItems.Remove(feature);
            feature.FeatureRemoved();
        }      
    }
}