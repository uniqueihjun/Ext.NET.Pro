/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Drawing;

namespace Ext.Net
{
    /// <summary>
    /// A mixin for being able to save the state of an object to an underlying Ext.state.Provider.
    /// </summary>
    interface IStateful
    {
        /// <summary>
        /// A buffer to be applied if many state events are fired within a short period (defaults to 100).
        /// </summary>
        int SaveDelay { get; set; }


        /// <summary>
        /// An array of events that, when fired, should trigger this component to save its state (defaults to none). These can be any types of events supported by this component, including browser or custom events (e.g., ['click', 'customerchange']).
        /// </summary>
        string[] StateEvents { get; set; }

        /// <summary>
        /// The unique id for this component to use for state management purposes (defaults to the component id).
        /// </summary>
        string StateID { get; set; }

        /// <summary>
        /// A flag which causes the AbstractComponent to attempt to restore the state of internal properties from a saved state on startup.
        /// </summary>
        bool Stateful { get; set; }

        /// <summary>
        /// Return component's data which should be saved by StateProvider
        /// </summary>
        JFunction GetState { get; }

        /// <summary>
        /// Add events that will trigger the state to be saved.
        /// </summary>
        /// <param name="events">The event name or an array of event names.</param>
        void AddStateEvents(string events);

        /// <summary>
        /// Add events that will trigger the state to be saved.
        /// </summary>
        /// <param name="events">The event name or an array of event names.</param>
        void AddStateEvents(string[] events);

        /// <summary>
        /// Destroys this stateful object.
        /// </summary>
        void Destroy();
    }
}