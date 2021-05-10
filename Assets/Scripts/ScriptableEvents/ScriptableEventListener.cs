using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents {
    public class ScriptableEventListener : MonoBehaviour {
        // The scriptable event you want to listen to.
        [SerializeField] ScriptableEvent scriptableEvent;
        // The reaction(s) you want to happen when the scriptable event is fired.
        [SerializeField] UnityEvent unityEvent;
        public void Awake() => scriptableEvent.Subscribe(this);
        public void OnDestroy() => scriptableEvent.UnSubscribe(this);
        public void Broadcast() => unityEvent.Invoke();

    }
}

