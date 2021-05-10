using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents {
    public class ScriptableEventListener : MonoBehaviour {
        [SerializeField] ScriptableEvent scriptableEvent;
        [SerializeField] UnityEvent unityEvent;
        public void Awake() => scriptableEvent.Subscribe(this);
        public void OnDestroy() => scriptableEvent.UnSubscribe(this);
        public void Broadcast() => unityEvent.Invoke();

    }
}

