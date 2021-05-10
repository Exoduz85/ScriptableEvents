using UnityEngine;
using UnityEngine.EventSystems;

namespace ScriptableEvents {
    public class EventDemoClass : MonoBehaviour, IPointerClickHandler {
        // The scriptable event you want to use (to fire off)
        [SerializeField] ScriptableEvent onClick;
        
        public void OnPointerClick(PointerEventData eventData) {
            // Call the Invoke when you want to fire off the event.
            onClick.Invoke();
        }
    }
}