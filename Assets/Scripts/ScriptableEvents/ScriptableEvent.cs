using System.Collections.Generic;
using UnityEngine;

namespace ScriptableEvents {
    [CreateAssetMenu(menuName = "Scriptable Event", fileName = "New Scriptable Event")]
    public class ScriptableEvent : ScriptableObject
    {
        List<ScriptableEventListener> EventListeners = new List<ScriptableEventListener>();
        public void Invoke() {
            foreach (var eventListener in EventListeners) {
                eventListener.Broadcast();
            }
        }
        public void Subscribe(ScriptableEventListener eventListener) => this.EventListeners.Add(eventListener);
        public void UnSubscribe(ScriptableEventListener eventListener) => this.EventListeners.Remove(eventListener);
    }
}