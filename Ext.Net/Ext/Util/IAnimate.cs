/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Drawing;

namespace Ext.Net
{
    /// <summary>
    /// This animation class is a mixin.
    /// 
    /// Ext.util.Animate provides an API for the creation of animated transitions of properties and styles.
    /// This class is used as a mixin and currently applied to Ext.Element, Ext.CompositeElement, Ext.draw.Sprite, Ext.draw.CompositeSprite, and Ext.Component. Note that Components have a limited subset of what attributes can be animated such as top, left, x, y, height, width, and opacity (color, paddings, and margins can not be animated).
    /// </summary>
    interface IAnimate
    {
        /// <summary>
        /// Perform custom animation on this object.
        /// </summary>
        /// <param name="cfg">An object containing properties which describe the animation's start and end states, and the timeline of the animation.</param>
        void Animate(AnimConfig cfg);

        /// <summary>
        /// Ensures that all effects queued after sequenceFx is called on this object are run in sequence. This is the opposite of syncFx.
        /// </summary>
        void SequenceFx();

        /// <summary>
        /// Stops any running effects and clears this object's internal effects queue if it contains any additional effects that haven't started yet.
        /// </summary>
        void StopAnimation();

        /// <summary>
        /// Ensures that all effects queued after syncFx is called on this object are run concurrently. This is the opposite of sequenceFx.
        /// </summary>
        void SyncFx();
    }
}