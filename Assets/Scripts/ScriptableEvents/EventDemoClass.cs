using UnityEngine;
using UnityEngine.EventSystems;

namespace ScriptableEvents {
    public class EventDemoClass : MonoBehaviour, IPointerClickHandler {
        [SerializeField] ScriptableEvent onClick;
        
        public void OnPointerClick(PointerEventData eventData) {
            onClick.Invoke();
        }
    }
}