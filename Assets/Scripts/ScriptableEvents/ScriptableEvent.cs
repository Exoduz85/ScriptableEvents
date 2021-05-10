using System.Collections.Generic;
using UnityEngine;

namespace ScriptableEvents {
    [CreateAssetMenu(menuName = "Scriptable Event", fileName = "New Scriptable Event")]
    public class ScriptableEvent : ScriptableObject
    {
        // All the listeners the scriptable event has subscribed to itself
        readonly HashSet<ScriptableEventListener> EventListeners = new HashSet<ScriptableEventListener>();
        
        // Broadcast to all the listeners when the even fires off.
        public void Invoke() {
            foreach (var eventListener in EventListeners) {
                // Broadcast to each listener
                eventListener.Broadcast();
            }
        }
        // Subscribe to the scriptable event.
        public void Subscribe(ScriptableEventListener eventListener) => this.EventListeners.Add(eventListener);
        
        // Un-Subscribe to the scriptable event.
        public void UnSubscribe(ScriptableEventListener eventListener) => this.EventListeners.Remove(eventListener);
    }
}