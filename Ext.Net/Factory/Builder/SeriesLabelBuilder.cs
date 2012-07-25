/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    /// <summary>
    /// 
    /// </summary>
    public partial class SeriesLabel
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : SpriteAttributes.Builder<SeriesLabel, SeriesLabel.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new SeriesLabel()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SeriesLabel component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SeriesLabel.Config config) : base(new SeriesLabel(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(SeriesLabel component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Specifies the presence and position of labels for each pie slice.
			/// </summary>
            public virtual SeriesLabel.Builder Display(SeriesLabelDisplay display)
            {
                this.ToComponent().Display = display;
                return this as SeriesLabel.Builder;
            }
             
 			/// <summary>
			/// The color of the label text. Default value: '#000' (black).
			/// </summary>
            public virtual SeriesLabel.Builder Color(string color)
            {
                this.ToComponent().Color = color;
                return this as SeriesLabel.Builder;
            }
             
 			/// <summary>
			/// True to render the label in contrasting color with the backround. Default value: false.
			/// </summary>
            public virtual SeriesLabel.Builder Contrast(bool contrast)
            {
                this.ToComponent().Contrast = contrast;
                return this as SeriesLabel.Builder;
            }
             
 			/// <summary>
			/// The name of the field to be displayed in the label. Default value: 'name'.
			/// </summary>
            public virtual SeriesLabel.Builder Field(string field)
            {
                this.ToComponent().Field = field;
                return this as SeriesLabel.Builder;
            }
             
 			/// <summary>
			/// Specifies the minimum distance from a label to the origin of the visualization. This parameter is useful when using PieSeries width variable pie slice lengths. Default value: 50.
			/// </summary>
            public virtual SeriesLabel.Builder MinMargin(int minMargin)
            {
                this.ToComponent().MinMargin = minMargin;
                return this as SeriesLabel.Builder;
            }
             
 			/// <summary>
			/// Either \"horizontal\" or \"vertical\". Dafault value: \"horizontal\".
			/// </summary>
            public virtual SeriesLabel.Builder Orientation(Orientation orientation)
            {
                this.ToComponent().Orientation = orientation;
                return this as SeriesLabel.Builder;
            }
             
 			/// <summary>
			/// Optional function for formatting the label into a displayable value. Default value: function(value) { return value; }
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of SeriesLabel.Builder</returns>
            public virtual SeriesLabel.Builder Renderer(Action<JFunction> action)
            {
                action(this.ToComponent().Renderer);
                return this as SeriesLabel.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public SeriesLabel.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.SeriesLabel(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public SeriesLabel.Builder SeriesLabel()
        {
            return this.SeriesLabel(new SeriesLabel());
        }

        /// <summary>
        /// 
        /// </summary>
        public SeriesLabel.Builder SeriesLabel(SeriesLabel component)
        {
            return new SeriesLabel.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public SeriesLabel.Builder SeriesLabel(SeriesLabel.Config config)
        {
            return new SeriesLabel.Builder(new SeriesLabel(config));
        }
    }
}